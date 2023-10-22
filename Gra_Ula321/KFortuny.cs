using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gra_Ula321
{
    internal class KFortuny
    {
        public static bool Kolofortunywybor(int[][] bohater, string imie)
        {

            Console.WriteLine("OSTRZEŻENIE! Pamiętaj o tym, że możesz wygrać, albo stracić.");
            Console.WriteLine("KRĘCISZ KOŁEM NA WŁASNĄ ODPOWIEDZIALNOŚĆ :)");
            Console.WriteLine("Kręcenie kołem fortuny kosztuje 50 monet.");
            Console.WriteLine($"Czy chcesz zakręcić kołem, {imie}?");
            Console.WriteLine("1 - Tak");
            Console.WriteLine("2 - Nie");
            int wybor = int.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    if (bohater[1][3] >= 50)
                    {
                        bohater[1][3] -= 50;
                        Console.WriteLine("");
                        Console.WriteLine($"Zostało Ci {bohater[1][3]} monet");
                        Console.WriteLine("");
                        Kolofortuny_k(bohater, imie);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("_________________________________________________________");
                        Console.WriteLine("Nie masz wystarczającej ilości monet, aby zakręcić kołem.");
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("");
                        return false;
                    }

                case 2:
                    return false;
            }

            return false;
        }

        //KOŁO FORTUNY
        public static bool Kolofortuny_k(int[][] bohater, string imie)
        {
            Random rndK = new Random();
            int zw_K = rndK.Next(11);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Oto moment decydujący o Twojej wygranej, graczu {imie}.");
            Console.WriteLine("PAMIĘTAJ, że może oznaczać to zarówno wygraną, jak i stratę.");
            Console.WriteLine("W tej chwili koło fortuny się zatrzymało, ukazując nagrodę.");
            Console.WriteLine("******");
            Thread.Sleep(2000);


            if (zw_K == 0)
            {
                Console.WriteLine("Twoją nagrodą jest...");
                Thread.Sleep(1000); //ppp
                Console.WriteLine("skrzynia monet");
                Thread.Sleep(1000);//ppp
                Console.WriteLine("Daje Ci 120 monet.");
                bohater[1][3] += 120; //monety
                Console.WriteLine("");
                Console.WriteLine($"Masz teraz {bohater[1][3]}");
                Console.WriteLine("");
                return true;
            }
            if (zw_K == 1)
            {
                Console.WriteLine("Twoją nagrodą jest...");
                Thread.Sleep(1000);
                Console.WriteLine("eliksir życia");
                Thread.Sleep(1000);
                Console.WriteLine("Daje Ci +30 hp oraz +30 MAX hp.");
                bohater[1][0] += 30; //MAX hp
                bohater[1][1] += 30; //hp
                Console.WriteLine("");
                Console.WriteLine($"Masz teraz {bohater[1][0]} MAX hp oraz {bohater[1][1]} hp.");
                Console.WriteLine("");
                return true;
            }
            if (zw_K == 2)
            {
                Console.WriteLine("Twoją nagrodą jest...");
                Thread.Sleep(1000);
                Console.WriteLine("skrzynia fortuny");
                Thread.Sleep(1000);
                Console.WriteLine("Podwaja Ci liczbę twoich monet.");
                bohater[1][3] += bohater[1][3]; //monety
                Console.WriteLine("");
                Console.WriteLine($"Masz teraz {bohater[1][3]} monet.");
                Console.WriteLine("");
                return true;
            }
            if (zw_K == 3)
            {
                Console.WriteLine("Twoją nagrodą jest...");
                Thread.Sleep(1000);
                Console.WriteLine("+ 35 broni");
                bohater[1][4] += 35; //broń
                Console.WriteLine("");
                Console.WriteLine($"Masz teraz {bohater[1][4]} broni.");
                Console.WriteLine("");
                return true;
            }
            if (zw_K == 4)
            {
                Console.WriteLine("Niestety szczęście Ci nie sprzyja.");
                Console.WriteLine("Wylosowałeś...");
                Thread.Sleep(1000);
                Console.WriteLine("stratę wszystkich monet, jakie posiadasz");
                bohater[1][3] -= bohater[1][3]; //monety
                Console.WriteLine("");
                Console.WriteLine($"Masz teraz {bohater[1][3]} monet.");
                Console.WriteLine("");
                return true;
            }
            if (zw_K == 5)
            {
                Console.WriteLine("Twoją nagrodą jest...");
                Thread.Sleep(1000);
                Console.WriteLine("sekretna mikstura");
                Thread.Sleep(1000);
                Console.WriteLine("Uzdrawia Cię do maksymalnego hp, a w zamian odbiera Ci - 5 obrony.");
                bohater[1][2] -= 5;
                int odj = bohater[1][0] - bohater[1][1];
                bohater[1][1] += odj;
                Console.WriteLine("");
                Console.WriteLine($"Masz teraz {bohater[1][2]} obrony i {bohater[1][1]} hp.");
                Console.WriteLine("");
                return true;
            }
            if (zw_K == 6)
            {
                Console.WriteLine("Niestety szczęście Ci nie sprzyja.");
                Console.WriteLine("Nie udało Ci się wygrać NIC.");
                Thread.Sleep(1000);
                Console.WriteLine("Może następnym razem uda Ci się coć wygrać.");
                Console.WriteLine("");
                return true;
            }
            if (zw_K == 7)
            {
                Console.WriteLine("Twoją nagrodą jest...");
                Thread.Sleep(1000);
                Console.WriteLine("jedno życzenie od wróżki");
                Console.WriteLine("");
                Console.WriteLine("Możesz wybrać nagrodę, jaką chcesz otrzymać od wróżki, spośród podanych: ");
                Console.WriteLine("1 - 100 monet");
                Console.WriteLine("2 - 25 broni");
                Console.WriteLine("3 - 20 hp oraz 20 Max hp");
                Console.WriteLine("4 - 35 Max hp");
                Console.WriteLine("5 - 20 obrony");
                Console.WriteLine("6 - 70 monet i 10 obrony");
                Console.WriteLine("7 - NIC :D");

                //WYBÓR 
                int wb_wrozka = int.Parse(Console.ReadLine());
                if (wb_wrozka == 1)
                {
                    bohater[1][3] += 100;
                    Console.WriteLine("");
                    Console.WriteLine($"Masz teraz {bohater[1][3]} monet");
                    Console.WriteLine("");
                    return true;
                }
                if (wb_wrozka == 2)
                {
                    bohater[1][4] += 25;
                    Console.WriteLine("");
                    Console.WriteLine($"Masz teraz {bohater[1][4]} broni");
                    Console.WriteLine("");
                    return true;
                }
                if (wb_wrozka == 3)
                {
                    bohater[1][1] += 20; //hp
                    bohater[1][0] += 20; //Max hp
                    Console.WriteLine("");
                    Console.WriteLine($"Masz teraz {bohater[1][1]} hp i {bohater[1][0]} MAX hp.");
                    Console.WriteLine("");
                    return true;
                }
                if (wb_wrozka == 4)
                {
                    bohater[1][0] += 35; //MAX hp
                    Console.WriteLine("");
                    Console.WriteLine($"Masz teraz {bohater[1][0]} MAX hp.");
                    Console.WriteLine("");
                    return true;
                }
                if (wb_wrozka == 5)
                {
                    bohater[1][2] += 20;
                    Console.WriteLine("");
                    Console.WriteLine($"Masz teraz {bohater[1][2]} obrony.");
                    Console.WriteLine("");
                    return true;
                }
                if (wb_wrozka == 6)
                {
                    bohater[1][3] += 70; //monety
                    bohater[1][2] += 10; //obrona
                    Console.WriteLine("");
                    Console.WriteLine($"Masz teraz {bohater[1][3]} monet i {bohater[1][2]} obrony.");
                    Console.WriteLine("");
                    return true;
                }
                if (wb_wrozka == 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Zgodnie z twoją prośba, {imie} nie otrzymujesz NIC.");
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                    return true;
                }
            }
            if (zw_K == 8)
            {
                if (bohater[1][1] >= 50)
                {
                    Console.WriteLine("Niestety szczęście Ci nie sprzyja.");
                    Console.WriteLine("Wylosowałeś...");
                    Thread.Sleep(1000);
                    Console.WriteLine("klątwe");
                    Thread.Sleep(1000);
                    Console.WriteLine("Tracisz przez klątwe 30 hp.");
                    bohater[1][1] -= 30;
                    Console.WriteLine("");
                    Console.WriteLine($"Masz teraz {bohater[1][1]} hp.");
                    Console.WriteLine("");
                    return true;
                }
                if (bohater[1][1] < 50)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Niestety nie wylosowałeś NIC.");
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                    return false;
                }
            }
            if (zw_K == 9)
            {
                Console.WriteLine("Niestety szczęście Ci nie sprzyja.");
                Console.WriteLine("Wylosowałeś...");
                Thread.Sleep(1000);
                Console.WriteLine("stratę połowy monet");
                int l = bohater[1][3] / 2;
                bohater[1][3] -= l;
                Console.WriteLine("");
                Console.WriteLine($"Masz teraz {bohater[1][3]} monet");
                Console.WriteLine("");
                return true;
            }
            if (zw_K == 10)
            {
                if (bohater[1][1] >= 30)
                {
                    bohater[1][1] -= 15;

                    if (bohater[1][4] >= 20)
                    {
                        Console.WriteLine("Niestety szczęście Ci nie sprzyja.");
                        Console.WriteLine("Wylosowałeś...");
                        Thread.Sleep(1000);
                        Console.WriteLine("osłabienie");
                        Thread.Sleep(1000);
                        Console.WriteLine("Powoduje to stratę 15 hp oraz 10 broni");
                        bohater[1][4] -= 10;
                        Console.WriteLine("");
                        Console.WriteLine($"Masz teraz {bohater[1][1]} hp i {bohater[1][4]} broni.");
                        Console.WriteLine("");
                        return true;
                    }

                    if (bohater[1][4] < 20)
                    {
                        Console.WriteLine("Niestety szczęście Ci nie sprzyja.");
                        Console.WriteLine("Wylosowałeś...");
                        Thread.Sleep(1000);
                        Console.WriteLine("osłabienie");
                        Thread.Sleep(1000);
                        Console.WriteLine("Powoduje to stratę 15 hp.");
                        Console.WriteLine("");
                        Console.WriteLine($"Masz teraz {bohater[1][1]} hp.");
                        Console.WriteLine("");
                        return true;
                    }
                }

                if (bohater[1][1] < 30)
                {
                    if (bohater[1][4] >= 20)
                    {
                        Console.WriteLine("Niestety szczęście Ci nie sprzyja.");
                        Console.WriteLine("Wylosowałeś...");
                        Thread.Sleep(1000);
                        Console.WriteLine("osłabienie");
                        Thread.Sleep(1000);
                        Console.WriteLine("Powoduje to stratę 10 broni.");
                        bohater[1][4] -= 10;
                        Console.WriteLine("");
                        Console.WriteLine($"Masz teraz {bohater[1][4]} broni.");
                        Console.WriteLine("");
                        return true;
                    }

                    if (bohater[1][4] < 20)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Niestety nie wylosowałeś NIC.");
                        Console.WriteLine("");
                        Thread.Sleep(1000);
                        return false;
                    }
                }
            }
            if (zw_K == 11)
            {
                if (bohater[1][2] >= 20)
                {
                    Console.WriteLine("Niestety szczęście Ci nie sprzyja.");
                    Console.WriteLine("Wylosowałeś...");
                    Thread.Sleep(1000);
                    Console.WriteLine("efekt oślepienia");
                    Thread.Sleep(1000);
                    Console.WriteLine("Powoduje on, że tracisz 10 obrony");
                    bohater[1][2] -= 10;
                    Console.WriteLine("");
                    Console.WriteLine($"Teraz masz {bohater[1][2]} obrony.");
                    Console.WriteLine("");
                    return true;
                }
                if (bohater[1][2] < 20)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Niestety nie wylosowałeś NIC.");
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                    return false;
                }
            }

            return false;
        }
    }
}
