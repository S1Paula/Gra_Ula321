using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Ula321
{
    internal class Postac
    {
        public static int[][] Bochater()
        {
            // 0 - broń  1 - statystyka
            int[][] ret = new int[2][];
            // 0 - miecz  1 - łuk  2 - magia
            int[] wojownik = new int[] { 20, 10, 1 };
            int[] czarodziej = new int[] { 10, 1, 20 };
            int[] elf = new int[] { 1, 20, 10 };

            Console.WriteLine("Wybierz postać");
            Console.WriteLine(" 1 - Wojownik");
            Console.WriteLine(" 2 - Czarodziej");
            Console.WriteLine(" 3 - Elf");

            int wb = int.Parse(Console.ReadLine());
            Console.WriteLine("________________________");
            switch (wb)
            {
                case 1:
                    ret[0] = wojownik;
                    break;
                case 2:
                    ret[0] = czarodziej;
                    break;
                case 3:
                    ret[0] = elf;
                    break;
            }
            //0 - max hp  1 - hp 2 - ochrona  3 - kasa  4 - broń
            ret[1] = new int[] { 500, 500, 10, 0, 1 };
            return ret;
        }

    }

}