var DEFAULT_SIZE = 7;
var MINIMIMUM = 1;
var MAXIMUM = 99;

const tableDiv = document.getElementById('tableDiv');

function findRandom(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min
}

function odd_or_even(result) {
    if(result % 3 == 1) {
        color = "even";
    }else if (result % 3 == 2){
        color = "odd";
    }else {
        color = "by3";
    }
    document.write("<td class='" + color + "'>");
    document.write(result);
    document.write("</td>");
}

function enterN() {
    let userInput = window.prompt("Podaj numer pomiędzy 5 a 20", DEFAULT_SIZE);
    if (userInput <= 20 && userInput >= 5) {
        document.write("<h3 class='okUserInput'>Rozmiar tabliczki mnożenia wynosi: " + userInput + "x" + userInput + "</h3>");
        return userInput;
    }
    else {
        document.write("<h3 class='errorUserInput'>Podana liczba: " + userInput + " jest niepoprawna!!</h3>");
        document.write("<h3 class='okUserInput'>Rozmiar tabliczki mnożenia wynosi:  " + DEFAULT_SIZE + "x" + DEFAULT_SIZE + "</h3>");
        return DEFAULT_SIZE;
    }
}

function drawTable(n) {

    document.write("<table id='multiplyTable' border='1px'>");
    document.write("<thead><tr>");
    document.write("<td class='borders'>" + '   ' + "</td>");
    for (var i = 0; i < n; i++) {
        let elementId = "borderHigh" + i;
        document.write("<td id='" + elementId + "' class='borders'>" + findRandom(MINIMIMUM, MAXIMUM) + "</td>");
    }
    document.write("</tr></thead>");

    document.write("<tbody>")
    for(var i = 0; i < n; i++) {
        document.write("<tr>");
        for (var j = 0; j < n; j++) {
            if (j == 0) {
                let elementId = "borderLeft" + i;
                document.write("<td id='" + elementId + "' class='borders'>");
                document.write(document.getElementById("borderHigh" + i).childNodes[0].data);
                document.write("</td>");
            }
            
            let borderLeft = document.getElementById("borderLeft" + i).childNodes[0].data;
            let borderTop = document.getElementById("borderHigh" + j).childNodes[0].data;
            let result = borderTop* borderLeft;
            odd_or_even(result);
            
        }
        document.write("</tr>");
    }
    document.write("</tbody></table>");


}

document.getElementById("setTableSizeButton").addEventListener("click", function(e) {
    document.getElementById('tableDiv').innerHTML = '';
    location.reload();
}, true)

drawTable(enterN());
