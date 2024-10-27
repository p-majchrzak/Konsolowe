namespace Muzyka.Test
{
    public class PlikTest
    {
        [Fact]
        public void PrzekazywanyFragmentPliku_KiedyZgodnoscObiektow_WtedyPoprawneDzialanieMetody()
        {
            string[] fragmentPliku = {
                 "Gorillaz", "\"The Now Now\"", "11", "2018", "11000102"
            };
            Piosenka piosenka = new Piosenka(fragmentPliku[0], fragmentPliku[1], int.Parse(fragmentPliku[2]), int.Parse(fragmentPliku[3]), int.Parse(fragmentPliku[4]));
            List<Piosenka> listaPiosenek = Plik.PozyskajListe("Data.txt");
            bool weryfikacja = false;
            if (listaPiosenek[0].Artysta == piosenka.Artysta && listaPiosenek[0].Album == piosenka.Album && listaPiosenek[0].Rok == piosenka.Rok && listaPiosenek[0].NumerPiosenki == piosenka.NumerPiosenki && listaPiosenek[0].NumerPobran == piosenka.NumerPobran)
            {
                weryfikacja = true;
            }
            Assert.True(weryfikacja);
        }
    }
}