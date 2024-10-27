using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesel
{
    public static class NumerPesel
    {
        static public bool SprawdzPoprawnosc(char[] pesel)
        {
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i == 0 || i == 4 || i == 8)
                {
                    S += int.Parse(pesel[i].ToString());
                }
                if (i == 1 || i == 5 || i == 9)
                {
                    S += int.Parse(pesel[i].ToString()) * 3;
                }
                if (i == 2 || i == 6)
                {
                    S += int.Parse(pesel[i].ToString()) * 7;
                }
                if (i == 3 || i == 7)
                {
                    S += int.Parse(pesel[i].ToString()) * 9;
                }
            }
            int M = S % 10;
            int R = 0;
            if (M == 0)
            {
                R = 0;
            }
            else
            {
                R = 10 - M;
            }
            if (R == int.Parse(pesel[10].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
         **********************************************
            nazwa funkcji: SprawdzPlec
            opis funkcji: Funkcja sprawdza 10 liczbę numeru pesel, czy posiadacz jest mężczyzną, bądź kobietą.
            parametry: pesel - tablica znakowa przechowująca numer pesel
            zwracany typ i opis: znak - zmienna znakowa, zwraca znak 'k', bądź 'm', w zależności od 10 liczby numeru pesel
            autor: PESEL
         ***********************************************
         */
        static public char SprawdzPlec(char[] pesel)
        {
            char znak;
            if (int.Parse(pesel[9].ToString()) % 2 == 0)
            {
                znak = 'K';
            }
            else
            {
                znak = 'M';
            }
            return znak;
        }
    }
}
