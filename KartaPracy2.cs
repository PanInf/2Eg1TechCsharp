using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zad 1
            /*
            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */

            // Zad 2
            /*
            int a = int.Parse(Console.ReadLine());
            if (a >= 100 && a < 1000 && a % 17 == 0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */
            
            // Zad 3
            /*
            Console.WriteLine("Ile masz lat?");
            int wiek = int.Parse(Console.ReadLine());
            if (wiek >= 18)
            {
                Console.WriteLine("TAK, jesteś pełnoletni");
            }
            else
            {
                Console.WriteLine("NIE, nie jesteś pełnoletni");
            }
            */
            
            // Zad 4
            /*
            const int LIMIT = 20;
            int waga = int.Parse(Console.ReadLine());
            if (LIMIT >= waga)
            {
                Console.WriteLine("TAK, możesz jechac");
            }
            else
            {
                Console.WriteLine("NIE, lepiej nie jedz");
            }
            */

            // Zad 5
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a < c) && (b > c) || (b < c) && (a > c))
            {
                Console.WriteLine("TAK, mieści się");
            }
            else
            {
                Console.WriteLine("NIE, nie mieści się");
            }
            */

            // Zad 6
            /*
            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            if ((Math.Pow(a, p) - a) % p == 0)
            {
                Console.WriteLine("TAK, spełnają MTF");
            }
            else
            {
                Console.WriteLine("NIE, nie spełniają MTF");
            }
            */

            // Zad 7
            /*
            int p = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            if ((p + 3*s) >= k)
            {
                Console.WriteLine("TAK, zaba da rade");
            }
            else
            {
                Console.WriteLine("NIE, nie da rady");
            }
            Console.ReadKey();
        }
    }
}
