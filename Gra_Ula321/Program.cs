using Gra_Ula321;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gra_Ula321
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WOJNA ŚWIATÓW");
            Thread.Sleep(1000);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Podaj nazwę gracza...");
            string imie = Console.ReadLine();
            Console.WriteLine("******");
            Console.WriteLine($"Witaj w grze, {imie}!");
            Thread.Sleep(800);
            Console.WriteLine("-----------------------------------------------------");
            //////////////////////
            int[][] bohater = Postac.Bochater();
            int nr_rn = 1;
            int nr_misji = 0;

            int[][][] p = new int[4][][];
            //////////////////////
            Random rnd = new Random();
            int zw = rnd.Next(3);

            Random rnd1 = new Random();
            int zw1 = rnd1.Next(3);

            Random rnd2 = new Random();
            int zw2 = rnd2.Next(3);

            Random rnd3 = new Random();
            int zw3 = rnd3.Next(3);

            while (bohater[1][1] > 0)
            {
                Console.WriteLine("Co robisz?");
                Console.WriteLine(" 1 - idź do sklepu");
                Console.WriteLine(" 2 - idź walczyć");
                Console.WriteLine(" 3 - koło fortuny");
                int co = int.Parse(Console.ReadLine());
                //Console.WriteLine("-------------");
                switch (co)
                {
                    case 1:
                        Shop.Sklep(bohater);
                        break;
                    case 2:
                        if (nr_misji == 0)
                        {
                            Console.WriteLine("-----------------------------------------------------");
                            Zadania.Misja(nr_misji, bohater, nr_rn, Rundy.Runda1_str(zw)[1], Rundy.Runda1_str(zw)[0], Rundy.Runda1(zw));
                        }
                        if (nr_misji == 1)
                        {
                            Console.WriteLine("-----------------------------------------------------");
                            Zadania.Misja(nr_misji, bohater, nr_rn, Rundy.Runda2_str(zw1)[1], Rundy.Runda2_str(zw1)[0], Rundy.Runda2(zw1));
                        }
                        if (nr_misji == 2)
                        {
                            Console.WriteLine("-----------------------------------------------------");
                            Zadania.Misja(nr_misji, bohater, nr_rn, Rundy.Runda3_str(zw2)[1], Rundy.Runda3_str(zw2)[0], Rundy.Runda3(zw2));
                        }
                        if (nr_misji == 3)
                        {
                            Console.WriteLine("-----------------------------------------------------");
                            Zadania.Misja(nr_misji, bohater, nr_rn, Rundy.Runda4_str(zw3)[1], Rundy.Runda4_str(zw3)[0], Rundy.Runda4(zw3));
                        }

                        nr_misji++;
                        if (nr_misji == 3)
                        {
                            nr_misji -= 3;
                            nr_rn++;
                        }
                        break;
                    case 3:
                        Console.WriteLine("-----------------------------------------------------");
                        KFortuny.Kolofortunywybor(bohater, imie);
                        Console.WriteLine("-----------------------------------------------------");
                        break;

                }

            }
            Console.ReadKey();
        }
    }
}