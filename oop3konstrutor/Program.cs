using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Car
    {
        public string name;
        public int year;

        public Car()
        {
            Console.WriteLine("HEY, I AM CONSTRUCTOR");
        }
        public void showCar()
        {
            Console.WriteLine($"Auto: {name} z roku {year}");
        }
    }

    class Car2
    {
        public string name;
        public int year;
        private string hasz;

        public Car2()
        {
            Console.WriteLine("SAM SE PORADZE");
            name = "Audi";
            year = 2020;
        }
        public void showCar()
        {
            Console.WriteLine($"Auto: {name} z roku {year}");
        }
    }

    class Car3
    {
        public string name;
        public int year;

        public Car3(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
        public void showCar()
        {
            Console.WriteLine($"Auto: {name} z roku {year}");
        }
    }

    class Car4
    {
        public string name;
        public int year;

        public Car4()
        {

        }
        public Car4(string name, int year)
        {
            
            this.name = name;
            this.year = year;
        }

        
        public void showCar()
        {
            Console.WriteLine($"Auto: {name} z roku {year}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Car c1 = new Car();
            c1.name = "BMW";
            c1.year = 2015;
            c1.showCar();*/

            /*Car2 c2 = new Car2();
            c2.name = "Mercedes";
            c2.showCar();*/

            /*Car3 c3 = new Car3("Jaguar", 1995);
            c3.showCar();*/

            Car4 c4 = new Car4();
            c4.name = "Ford";
            c4.year = 2001;
            c4.showCar();

            Car4 c5 = new Car4("Opel", 2011);
            c5.showCar();
            Console.ReadKey();
        }
    }
}
