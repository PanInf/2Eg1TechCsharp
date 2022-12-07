using System;


namespace Statyczne
{
    //Stwórz 2 metody statyczne..

    class Przychodnia
    {
        private string adres = "Poznań";
        private string[] lekarze;
        public static int WIDTH = 640;
        //metoda "normalna"
        public void przywitajPacjenta()
        {
            Console.WriteLine("Witaj choruszku!");
        }

        //metoda statyczna
        public static void pokazRegulamin()
        {
            Console.WriteLine("Prosze zapoznać się z regulaminem..");
        }
    }

    static class Szkola
    {
        private static int id = 10101;
        public static void wpuscDoSzkoly()
        {
            Console.WriteLine("Proszę wejść");
        }

        public static void pokazPlanLekcji()
        {
            wpuscDoSzkoly();
            Console.WriteLine("Oto plan lekcji " + id);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Przychodnia p = new Przychodnia();
            p.przywitajPacjenta();
            p.pokazRegulamin();  // błąd!!!*/
            /*Przychodnia.pokazRegulamin();
            Console.WriteLine(Przychodnia.WIDTH);*/
            Szkola.wpuscDoSzkoly();
            Szkola.pokazPlanLekcji();

            Console.ReadKey();
        }
    }
}
