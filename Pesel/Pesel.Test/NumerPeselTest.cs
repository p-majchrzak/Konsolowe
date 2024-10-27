namespace Pesel.Test
{
    public class NumerPeselTest
    {
        [Theory]
        [InlineData("80072909146", 'K', true)]
        [InlineData("81100216357", 'M', true)]
        public void PrzekazywanyPesel_KiedyZgodnosciPlci_PoprawneDzialanieMetody(string pesel, char plec, bool oczekiwanyWynik)
        {
            Assert.Equal(oczekiwanyWynik, NumerPesel.SprawdzPlec(pesel.ToCharArray()).Equals(plec));
        }
        [Theory]
        [InlineData("80072909146", true)]
        [InlineData("81100216357", true)]
        public void PrzekazywanyPesel_KiedyPoprawnoscPeselu_PoprawneDzialanieMetody(string pesel, bool oczekiwanyWynik)
        {
            Assert.Equal(oczekiwanyWynik, NumerPesel.SprawdzPoprawnosc(pesel.ToCharArray()));
        }
    }
}