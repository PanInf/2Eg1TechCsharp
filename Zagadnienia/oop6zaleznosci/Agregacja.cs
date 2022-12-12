namespace Agregacja
{
    class Silnik
    {
        private int pojemnosc;
        private int moc;

        public void start()
        {
            Console.WriteLine("Startuje... ");
        }
        public void stop()
        {
            Console.WriteLine("Kończę pracę... ");
        }
    }

    class Radio
    {
        private string model;
        private string typ;

        public void graj()
        {
            Console.WriteLine("Radio gra... ");
        }
    }

    class Auto
    {
        private string color;
        private int year;
        private Silnik silnik;
        private Radio radio;

        public void jedz()
        {
            Console.WriteLine("No to jadę... ");
        }
        public void napraw()
        {
            Console.WriteLine("Naprawiam się... ");
        }

        public void setSilnik(Silnik asilnik)
        {
            this.silnik = asilnik;
        }
        public void zamontujRadio(Radio aradio)
        {
            this.radio = aradio;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();
            Silnik s1 = new Silnik();
            a1.setSilnik(s1);
        }
    }
}
