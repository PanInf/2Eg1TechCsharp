using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    // poli statyczny

    /*class Komputer
    {
        public virtual void wlacz()
        {
            Console.WriteLine("Wlaczam komputer");
        }
    }

    class Laptop : Komputer
    {
        public override void wlacz()
        {
            base.wlacz();
            Console.WriteLine("Wlaczam lamptopa");
        }
    }*/

    // poli dynamiczny ver 1

    /*class CzlonekRodziny
    {
        public virtual void ye()
        {
            Console.WriteLine("Członek rodziny yeah");
        }
    }
    class Matka : CzlonekRodziny
    {
        public void matkuj()
        {
            Console.WriteLine("Matka matkuje");
        }
    }

    class Syn : CzlonekRodziny
    {
        public void synuj()
        {
            Console.WriteLine("Bartosz synuje");
        }
        public override void ye()
        {
            Console.WriteLine("Syn ye");
        }
    }*/

    /*abstract class Produkt
    {
        abstract public void montuj();
    }

    class Telefon : Produkt
    {
        public override void montuj()
        {
            Console.WriteLine("Motuje telefon");
        }
    }
    class Radio : Produkt
    {
        public override void montuj()
        {
            Console.WriteLine("Motuje radio");
        }
    }
    class Glosnik : Produkt
    {
        public override void montuj()
        {
            Console.WriteLine("Motuje glosnik");
        }

    }*/

    interface IProdukt
    {
        void montuj();
    }

    class Telefon : IProdukt
    {
        public void montuj()
        {
            Console.WriteLine("Motuje telefon");
        }
    }
    class Radio : IProdukt
    {
        public void montuj()
        {
            Console.WriteLine("Motuje radio");
        }
    }
    class Glosnik : IProdukt
    {
        public void montuj()
        {
            Console.WriteLine("Motuje glosnik");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Laptop lap1 = new Laptop();
            lap1.wlacz();*/

            // Chce członka rodziny
            /*CzlonekRodziny Bartosz = new Syn();
            Bartosz.ye();*/

            IProdukt prod1 = new Radio();
            prod1.montuj();

            string coChcesz = Console.ReadLine();
            IProdukt prod2;
            switch (coChcesz)
            {
                case "Telefon":
                        prod2 = new Telefon();
                        break;
                case "Radio":
                        prod2 = new Radio();
                        break;
                case "Glosnik":
                        prod2 = new Glosnik();
                        break;
                default:
                        prod2 = new Telefon();
                        break;
            }
            prod2.montuj();
            Console.ReadKey();
        }
    }
}
