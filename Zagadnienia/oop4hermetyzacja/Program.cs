
using System;


namespace Hermetyzacja1
{
    //Rozgrzewka
    //Klasa Termos +pojemnosc, +waga, +cena, +zawartosc: herbata,
    //              polej(), umyj()
    //Klasa Herbata -krajPochodzenia, +nazwa, +aromat, sparz()
    //Zrobić kompozycje tych 2 klas.
    // Dokonać hermetyzacji pól
    class Herbata
    {

        private string krajPochodzenia;
        private string nazwa;
        private string aromat;

        // C# styl hermetyzacji - na razie proszę tego nie stosować
        public string Aromat 
        {
            get
            {
                return aromat;
            }
            set
            {
                aromat = value;
            }
        }

        // hermetyzacja getery i setery
        public string getKrajPochodzenia()
        {
            return krajPochodzenia;
        }
        public void setKrajPochodzenia(string kraj)
        {
            this.krajPochodzenia = kraj;
        }

        public void sparz()
        {
            Console.WriteLine("Parze herbe");
        }
    }

    class Termos
    {
        private int Pojemnosc;
        private int waga;
        private double cena;
        public Herbata zawartosc;
        public Termos(Herbata aherbata)
        {
            zawartosc = aherbata;
        }

        public int getPojemnosc()
        {
            return Pojemnosc;
        }
        public void setPojemnosc(int aPojemnosc)
        {
            this.Pojemnosc = aPojemnosc;
        }
        public int getWaga()
        {
            return waga;
        }
        public void setWaga(int awaga)
        {
            this.waga = awaga;
        }
        public double getCena()
        {
            return cena;
        }
        public void setCena(double acena)
        {
            this.cena = acena;
        }

        public void polej()
        {
            Console.WriteLine("Leje...");
        }
        public string umyj()
        {
            return "MYJE MYJE";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Herbata herbata = new Herbata();
            herbata.setKrajPochodzenia("Kolumbia");
            Console.WriteLine(herbata.getKrajPochodzenia());
            herbata.Aromat = "Mocny";

            Termos t = new Termos(herbata);
        }
    }
}
