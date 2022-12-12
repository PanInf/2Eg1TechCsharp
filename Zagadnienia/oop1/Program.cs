using System;

namespace ConsoleApp5
{

    class Student
    {

    }

    class Profesor
    {

    }

    class Address
    {
        public string street;
        public string city;
        public string state;
        public string postalCode;
        public string country;
        private bool vatidate()
        {
            return true;
        }
        public string outputAsLabel()
        {
            return "Adres to: "
                + street + " "
                + city + " "
                + state;
        }
    }

    class Person
    {
        public string name;
        public string phoneNumber;
        public string emailAddress;
        public Address lives_at;

        public void purchaseParkingPass()
        {
            Console.WriteLine("Kupiono bilet");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Auto a1 = new Auto();
            a1.marka = "Opel";
            a1.model = "Astra";
            a1.jedz();
            Console.WriteLine(a1.sprzedaj());*/

            Person osoba1 = new Person();
            osoba1.name = "Bartosz";
            osoba1.phoneNumber = "08800";
            osoba1.emailAddress = "asdasd@asdads.pl";

            osoba1.lives_at = new Address();

            osoba1.lives_at.street = "Lipowa";
            osoba1.lives_at.city = "Poznan";
            osoba1.lives_at.state = "wlkp";

            osoba1.purchaseParkingPass();
            Console.Write(osoba1.lives_at.outputAsLabel());

            Console.ReadKey();
        }
    }
}
