function drawLineFromCorner(start_x, start_y, end_x, end_y, context) {
    context.moveTo(start_x, start_y);
    context.lineTo(end_x, end_y);
}

function drawFourLines(canvas, event) {
    const ctx = canvas.getContext('2d');
    clearCanvas(ctx, canvas);

    const rect = canvas.getBoundingClientRect();
    const x = event.clientX - rect.left;
    const y = event.clientY - rect.top;

    ctx.beginPath();
    drawLineFromCorner(0, 0, x, y, ctx);
    drawLineFromCorner(0, canvas.height, x, y, ctx);
    drawLineFromCorner(canvas.width, canvas.height, x, y, ctx);
    drawLineFromCorner(canvas.width, 0, x, y, ctx);
    
    ctx.stroke();
}

function clearCanvas(context, canvas) {
    context.clearRect(0, 0, canvas.width, canvas.height);
}

const canvasList = document.getElementsByClassName("canvas");
for (const canvas of canvasList) {
    canvas.addEventListener('mousemove', event => drawFourLines(canvas, event));
    canvas.addEventListener('mouseleave', () => clearCanvas(canvas.getContext('2d'), canvas));
}
