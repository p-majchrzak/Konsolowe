using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Muzyka
{
    public class Plik
    {
        public static List<Piosenka> PozyskajListe(string sciezka)
        {
            List<Piosenka> listaPiosenek = new List<Piosenka>();
            StreamReader czytaj = new StreamReader(sciezka);
            while(!czytaj.EndOfStream)
            {
                string artysta = czytaj.ReadLine();
                string album = czytaj.ReadLine();
                int numerPiosenki = int.Parse(czytaj.ReadLine());
                int rok = int.Parse(czytaj.ReadLine());
                int numerPobran = int.Parse(czytaj.ReadLine());
                string pominLinie = czytaj.ReadLine();
                Piosenka piosenka = new Piosenka(artysta,album, numerPiosenki, rok, numerPobran);
                listaPiosenek.Add(piosenka);
            }
            return listaPiosenek;
        }
        /**********************************************
            nazwa funkcji: PozyskajListe
            opis funkcji: Metoda zczytuje dane z pliku tekstowego i wpisuje zczytane elementy do obiektu, w kolejnym kroku umieszcza utworzone obiekty do listy.
            parametry: sciezka - zmienna typu tekstowego
            zwracany typ i opis: List<Piosenka> - lista zawierająca utworzone obiekty
            autor: PESEL Piotr Majchrzak
        ***********************************************/
        public static void WypiszListe(List<Piosenka> listaPiosenek)
        {
            foreach(Piosenka piosenka in listaPiosenek)
            {
                Console.WriteLine($"{piosenka.Artysta}\n{piosenka.Album}\n{piosenka.NumerPiosenki}\n{piosenka.Rok}\n{piosenka.NumerPobran}\n");
            }
        }
    }
}
