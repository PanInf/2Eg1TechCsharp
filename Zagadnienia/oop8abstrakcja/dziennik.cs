using System;
using System.Collections.Generic;

/*Napisz program - dziennik elektroniczny (fragment)

Użyj dziedziczenia, 2 klas abstrakcyjnych i 3 interfejsów

Stestuj fragment kodu, gdzie jest dziedziczenie

1. Use case'y (czasowniki, rzeczowniki, przymiotniki)
- Nauczyciel wystawia ocenę (ma listę ocen wystawionych przez siebie)
-Rodzic usprawiedliwia Ucznia
- Wychowawca zwalnia Ucznia

2. Dziedziczenie
- AbstractOsoba (abstract imie, abstract przedstaw), Nauczyciel, Uczen, Rodzic, AbstractAdmin, Dyrektor, Wychowawca
- AbstractOcena(string wartosc), Stopien, Opisowa
- IWagaOceny(przypiszWage())(odnośnie do stopnia)
-IUsprawiedliwic
- IZwolnij*/


namespace Dziennik
{
    interface IUsprawieliw
    {
        void WyslijUprawiedliwienie();
    }
    interface IZwolnij
    {
        void ZwolnijZLekcji();
    }
    interface IWagaOceny
    {
        void przypiszWage();
    }

    abstract class Ocena
    {
        public string Wartosc { get; set; }
    }
    class Stopien : Ocena, IWagaOceny
    {
        public void przypiszWage()
        {
           // działanie :)))
        }
    }
    class Opisowa : Ocena { }
    abstract class AbstractOsoba
    {
        public abstract string Imie { get; set; }

        public abstract void Przedstaw();
    }
    class Nauczyciel : AbstractOsoba
    {
        List<Ocena> oceny;
        public override string Imie { get; set; }

        public override void Przedstaw()
        {
            Console.WriteLine("Dzień Dobry");
        }

        public void WystawOcene(Ocena ocena)
        {
            oceny.Add(ocena);
        }
    }
    class Rodzic : AbstractOsoba, IUsprawieliw
    {
        public override string Imie { get; set; }

        public override void Przedstaw()
        {
            Console.WriteLine("Yo!");
        }

        public void WyslijUprawiedliwienie() { }
    }
    class Uczen : AbstractOsoba
    {
        public override string Imie { get; set; }

        public override void Przedstaw()
        {
            Console.WriteLine("ESSA");
        }
    }

    abstract class AbstractAdmin : AbstractOsoba
    {

    }
    class Dyrektor : AbstractAdmin
    {
        public override string Imie { get; set; }

        public override void Przedstaw()
        {
            Console.WriteLine("ESSA");
        }
    }

    class Wychowawca : AbstractAdmin, IZwolnij
    {
        public override string Imie { get; set; }

        public override void Przedstaw()
        {
            Console.WriteLine("ESSA");
        }

        public void ZwolnijZLekcji() { }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Ocena oc1 = new Stopien();
            oc1.Wartosc = "5";
            Nauczyciel nau1 = new Nauczyciel();
            nau1.Imie = "Bartosz";
            nau1.WystawOcene(oc1);
        }
    }
}
