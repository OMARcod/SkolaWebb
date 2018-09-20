using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string inmatat;
            int tal;

            Console.Write("Mata in ett tal: ");
            inmatat = Console.ReadLine();
            tal = int.Parse(inmatat);
            
            

            Console.WriteLine("Du mataade in talet  " + inmatat);
            Console.WriteLine("Dubbla talet blir  " + tal * 2);


            Console.ReadKey();
        }
    }
}
