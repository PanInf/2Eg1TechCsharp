using System;
using System.Data.SqlTypes;

namespace Sroda
{
    class Student1
    {
        public int numer;
        public string imie;
    }

    class Student2
    {
        private int numer;
        private string imie;

        public int GetNumer()
        {
            return numer;
        }

        public void SetNumer(int aNumer)
        {
            this.numer = aNumer;
        }
        public string GetImie()
        {
            return imie;
        }

        public void SetImie(string aImie)
        {
            this.imie = aImie;
        }
    }

    class Student3
    {
        int numer;
        string imie;

        public int Numer
        {
            get
            {
                return numer;
            }
            set
            {
                numer = value;
            }
        }
        public string Imie { get => imie; set => imie = value; }
    }

    class Student4
    {
        // property - właściwość jakby "bez pola"
        public int Numer { get; set; }
        public string Imie { get; set; }
    }



    class Animal
    {
        //ustawiamy 2 właściwości Name i Domestic
        public string Name { get; set; }
        public bool Domestic { get; set; }

        public virtual void Introduce()
        {
            Console.WriteLine("Hau hau");
        }

    }
    class Pies : Animal
    {
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine(Name + " - Hau od Psa");
        }
    }
    class Wilk : Animal
    {
        public override void Introduce()
        {
            Console.WriteLine(Name + " - Hau od Wilka");
        }
    }

    // Base Class: Firma (pole nip z gerterem: "NIP - to nip firmy") i metoda WystawFakture()
    // Derived Class: Polska, Niemiecka
    // Klasy mają mieć konstruktory
    // Klasy Derived mają dodawać przed nip przedrostek PL/DE (w geterze)

    class Firma
    {
        protected string nip;
        public virtual string NIP
        {
            get
            {
                return nip + " - to nip firmy";
            }
        }
        public Firma(string nip)
        {
            this.nip = nip;
        }
    }

    class Polska : Firma
    {
        public override string NIP
        {
            get
            {
                return "PL" + base.NIP;
            }
        }

        public Polska(string nip) : base(nip)
        {
        }
    }

    class Niemiecka : Firma
    {
        public override string NIP
        {
            get
            {
                return "DE" + base.NIP;
            }
        }
        public Niemiecka(string nip) : base(nip)
        {

        }
    }



    class MojProgram
    {
        private static int Wieksza(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
        public static void Main()
        {
            /*Console.WriteLine("CZESC");
            Console.WriteLine(Wieksza(4,7));

            Student1 s1 = new Student1();
            s1.numer = 4;
            s1.imie = "Bogdan";
            Console.WriteLine(s1.numer + " " + s1.imie);

            Student2 s2 = new Student2();
            s2.SetNumer(5);
            s2.SetImie("Jerzy");
            Console.WriteLine(s2.GetNumer() + " " + s2.GetImie());

            Student3 s3 = new Student3();
            s3.Numer = 7;
            s3.Imie = "Marek";
            Console.WriteLine(s3.Numer + " " + s3.Imie);

            Student4 s4 = new Student4();
            s4.Numer = 9;
            s4.Imie = "Włodek";
            Console.WriteLine(s4.Numer + " " + s4.Imie);*/

            /*Pies p = new Pies();
            p.Name = "Burek";
            p.Introduce();

            Wilk w = new Wilk();
            w.Name = "Basior";
            w.Introduce();*/

            Polska p = new Polska("123-123-12-12");
            Console.WriteLine(p.NIP);

            Niemiecka n = new Niemiecka("789-789-78-78");
            Console.WriteLine(n.NIP);

            Console.ReadKey();
        }
    }
}
