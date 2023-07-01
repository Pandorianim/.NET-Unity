using System;

namespace l5z1
{
    class Program
    {
        static double[] trinomialFormula(double a, double b, double c)
        {
            int howMany = 0;

            double delta = b * b - 4 * a * c;
            double[] wyj;
            if (a==0 && b==0 && c == 0)
            {
                wyj = null;
            }
            else if (a == 0.0 && b == 0.0)
            {
                wyj = new double[0];
            }
            else if (a == 0.0)
            {
                howMany = 1;
                wyj = new double[howMany];
                wyj[0] = -c / b;
            }
            else if (delta > 0)
            {
                howMany = 2;
                wyj = new double[howMany];
                wyj[0] = (-b + Math.Sqrt(delta)) / (2 * a);
                wyj[1] = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            else if (delta == 0)
            {
                howMany = 1;
                wyj = new double[howMany];
                wyj[0] = (-b) / (2 * a);
            }
            else if (delta < 0)
            {
                wyj = new double[0];
            }
            else
            {
                wyj = new double[0];
            }
            return wyj;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The result of formula is:");
            double [] result = trinomialFormula(0, 0, 0);
            if (result == null)
            {
                Console.WriteLine("Nullowo");
            }
            else
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine(result[i] + " dlugosc tablicy:" + result.Length);
                }
            }

        }
    }
}
