using System;

namespace l5zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a n (number of numbers):");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 1)
            {
                Console.WriteLine("N must be bigger than 1! Input again!");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int biggest = Int32.MinValue;
            int secondBiggest = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > biggest)
                {
                    secondBiggest = biggest;
                    biggest = input;
                }
                else if (input > secondBiggest & input != biggest)
                {
                    secondBiggest = input;
                }
            }
            if (secondBiggest == Int32.MinValue)
            {
                Console.WriteLine("No solution");
            }
            else
            {
                Console.WriteLine("Second biggest is: " + secondBiggest);
            }
        }
    }
}
