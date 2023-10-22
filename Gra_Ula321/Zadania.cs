using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Ula321
{
    internal class Zadania
    {
        public static bool Walka(int[][] bochater, int[][] przciwnik, string n_prz)
        {
            //Console.WriteLine($"Walczysz z {n_prz}.");
            Console.WriteLine("Zaczęła się walka z Twoim nieprzyjacielem.");
            while (przciwnik[1][0] > 0 && bochater[1][1] > 0)
            {
                Console.WriteLine("**************");
                //Console.WriteLine("--------------");
                Console.WriteLine($"Twój przeciwnik ma {przciwnik[1][0]} hp");
                Console.WriteLine("Jaki atak chcesz zastosować?");
                Console.WriteLine($" 1 - miecz");
                Console.WriteLine(" 2 - łuk");
                Console.WriteLine(" 3 - magia");
                int wb = int.Parse(Console.ReadLine()) - 1;
                int at = bochater[0][wb] * bochater[1][4];
                przciwnik[1][0] -= at * przciwnik[0][wb];
                bochater[1][1] -= przciwnik[1][1] - bochater[1][2];

            }

            if (bochater[1][1] > 0)
            {
                Console.WriteLine($"POKONAŁEŚ {n_prz}!!!");
                Console.WriteLine($"Zostało Ci {bochater[1][1]} hp");
                Console.WriteLine("--------------");
                return true;
            }
            else
            {
                Console.WriteLine($"Zostałeś pokonany przez {n_prz} :((");
                return false;
            }
        }
        public static void Misja(int nr_misji, int[][] bochater, int nr_rn, string m_prz, string n_prz, int[][] przciwnik)
        {
            int nagroda = nr_misji + 1;
            nagroda = nagroda * 50 * nr_rn;
            bool wykonane = false;
            Console.WriteLine($"Udaj się do {m_prz}, aby pokonać {n_prz}");
            Console.WriteLine($"W zamian dostaniesz {nagroda} monet");
            if (!wykonane)
            {
                wykonane = Walka(bochater, przciwnik, n_prz);
            }
            if (wykonane)
            {
                bochater[1][3] += nagroda;
                Console.WriteLine("===========================================================");
                Console.WriteLine($"GRATULACJE!!! Wykonałeś zadanie. Masz teraz {bochater[1][3]} monet.");
                Console.WriteLine("===========================================================");
            }
        }

    }

}