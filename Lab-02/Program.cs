namespace Lab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            SamochodOsobowy samochod = new SamochodOsobowy
            {
                Marka = "Toyota",
                TypSilnika = "benzyna",
                MaksymalnaPrędkość = 220,
                Spalanie = 7.5,
                Ciężar = 1450,
                Cena = 100000,
                IloscDrzwi = 5,
                Szyberdach = true,
                CzyMozeCiagnacPrzyczepke = true
            };

            var motocykl = new Motocykl
            {
                Marka = "Yamaha",
                TypSilnika = "benzyna",
                MaksymalnaPrędkość = 180,
                Spalanie = 5.0,
                Ciężar = 250,
                Cena = 45000,
                MaKufry = true
            };

            var ciezarowka = new Ciezarowka
            {
                Marka = "Volvo",
                TypSilnika = "diesel",
                MaksymalnaPrędkość = 140,
                Spalanie = 30.0,
                Ciężar = 7500,
                Cena = 300000,
                Ladownosc = 24000
            };

            samochod.WyswietlInformacje();
            motocykl.WyswietlInformacje();
            ciezarowka.WyswietlInformacje();
        }
    }
}