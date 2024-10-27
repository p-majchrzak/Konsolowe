namespace Pesel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] pesel = new char[11] { '5', '5', '0','3','0','1','0','1','1','9','3'};
            for (int i = 0; i < pesel.Length; i++)
            {
                Console.WriteLine($"Podaj {i + 1} liczbę numeru PESEL: ");
                char znak = char.Parse(Console.ReadLine());
                pesel[i] = znak;
            }
            char plec = NumerPesel.SprawdzPlec(pesel);
            if (plec == 'M')
            {
                Console.WriteLine("Mężczyzna");
            }
            else
            {
                Console.WriteLine("Kobieta");
            }
            bool poprawnosc = NumerPesel.SprawdzPoprawnosc(pesel);
            if (poprawnosc)
            {
                Console.WriteLine("Zgodność sumy kontrolnej.");
            }
            else
            {
                Console.WriteLine("Niezgodność sumy kontrolnej.");
            }
        }
    }
}
