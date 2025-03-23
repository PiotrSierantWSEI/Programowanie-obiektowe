namespace Lab_02_cw
{
    public abstract class Pracownik
    {
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public string? Stanowisko { get; set; }
        public decimal Wynagrodzenie { get; set; }

        public abstract void PokazInformacje();

        public virtual decimal ObliczMiesieczneWynagrodzenie()
        {
            return Wynagrodzenie;
        }
        public virtual decimal ObliczDziennieWynagrodzenie()
        {
            return Wynagrodzenie / 21;
        }
        public virtual decimal ObliczRoczneWynagrodzenie()
        {
            return Wynagrodzenie * 12;
        }

        public virtual decimal ObliczIleNaGodzinę()
        {
            return Wynagrodzenie / 160;
        }
    }

    public class PracownikBiurowy : Pracownik
    {
        public int IloscGodzinPracy { get; set; }

        public override void PokazInformacje()
        {
            Console.WriteLine($"Pracownik biurowy: {Imie} {Nazwisko}, stanowisko: {Stanowisko}, wynagrodzenie miesięczne: {Wynagrodzenie}, ilość godzin pracy: {IloscGodzinPracy}");
        }

        public override decimal ObliczRoczneWynagrodzenie()
        {
            decimal bonus = IloscGodzinPracy > 160 ? (IloscGodzinPracy - 160) * (Wynagrodzenie / 160) : 0;
            return base.ObliczRoczneWynagrodzenie() + bonus;
        }
    }
    public class Menedzer : Pracownik
    {
        public decimal BonusRoczny { get; set; }

        public override void PokazInformacje()
        {
            Console.WriteLine($"Menedżer: {Imie} {Nazwisko}, stanowisko: {Stanowisko}, wynagrodzenie miesięczne: {Wynagrodzenie}, bonus roczny: {BonusRoczny}");
        }

        public override decimal ObliczRoczneWynagrodzenie()
        {
            return base.ObliczRoczneWynagrodzenie() + BonusRoczny;
        }
    }

    public class PracownikZdalny : Pracownik
    {
        public int IloscDniZdalnych { get; set; }

        public override void PokazInformacje()
        {
            Console.WriteLine($"Pracownik zdalny: {Imie} {Nazwisko}, stanowisko: {Stanowisko}, wynagrodzenie miesięczne: {Wynagrodzenie}, ilość dni zdalnych: {IloscDniZdalnych}");
        }
    }
}