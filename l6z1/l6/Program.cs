using System;

namespace l6
{
    class Program
    {
        static void printTuple((int, string, string) tuple)
        {
            Console.WriteLine(tuple.Item1 + tuple.Item2 + tuple.Item3);
        }
        static void DrawCard(string fLine, string sLine = "Nazwisko", char znak = 'X', int widthLine = 2, int widthMin = 20)
        {
            for (int i = 0; i < 6; i++)
            {
                if (i == 2)
                {
                    for (int k = 0; k < widthLine; k++)
                    {
                        Console.Write(znak);
                    }
                    double remainingSpaceFLine = widthMin - 2 * widthLine - fLine.Length;
                    int firstSplitFLine = Convert.ToInt32(Math.Ceiling(remainingSpaceFLine / 2));
                    for (int k = 0; k < firstSplitFLine; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(fLine);
                    for (int k = 0; k < remainingSpaceFLine-firstSplitFLine; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < widthLine; k++)
                    {
                        Console.Write(znak);
                    }

                }
                else if (i == 3)
                {
                    for (int k = 0; k < widthLine; k++)
                    {
                        Console.Write(znak);
                    }
                    double remainingSpaceSLine = widthMin - 2 * widthLine - sLine.Length;
                    int firstSplitSLine = Convert.ToInt32(Math.Ceiling(remainingSpaceSLine / 2));
                    for (int k = 0; k < firstSplitSLine; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(sLine);
                    for (int k = 0; k < remainingSpaceSLine - firstSplitSLine; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < widthLine; k++)
                    {
                        Console.Write(znak);
                    }

                }
                else
                {
                    for (int j = 0; j < widthMin; j++)
                    {

                        Console.Write(znak);
                    }
                }
                Console.WriteLine();
            }
        }
        static (int, int, int, int) CountMyTypes (params Object [] args)
        {
            int intCounter = 0;
            int doubleCounter = 0;
            int stringCounter = 0;
            int elseCounter = 0;
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case int:
                        if (Convert.ToInt32(args[i]) % 2 == 0)
                        {
                            intCounter++;
                            break;
                        }
                        goto default;
                    case double:
                        if (Convert.ToDouble(args[i]) > 0)
                        {
                            doubleCounter++;
                            break;
                        }
                        goto default;
                    case string:
                        if (Convert.ToString(args[i]).Length >= 5)
                        {
                            stringCounter++;
                            break;
                        }
                        goto default;
                    default:
                        elseCounter++;
                        break;
                }
            }
            var tuple = (intCounter, doubleCounter, stringCounter, elseCounter);
            return tuple;
        }
        static void Main(string[] args)
        {
            var czlowiek = (Wiek: 22, Imie: "Jan", Nazwisko: "Kowal");
            printTuple(czlowiek);
            Console.WriteLine(czlowiek.Wiek + czlowiek.Imie + czlowiek.Nazwisko);
            var (z1, z2, z3) = (23, "Cos", 1.32);
            Console.WriteLine(z1 + z2 + z3);
            (int wiek, string imie, string nazwisko)= (22, "Jan", "Kowal");

            string @class = "Class wita";
            Console.WriteLine(@class);

            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };
            var readOnly = Array.AsReadOnly(intArray);
            var binary = Array.BinarySearch(intArray, 4);
            var clone = intArray.Clone();
            var enumerator = intArray.GetEnumerator();
            var index = Array.IndexOf(intArray, 5);

            DrawCard("Ryszard");
            DrawCard("Ryszard", znak: '2');

            Console.WriteLine(CountMyTypes(2, 2, 2.1, 2, 3, "hehe", "fajne", (2, 2)));
        }
    }
}
