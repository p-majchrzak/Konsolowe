using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kostka
{
    public static class Mechanika
    {
        public static void PodajIlosc()
        {
            Console.WriteLine("Ile kostek chcesz rzucić?(3 - 10)");
            int iloscKostek = int.Parse(Console.ReadLine());
            if (iloscKostek >= 3 && iloscKostek <= 10)
            {
                Zarzadzaj(iloscKostek);
            }
            else
            {
                PodajIlosc();
            }
        }
        /*
         ************************************************
            nazwa: Losuj
            opis: Losuje liczbe z przedziału od 1 do 6, oraz wpisuje ją do tablicy.
            parametry: iloscKostek - Ilosc losowań kostek (ile kostek zostało rzuconych).
            zwracany typ i opis: Brak
            autor: PESEL
         ************************************************
         */
        public static int[] Losuj(int iloscKostek)
        {
            Random losowa = new Random();
            int[] tablicaWynikow = new int[iloscKostek];
            for (int ilosc = 0; ilosc < iloscKostek; ilosc++)
            {
                int wynik = losowa.Next(1, 7);
                tablicaWynikow[ilosc] = wynik;
                Console.WriteLine($"Kostka {ilosc + 1}: {wynik}");
            }
            return tablicaWynikow;
        }
        public static void Zarzadzaj(int iloscKostek)
        {
            WypiszWynik(ZliczWynik(Losuj(iloscKostek)));
            Powtorz(iloscKostek);
        }
        public static int ZliczWynik(int[] liczby)
        {
            int wynik = 0;
            int[] licznik = new int[6];
            foreach (int liczba in liczby)
            {
                licznik[liczba - 1]++;
            }
            for (int i = 0; i < licznik.Length; i++)
            {
                if (licznik[i] > 1)
                {
                    wynik += licznik[i] * (i + 1);
                }
            }
            return wynik;
        }
        public static void WypiszWynik(int wynik)
        {
            Console.WriteLine($"Liczba uzyskanych punktów: {wynik}");
        }
        public static void Powtorz(int iloscKostek)
        {
            Console.WriteLine("Jeszcze raz? (t/n)");
            char znak = char.Parse(Console.ReadLine());
            if (znak == 't')
            {
                Losuj(iloscKostek);
            }
        }
    }
}
