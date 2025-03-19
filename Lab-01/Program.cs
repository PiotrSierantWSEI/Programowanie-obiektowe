using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_1
{
    class Ulamek : IComparable<Ulamek>
    {
        public int licznik; public int mianownik;

        public Ulamek(int inLicznik, int inMianownik)
        {
            if (inMianownik == 0)
            {
                throw new DivideByZeroException();
            }
            this.licznik = inLicznik;
            this.mianownik = inMianownik;
        }

        public override string ToString()
        {
            return licznik.ToString() + "/" + mianownik.ToString();
        }

        public static Ulamek operator *(Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.licznik * u2.licznik, u1.mianownik * u2.mianownik);
        }

        public static Ulamek operator /(Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.licznik * u2.mianownik, u1.mianownik * u2.licznik);
        }

        public static Ulamek operator +(Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.licznik * u2.mianownik + u2.licznik * u1.mianownik, u1.mianownik * u2.mianownik);
        }

        public static Ulamek operator -(Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.licznik * u2.mianownik - u2.licznik * u1.mianownik, u1.mianownik * u2.mianownik);
        }

        public static bool operator >(Ulamek u1, Ulamek u2)
        {
            return (u1.licznik * u2.mianownik) > (u2.licznik * u1.mianownik);
        }

        public static bool operator <(Ulamek u1, Ulamek u2)
        {
            return (u1.licznik * u2.mianownik) < (u2.licznik * u2.mianownik);
        }

        public static bool operator ==(Ulamek u1, Ulamek u2)
        {
            if (ReferenceEquals(u1, u2)) return true;
            if (ReferenceEquals(u1, null) || ReferenceEquals(u2, null)) return false;

            return (u1.licznik * u2.mianownik) == (u2.licznik * u1.mianownik);
        }
        public static bool operator !=(Ulamek u1, Ulamek u2)
        {
            return (u1.licznik * u2.mianownik) != (u2.licznik * u1.mianownik);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Ulamek u = obj as Ulamek;
            if (u == null) return false;
            return (this.licznik * u.mianownik) == (u.licznik * this.mianownik);
        }

        public static explicit operator double(Ulamek u)
        {
            return (double)u.licznik / (double)u.mianownik;
        }

        public int CompareTo(Ulamek other)
        {
            if (other == null) return 1;
            return (this.licznik * other.mianownik).CompareTo(other.licznik * this.mianownik);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(licznik, mianownik);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek polowa = new Ulamek(1, 2);
            Ulamek cwierc = new Ulamek(1, 4);

            Console.WriteLine(polowa);
            Console.WriteLine(cwierc);

            Ulamek poMnozeniu = polowa * cwierc;

            Console.WriteLine(poMnozeniu);

            if (polowa > cwierc)
            {
                Console.WriteLine("Polowa jest wieksza od cwierci");
            }
            else
            {
                Console.WriteLine("Cwierc jest wieksza od polowy");
            }

            Ulamek liczbaX = new Ulamek(1, 3);
            double polowaDouble = (double)liczbaX;
            Console.WriteLine(polowaDouble);

            Ulamek[] tablica = { new Ulamek(1, 7), new Ulamek(6, 7), new Ulamek(3, 7), new Ulamek(5, 7) };

            Console.WriteLine("Tablica przed sortowaniem");

            foreach (Ulamek u in tablica)
            {
                Console.WriteLine(u);
            }

            Console.WriteLine("Tablica po sortowaniu");

            Array.Sort(tablica);

            foreach (Ulamek u in tablica)
            {
                Console.WriteLine(u);
            }
        }
    }
}

// init
