﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Ula321
{
    internal class Shop
    {
        public static void Sklep(int[][] bochater)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("KUP..");
            Console.WriteLine(" 1 - hp");
            Console.WriteLine(" 2 - obrona");
            Console.WriteLine(" 3 - broń");

            int co = int.Parse(Console.ReadLine());
            switch (co)
            {
                case 1:
                    Zycko(bochater);
                    break;
                case 2:
                    Obrona(bochater);
                    break;
                case 3:
                    Bron(bochater);
                    break;
            }
        }
        public static void Zycko(int[][] bochater)
        {
            int[] bohater = bochater[1];
            Console.WriteLine("");
            Console.WriteLine("========================");
            Console.WriteLine("Twoje...             ");
            Console.WriteLine($" Max hp - {bohater[0]}");
            Console.WriteLine($" hp - {bohater[1]}    ");
            Console.WriteLine($" Monety - {bohater[3]}");
            Console.WriteLine("========================");
            Console.WriteLine("");
            Console.WriteLine("WYBIERZ!!!");
            Console.WriteLine(" 1 - + MAX hp");
            Console.WriteLine(" 2 - uzdrowienie");
            int wb = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------");
            int cena = 0;
            switch (wb)
            {
                case 1:
                    Console.WriteLine(" 1 -- +10 (20 monet)");
                    Console.WriteLine(" 2 -- +50 (90 monet)");
                    Console.WriteLine(" 3 - +100 (160 monet)");
                    int ile = 0;
                    int co = int.Parse(Console.ReadLine());
                    switch (co)
                    {
                        case 1:
                            cena = 20;
                            ile = 10;
                            break;
                        case 2:
                            cena = 90;
                            ile = 50;
                            break;
                        case 3:
                            cena = 160;
                            ile = 100;
                            break;
                    }
                    if (cena <= bohater[3])
                    {
                        bohater[0] += ile;
                        bohater[3] -= cena;
                    }
                    else
                    {
                        Console.WriteLine("_________________________________________");
                        Console.WriteLine("Nie masz wystarczająco monet!!!");
                        Console.WriteLine("_________________________________________");
                    }
                    break;
                case 2:
                    Console.WriteLine(" 1 - uzdrowienie (150 monet)");
                    int u = int.Parse(Console.ReadLine());
                    if (u == 1)
                    {
                        cena = 150;
                    }
                    if (cena <= bohater[3])
                    {
                        //bohater[1] += bohater[0]; //DO POPRAWY
                        bohater[3] -= cena;
                        int cos = bohater[0] - bohater[1];
                        bohater[1] += cos;
                    }
                    else
                    {
                        Console.WriteLine("_________________________________________");
                        Console.WriteLine("Nie masz wystarczająco monet!!!");
                        Console.WriteLine("_________________________________________");
                    }
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("========================");
            Console.WriteLine("Twoje...");
            Console.WriteLine($" Max hp - {bohater[0]}");
            Console.WriteLine($" hp - {bohater[1]}");
            Console.WriteLine($" Monety - {bohater[3]}");
            Console.WriteLine("========================");
            Console.WriteLine("");
        }
        public static void Obrona(int[][] bochater)
        {
            int[] bohater = bochater[1];
            Console.WriteLine("");
            Console.WriteLine("========================");
            Console.WriteLine("Twoje...");
            Console.WriteLine($" obrona - {bohater[2]}");
            Console.WriteLine($" Monety - {bohater[3]}");
            Console.WriteLine("========================");
            Console.WriteLine("");
            Console.WriteLine("WYBIERZ!!!");
            Console.WriteLine(" 1 - +10 (10 monet)");
            Console.WriteLine(" 2 - +20 (20 monet)");
            Console.WriteLine(" 3 - +30 (30 monet)");

            int co = int.Parse(Console.ReadLine());
            int ile = 0;
            int cena = 0;
            switch (co)
            {
                case 1:
                    ile = 10;
                    cena = 10;
                    break;
                case 2:
                    ile = 20;
                    cena = 20;
                    break;
                case 3:
                    ile = 30;
                    cena = 30;
                    break;
            }
            if (cena <= bohater[3])
            {
                bohater[2] += ile;
                bohater[3] -= cena;
            }
            else
            {
                Console.WriteLine("_________________________________________");
                Console.WriteLine("Nie masz wystarczająco monet!!!");
                Console.WriteLine("_________________________________________");
            }
            Console.WriteLine("");
            Console.WriteLine("========================");
            Console.WriteLine("Twoje...");
            Console.WriteLine($" obrona - {bohater[2]}");
            Console.WriteLine($" Monety - {bohater[3]}");
            Console.WriteLine("========================");
            Console.WriteLine("");
        }
        public static void Bron(int[][] bochater)
        {
            int[] bohater = bochater[1];
            Console.WriteLine("");
            Console.WriteLine("========================");
            Console.WriteLine("Twoje...");
            Console.WriteLine($" broń - {bohater[4]}");
            Console.WriteLine($" Monety - {bohater[3]}");
            Console.WriteLine("========================");
            Console.WriteLine("");
            Console.WriteLine(" 1 - +10 (20 monet)");
            Console.WriteLine(" 2 - +20 (40 monet)");
            Console.WriteLine(" 3 - +30 (60 monet)");
            int co = int.Parse(Console.ReadLine());
            int ile = 0;
            int cena = 0;
            switch (co)
            {
                case 1:
                    ile = 10;
                    cena = 20;
                    break;
                case 2:
                    ile = 20;
                    cena = 40;
                    break;
                case 3:
                    ile = 30;
                    cena = 60;
                    break;
            }
            if (cena <= bohater[3])
            {
                bohater[3] -= cena;
                bohater[4] += ile;
            }
            else
            {
                Console.WriteLine("_________________________________________");
                Console.WriteLine("Nie masz wystarczająco monet!!!");
                Console.WriteLine("_________________________________________");
            }
        }
    }
}
