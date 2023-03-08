using System;

namespace TestSprawdzian
{
    /*
     *  Napisz program pozwalający przetwarzać dane komputerów. Uwzględnij komputery stacjonarne oraz laptopy.
        Założenia:
        - cechy wspólne każdego komputera to marka i model
        - cecha charakterystyczna komputera PC to rodzaj obudowy
        np slim
        - cechy charakterystyczne laptopa to długość przekątnej i kolor obudowy
        - pełna hermetyzacja

        Opisane wyżej komputery mają być częścią serwisu komputerowego, gdzie oprócz nich są jeszcze: 
        - opiekun (opiekun klienta)
        - klient
        - serwisant (osoby dziedziczą ze wspólnej klasy)
        - zlecenie (zlecenie naprawy danego komputera przez opiekuna)
        - naprawa (wykonanie naprawy przez serwisanta)

        Zaproponuj układ klas wraz z odpowiednimi relacjami. Konieczny jest rysunek. (może być odręczny na kartce)

        W celach testowych ma być możliwe wprowadzenie danych 
        komputera z klawiatury, zapamiętanie ich w zmiennych członkowskich i wyświetlenie na ekranie.
     * 
     * 
     * KOMENTARZ:
     * - na sprawdzianie można używać róznych sposobów hermetyzacji i używania pól / metod lub właściwości - rozwiązanie pokazuje możliwe wersje
     */

    class Komputer
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public virtual void wyswietl()
        {
            Console.WriteLine("Marka: " + Marka + " Model: " + Model );
        }
    }

    class PC : Komputer
    {
        public string RodzajObudowy { get; set; }
        public override void wyswietl()
        {
            base.wyswietl();
            Console.WriteLine("RodzajObudowy: " + RodzajObudowy);
        }
    }

    class Laptop : Komputer
    {
        public double Przekatna { get; set; }
        private string kolor;
        public string getKolor() { return kolor; }
        public void setKolor(string kolor) { this.kolor = kolor; }
        public override void wyswietl()
        {
            base.wyswietl();
            Console.WriteLine("Przekatna: " + Przekatna + " Kolor: " + getKolor());
        }
    }

    class Osoba
    {
        string imie;
        public string Imie { get => imie; set => imie = value; }
    }

    class Opiekun   : Osoba { }
    class Klient    : Osoba { }
    class Serwisant : Osoba { }

    class Zlecenie
    {
        private Komputer komputer;
        private Klient klient;
        private Opiekun opiekun;
        public Zlecenie(Komputer komputer, Klient klient, Opiekun opiekun)
        {
            this.komputer = komputer;
            this.klient = klient;
            this.opiekun = opiekun;
        }

        public Komputer getKomputer() { return komputer; }
        private void setKomputer(Komputer komputer) { this.komputer = komputer; }
        public Klient getKlient() { return klient; }
        public Opiekun getOpiekun() { return opiekun; }
    }

    class Naprawa
    {
        public Zlecenie zlecenie { get; private set; }
        public Serwisant serwisant { get; set; }
        public Naprawa(Zlecenie zlecenie)
        {
            this.zlecenie = zlecenie;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // Proste banalne
            /*Laptop lap = new Laptop();
            lap.Marka = Console.ReadLine();
            lap.Model = Console.ReadLine();
            lap.Przekatna = double.Parse(Console.ReadLine());
            lap.setKolor(Console.ReadLine());

            Console.WriteLine(lap.Marka + " " + lap.Model + " " + lap.Przekatna + " " + lap.getKolor());
            Console.ReadKey();*/

            // Trudne i kreatywne

            Console.WriteLine("Co masz do naprawy? 1 - komp; 2 - lap");
            int wybor = int.Parse(Console.ReadLine());
            switch(wybor)
            {
                case 1:
                    {
                        // tu tworzymy obiekt
                        PC pc = new PC();
                        pc.Marka = Console.ReadLine();
                        pc.Model = Console.ReadLine();
                        pc.RodzajObudowy = Console.ReadLine();

                        // tu wyswietlamy obiekt
                        pc.wyswietl();
                        break;
                    }
                case 2:
                    {
                        // tu tworzymy obiekt
                        Laptop lap = new Laptop();
                        lap.Marka = Console.ReadLine();
                        lap.Model = Console.ReadLine();
                        lap.Przekatna = double.Parse(Console.ReadLine());
                        lap.setKolor(Console.ReadLine());

                        // tu wyswietlamy obiekt
                        lap.wyswietl();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Miałeś podać 1 lub 2 lolu. Bye bye");
                        break;
                    }
            }

        }
    }
}
