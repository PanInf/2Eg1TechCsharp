namespace Kompozycja
{
    class Liver
    {
        private int weight;
        private string color;
    }
    class Heart
    {
        private int weight;
        private string condition;
    }

    class Body
    {
        private Liver liver;
        private Heart heart;
        public Body(Liver aliver, Heart aheart)
        {
            this.liver = aliver;
            this.heart = aheart;
        }
        public void eat()
        {
            Console.WriteLine("Mniam mniam");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Liver l1 = new Liver();
            Heart h1 = new Heart();
            Body b1 = new Body(l1, h1);
        }
    }
}
