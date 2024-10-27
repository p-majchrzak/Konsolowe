namespace Sortowanie.Test
{
    public class BombelkoweTest
    {
        [Fact]
        public void PrzekazywanaTablicaLosowychElementow_KiedyPoprawniePsortowana_WtedyPoprawnieDzialajacaMetoda()
        {
            int[] tablica = Bombelkowe.LosujElementy(1, 1001);
            int[] tablicaInaczejPosortowana = tablica;
            Array.Sort(tablicaInaczejPosortowana);
            Assert.Equal(tablicaInaczejPosortowana, Bombelkowe.Sortuj(tablica));
        }
    }
}