using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplikationstabell
{
    class Program
    {
        static void Main(string[] args)
        {

            string text;
            int tal;

            Console.WriteLine("Det här är Multiplikatonstapl for tal mellan 1 och 10");
            Console.WriteLine("Skriv det talet du vill se:");
            text = Console.ReadLine();
            tal = int.Parse(text);

            Console.WriteLine("1 . " + tal + " = " + tal * 1 );
            Console.WriteLine("2 . " + tal + " = " + tal * 2 );
            Console.WriteLine("3 . " + tal + " = " + tal * 3 );
            Console.WriteLine("4 . " + tal + " = " + tal * 4 );
            Console.WriteLine("5 . " + tal + " = " + tal * 5 );
            Console.WriteLine("6 . " + tal + " = " + tal * 6 );
            Console.WriteLine("7 . " + tal + " = " + tal * 7 );
            Console.WriteLine("8 . " + tal + " = " + tal * 8 );
            Console.WriteLine("9 . " + tal + " = " + tal * 9 );
            Console.WriteLine("10 . " + tal + " = " + tal * 10 );
            


            Console.ReadKey();
        }
    }
}
