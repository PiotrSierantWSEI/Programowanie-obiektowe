namespace Lab_02_cw
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik biurowy = new PracownikBiurowy
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Stanowisko = "Księgowy",
                Wynagrodzenie = 4000m,
                IloscGodzinPracy = 170
            };

            Pracownik menedzer = new Menedzer
            {
                Imie = "Anna",
                Nazwisko = "Nowak",
                Stanowisko = "Menedżer Projektu",
                Wynagrodzenie = 8000m,
                BonusRoczny = 10000m
            };

            biurowy.PokazInformacje();
            Console.WriteLine($"Roczne wynagrodzenie: {biurowy.ObliczRoczneWynagrodzenie()}");

            menedzer.PokazInformacje();
            Console.WriteLine($"Roczne wynagrodzenie: {menedzer.ObliczRoczneWynagrodzenie()}");
        }
    }
}