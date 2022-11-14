using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dolgozat_megoldasok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"adatok.txt\" fájl feldolgozása...");
            int[] szamok = new int[10];
            StreamReader be = new StreamReader("adatok.txt");

            for (int i = 0; i < 10; i++)
            {
                int szam = Convert.ToInt32(be.ReadLine());
                szamok[i] = szam;
            }

            be.Close();

            //számok összege
            int sum = 0;
            foreach (var sz in szamok)
            {
                sum = sum + sz;
            }

            Console.WriteLine($"Számok összege: {sum}");

            //5-tel v 3-al oszthato
            Console.WriteLine("5-tel vagy 3-mal osztható számok:");

            foreach (var sz in szamok)
            {
                if (sz % 5 == 0 || sz % 3 == 0)
                {
                    Console.WriteLine(sz);
                }
            }

            Console.WriteLine("\n--**--**--\n");

            //szamok kulombsege
            Console.WriteLine("\"parban.txt\" fájl feldolgozása...");            
            StreamReader be2 = new StreamReader("parban.txt");
            Console.WriteLine("Számok különbsége:");
            for (int i = 0; i < 10; i++)
            {
                string[] adatok = be2.ReadLine().Split(';');
                int szam1 = Convert.ToInt32(adatok[0]);
                int szam2 = Convert.ToInt32(adatok[1]);
                Console.WriteLine(szam1 - szam2);
            }

            Console.ReadKey();
        }
    }
}
