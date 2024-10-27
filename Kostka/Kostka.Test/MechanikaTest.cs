namespace Kostka.Test
{
    public class MechanikaTest
    {
        [Theory]
        [InlineData(3, 1, 6, true)]
        [InlineData(4, 1, 6, true)]
        [InlineData(5, 1, 6, true)]
        public void SprawdzanieZakresuWylosowanychElementow_KiedyWylosowanoElementy_WtedyPoprawnoscDzialaniaMetody(int iloscKostek, int minimum, int maksimum, bool oczekiwanyWynik)
        {
            bool wynik = true;
            int[] tablicaWynikow = Mechanika.Losuj(iloscKostek);
            for (int i = 0; i < tablicaWynikow.Length; i++)
            {
                if (tablicaWynikow[i] < minimum || tablicaWynikow[i] > maksimum)
                {
                    wynik = false;
                    break;
                }
            }
            Assert.Equal(oczekiwanyWynik, wynik);
        }
    }
}