using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Velkommen til vores omregner");
            Console.WriteLine("-----------------");
            Console.WriteLine("Vælg et tal for at få din ønskede omregning");
            Console.WriteLine("1. Decimal");
            Console.WriteLine("2. Hex");
            Console.WriteLine("3. Binær");
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Skriv decimal tal: ");
                    String numberdec = Console.ReadLine();
                    string DecimaltoBinairy = Convert.ToString(Convert.ToInt32(numberdec, 10), 2);
                    string DecimaltoHex = Convert.ToString(Convert.ToInt32(numberdec, 10), 16);
                    Console.WriteLine("Binær: " + DecimaltoBinairy);
                    Console.WriteLine("Hex: " + DecimaltoHex);
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Skriv hex tal: ");
                    String numberhex = Console.ReadLine();
                    string Hextodec = Convert.ToString(Convert.ToInt32(numberhex, 16), 10);
                    string Hextobin = Convert.ToString(Convert.ToInt32(numberhex, 16), 2);
                    Console.WriteLine("Decimal: " + Hextodec);
                    Console.WriteLine("Binær: " + Hextobin);
                    Console.ReadLine();
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("Skriv binært tal: ");
                    String numberbin = Console.ReadLine();
                    string bintohex = Convert.ToString(Convert.ToInt32(numberbin, 2), 16);
                    string bintodec = Convert.ToString(Convert.ToInt32(numberbin, 2), 10);
                    Console.WriteLine("Hex: " + bintohex);
                    Console.WriteLine("Decimal: " + bintodec);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine();
                    break;
            }



        }
    }
}
