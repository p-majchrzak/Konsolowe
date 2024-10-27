using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzyka
{
    public class Piosenka
    {
        public string Artysta { get; set; }
        public string Album { get; set; }
        public int NumerPiosenki { get; set; }
        public int Rok { get; set; }
        public int NumerPobran { get; set; }
        public Piosenka() { }
        public Piosenka(string Artysta, string Album, int NumerPiosenki, int Rok, int NumerPobran)
        {
            this.Album = Album;
            this.NumerPobran = NumerPobran;
            this.Rok = Rok;
            this.Artysta = Artysta;
            this.NumerPiosenki = NumerPiosenki;
        }
    }
}
