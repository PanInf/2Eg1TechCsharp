using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Zad 1
            /*
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i * i * i + 3);
            }
            */

            // Zad 2
            /*
            for (int i = 105; i < 1000; i = i + 15)
            {
                Console.WriteLine(i);
            }
            */

            // Zad 3
            /*
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            // Zad 4
            /*
            int suma = 0;
            for (int i = 10; i < 100; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);
            */

            // Zad 5
            /*
            Console.WriteLine("Podaj liczbę w którą gramy (n): ");
            int n = int.Parse(Console.ReadLine());
            int suma = n * (n + 1) / 2;
            int liczba;
            Console.WriteLine($"Ok. To proszę podaj {n-1} liczb, a ja zganę tą której nie podałeś: ");
            for (int i = 0; i < n - 1 ; i++)
            {
                liczba = int.Parse(Console.ReadLine());
                suma = suma - liczba;
            }
            Console.WriteLine($"Wybrałeś sobie {suma}");
            */

            // Zad 6
            /*
            Console.WriteLine("Ile chcesz liczb Fibonacciego? ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int temp;
            for (int i = 0; i < n-2; i++)
            {
                temp = b;
                b = a + b;
                a = temp;
            }
            Console.WriteLine($"{n}-a liczba Fibonacciego to {b}");
            */
            
            Console.ReadKey();
        }
    }
}
