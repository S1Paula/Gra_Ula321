using Gra_Ula321;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Ula321
{
    internal class Rundy : Przeciwnicy.Przeciwnik
    {
        public static int[][] Runda1(int zw)
        {
            //Console.WriteLine(rnd.Next());
            //int[][] prz = new int[2][];//
            int[][] prz = new int[2][];//
            prz[1] = new int[3];//pppp
            //////////////////////
            Przeciwnicy.Przeciwnik Syrena = new Przeciwnicy.Przeciwnik();//0
            Syrena.Hp = 100;
            Syrena.Atak = 40;
            Syrena.Bron = new int[] { 1, 2, 3 }; // 0 - miecz  1 - łuk  2 - magia
            Syrena.NumerRundy = 1;
            Przeciwnicy.Przeciwnik Golem = new Przeciwnicy.Przeciwnik();//1
            Golem.Hp = 90;
            Golem.Atak = 45;
            Golem.Bron = new int[] { 2, 0, 3 };
            Golem.NumerRundy = 1;
            Przeciwnicy.Przeciwnik Centaur = new Przeciwnicy.Przeciwnik();//2
            Centaur.Hp = 75;
            Centaur.Atak = 50;
            Centaur.Bron = new int[] { 1, 0, 3 };
            Centaur.NumerRundy = 1;
            Przeciwnicy.Przeciwnik Cyklop = new Przeciwnicy.Przeciwnik(); //3
            Cyklop.Hp = 80;
            Cyklop.Atak = 40;
            Cyklop.Bron = new int[] { 3, 1, 3 };
            Cyklop.NumerRundy = 1;

            //Losowanie przeciwnika
            if (zw == 0)
            {
                prz[0] = Syrena.Bron;
                prz[1][0] = Syrena.Hp;
                prz[1][1] = Syrena.Atak;
                prz[1][2] = Syrena.NumerRundy;
            }
            if (zw == 1)
            {
                prz[0] = Golem.Bron;
                prz[1][0] = Golem.Hp;
                prz[1][1] = Golem.Atak;
                prz[1][2] = Golem.NumerRundy;
            }
            if (zw == 2)
            {
                prz[0] = Centaur.Bron;
                prz[1][0] = Centaur.Hp;
                prz[1][1] = Centaur.Atak;
                prz[1][2] = Centaur.NumerRundy;
            }
            if (zw == 3)
            {
                prz[0] = Cyklop.Bron;
                prz[1][0] = Cyklop.Hp;
                prz[1][1] = Cyklop.Atak;
                prz[1][2] = Cyklop.NumerRundy;
            }

            return prz;

        }
        public static string[] Runda1_str(int zw)
        {
            string[] prz_str = new string[2]; //DDD*/  /*  <---------*/
            if (zw == 0)
            {
                prz_str = new string[] { "syrene", "Perłowego Zamku" }; //DDD
            }
            if (zw == 1)
            {
                prz_str = new string[] { "golema", "Skalnej Twierdzy" };//DDD
            }
            if (zw == 2)
            {
                prz_str = new string[] { "centaura", "Doliny Centaurów" };//DDD
            }
            if (zw == 3)
            {
                prz_str = new string[] { "cyklopa", "Mrocznej Jaskini" };//DDD
            }
            return prz_str;
        }

        public static int[][] Runda2(int zw1)
        {
            int[][] prz1 = new int[2][]; //DDD
            prz1[1] = new int[3];//pppp
            /////////////////////////////////
            Przeciwnicy.Przeciwnik WielkaStopa = new Przeciwnicy.Przeciwnik(); //0
            WielkaStopa.Hp = 130;
            WielkaStopa.Atak = 60;
            WielkaStopa.Bron = new int[] { 3, 0, 2 };
            WielkaStopa.NumerRundy = 2;
            Przeciwnicy.Przeciwnik Utopiec = new Przeciwnicy.Przeciwnik(); //1
            Utopiec.Hp = 150;
            Utopiec.Atak = 55;
            Utopiec.Bron = new int[] { 2, 1, 3 };
            Utopiec.NumerRundy = 2;
            Przeciwnicy.Przeciwnik Wampir = new Przeciwnicy.Przeciwnik(); //2
            Wampir.Hp = 150;
            Wampir.Atak = 60;
            Wampir.Bron = new int[] { 3, 1, 2 };
            Wampir.NumerRundy = 2;
            Przeciwnicy.Przeciwnik Troll = new Przeciwnicy.Przeciwnik(); //3
            Troll.Hp = 155;
            Troll.Atak = 65;
            Troll.Bron = new int[] { 2, 0, 3 };
            Troll.NumerRundy = 2;

            //Losowanie przeciwnika
            if (zw1 == 0)
            {
                prz1[0] = WielkaStopa.Bron;
                prz1[1][0] = WielkaStopa.Hp;
                prz1[1][1] = WielkaStopa.Atak;
                prz1[1][2] = WielkaStopa.NumerRundy;
            }
            if (zw1 == 1)
            {
                prz1[0] = Utopiec.Bron;
                prz1[1][0] = Utopiec.Hp;
                prz1[1][1] = Utopiec.Atak;
                prz1[1][2] = Utopiec.NumerRundy;
            }
            if (zw1 == 2)
            {
                prz1[0] = Wampir.Bron;
                prz1[1][0] = Wampir.Hp;
                prz1[1][1] = Wampir.Atak;
                prz1[1][2] = Wampir.NumerRundy;
            }
            if (zw1 == 3)
            {
                prz1[0] = Troll.Bron;
                prz1[1][0] = Troll.Hp;
                prz1[1][1] = Troll.Atak;
                prz1[1][2] = Troll.NumerRundy;
            }
            return prz1;
        }
        public static string[] Runda2_str(int zw1)
        {
            string[] prz_str1 = new string[2]; //DDD*/  /*  <---------*/
            if (zw1 == 0)
            {
                prz_str1 = new string[] { "wielką stopę", "Tajemniczego Świata" }; //DDD
            }
            if (zw1 == 1)
            {
                prz_str1 = new string[] { "utopca", "Zatopionego Miasta" };//DDD
            }
            if (zw1 == 2)
            {
                prz_str1 = new string[] { "wampira", "Mrocznego Dworu" };//DDD
            }
            if (zw1 == 3)
            {
                prz_str1 = new string[] { "trolla", "Jaskini Troli" };//DDD
            }
            return prz_str1;
        }
        public static int[][] Runda3(int zw2)
        {
            int[][] prz2 = new int[2][]; //DDD
            prz2[1] = new int[3];//pppp
            /////////////////////////////////////
            Przeciwnicy.Przeciwnik Bazyliszek = new Przeciwnicy.Przeciwnik(); //0
            Bazyliszek.Hp = 170;
            Bazyliszek.Atak = 55;
            Bazyliszek.Bron = new int[] { 3, 0, 2 };
            Bazyliszek.NumerRundy = 3;
            Przeciwnicy.Przeciwnik Harpie = new Przeciwnicy.Przeciwnik(); //1
            Harpie.Hp = 150;
            Harpie.Atak = 70;
            Harpie.Bron = new int[] { 2, 1, 3 };
            Harpie.NumerRundy = 3;
            Przeciwnicy.Przeciwnik Wilkolak = new Przeciwnicy.Przeciwnik(); //2
            Wilkolak.Hp = 160;
            Wilkolak.Atak = 65;
            Wilkolak.Bron = new int[] { 3, 2, 1 };
            Wilkolak.NumerRundy = 3;
            Przeciwnicy.Przeciwnik MrocznyElf = new Przeciwnicy.Przeciwnik(); //3
            MrocznyElf.Hp = 165;
            MrocznyElf.Atak = 65;
            MrocznyElf.Bron = new int[] { 2, 1, 3 };
            MrocznyElf.NumerRundy = 3;

            //Losowanie przeciwnika
            if (zw2 == 0)
            {
                prz2[0] = Bazyliszek.Bron;
                prz2[1][0] = Bazyliszek.Hp;
                prz2[1][1] = Bazyliszek.Atak;
                prz2[1][2] = Bazyliszek.NumerRundy;
            }
            if (zw2 == 1)
            {
                prz2[0] = Harpie.Bron;
                prz2[1][0] = Harpie.Hp;
                prz2[1][1] = Harpie.Atak;
                prz2[1][2] = Harpie.NumerRundy;
            }
            if (zw2 == 2)
            {
                prz2[0] = Wilkolak.Bron;
                prz2[1][0] = Wilkolak.Hp;
                prz2[1][1] = Wilkolak.Atak;
                prz2[1][2] = Wilkolak.NumerRundy;
            }
            if (zw2 == 3)
            {
                prz2[0] = MrocznyElf.Bron;
                prz2[1][0] = MrocznyElf.Hp;
                prz2[1][1] = MrocznyElf.Atak;
                prz2[1][2] = MrocznyElf.NumerRundy;
            }
            return prz2;
        }
        public static string[] Runda3_str(int zw2)
        {
            string[] prz_str2 = new string[2]; //DDD*/  /*  <---------*/
            if (zw2 == 0)
            {
                prz_str2 = new string[] { "bazyliszka", "Jaskini" }; //DDD
            }
            if (zw2 == 1)
            {
                prz_str2 = new string[] { "harpie", "Tajemnicza Dolina" };//DDD
            }
            if (zw2 == 2)
            {
                prz_str2 = new string[] { "wilkołaka", "Księżycowej Doliny" };//DDD
            }
            if (zw2 == 3)
            {
                prz_str2 = new string[] { "mrocznego elfa", "Zapomnianego Lasu" };//DDD
            }
            return prz_str2;
        }
        public static int[][] Runda4(int zw3)
        {
            int[][] prz3 = new int[2][]; //DDD
            prz3[1] = new int[3];//pppp
            /////////////////////
            Przeciwnicy.Przeciwnik Smok = new Przeciwnicy.Przeciwnik(); //0
            Smok.Hp = 200;
            Smok.Atak = 70;
            Smok.Bron = new int[] { 2, 3, 1 };
            Smok.NumerRundy = 4;
            Przeciwnicy.Przeciwnik Cerber = new Przeciwnicy.Przeciwnik(); //1
            Cerber.Hp = 175;
            Cerber.Atak = 75;
            Cerber.Bron = new int[] { 2, 0, 3 };
            Cerber.NumerRundy = 4;
            Przeciwnicy.Przeciwnik Sfinks = new Przeciwnicy.Przeciwnik(); //2
            Sfinks.Hp = 205;
            Sfinks.Atak = 55;
            Sfinks.Bron = new int[] { 1, 0, 3 };
            Sfinks.NumerRundy = 4;
            Przeciwnicy.Przeciwnik Meduza = new Przeciwnicy.Przeciwnik(); //3
            Meduza.Hp = 180;
            Meduza.Atak = 70;
            Meduza.Bron = new int[] { 1, 1, 3 };
            Meduza.NumerRundy = 4;

            //Losowanie przeciwnika
            if (zw3 == 0)
            {
                prz3[0] = Smok.Bron;
                prz3[1][0] = Smok.Hp;
                prz3[1][1] = Smok.Atak;
                prz3[1][2] = Smok.NumerRundy;
            }
            if (zw3 == 1)
            {
                prz3[0] = Cerber.Bron;
                prz3[1][0] = Cerber.Hp;
                prz3[1][1] = Cerber.Atak;
                prz3[1][2] = Cerber.NumerRundy;
            }
            if (zw3 == 2)
            {
                prz3[0] = Sfinks.Bron;
                prz3[1][0] = Sfinks.Hp;
                prz3[1][1] = Sfinks.Atak;
                prz3[1][2] = Sfinks.NumerRundy;
            }
            if (zw3 == 3)
            {
                prz3[0] = Meduza.Bron;
                prz3[1][0] = Meduza.Hp;
                prz3[1][1] = Meduza.Atak;
                prz3[1][2] = Meduza.NumerRundy;
            }
            return prz3;
        }
        public static string[] Runda4_str(int zw3)
        {
            string[] prz_str3 = new string[2]; //DDD*/  /*  <---------*/
            if (zw3 == 0)
            {
                prz_str3 = new string[] { "smoka", "Smoczej Doliny" }; //DDD
            }
            if (zw3 == 1)
            {
                prz_str3 = new string[] { "cerbera", "Piekielne Zamczysko" };//DDD
            }
            if (zw3 == 2)
            {
                prz_str3 = new string[] { "sfinksa", "Zagadkowe Miejsce" };//DDD
            }
            if (zw3 == 3)
            {
                prz_str3 = new string[] { "meduze", "Morskiego Królestwa" };//DDD
            }
            return prz_str3;
        }
    }
}