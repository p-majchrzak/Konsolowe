using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    public class Bombelkowe
    {
        public static int[] LosujElementy(int minimum, int maksimum)
        {
            int[] elementy = new int[100];
            Random losowa = new Random();
            for (int i = 0; i < elementy.Length; i++)
            {
                elementy[i] = losowa.Next(minimum, maksimum);
            }
            return elementy;
        }
        public static int[] Sortuj(int[] elementy)
        {
            for (int i = 0; i < elementy.Length; i++)
            {
                for (int j = 0; j < elementy.Length - i - 1; j++)
                {
                    if (elementy[j] > elementy[j + 1])
                    {
                        int tmp = elementy[j];
                        elementy[j] = elementy[j + 1];
                        elementy[j + 1] = tmp;
                    }
                }
            }
            return elementy;
        }
        public static void Wyswietl(int[] elementy)
        {
            foreach (int i in elementy)
            {
                Console.WriteLine(i + ",");
            }
        }
    }
}
