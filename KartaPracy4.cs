using System;
using System.Collections;

namespace KartaPracy4
{
    class Program
    {
        public static int kp1z1(int a, int b)
        {
            return a * a + b * b;
        }
        public static bool kp2z2(int a)
        {
            return a >= 100 && a < 1000 && a % 17 == 0 ? true : false;
        }
        public static bool kp2z6(int a, int p)
        {
            return (Math.Pow(a,p) - a) % p == 0 ? true : false;
        }
        public static void kp3z1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(i*i*i + 3 + " ");
            }
        }
        public static ArrayList kp3z3(int x)
        {
            ArrayList alist = new ArrayList();

            for (int i = 1; i < x+1; i++)
            {
                if (x % i == 0)
                {
                    alist.Add(i);
                }          
            }

            return alist;
        }


        static void Main(string[] args)
        {
            // Zad 1 kp1z1
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(kp1z1(a, b));
            */

            // Zad 1 kp2z2
            /*
            int a = int.Parse(Console.ReadLine());
            if (kp2z2(a))
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */

            //Zad 1 kp2z6
            /*
            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if (kp2z6(a, p))
            {
                Console.WriteLine("TAK, spełnia MTF");
            }
            else
            {
                Console.WriteLine("NIE, nie spełnia MTF");
            }*/

            //Zad 1 kp3z1
            /*
            int n = int.Parse(Console.ReadLine());
            kp3z1(n);
            */

            //Zad 1 kp3z3
            /*
            ArrayList dzielniki = new ArrayList();
            int n = int.Parse(Console.ReadLine());
            dzielniki = kp3z3(n);
            foreach (int a in dzielniki)
            {
                Console.Write(a + " ");
            }*/
            
            Console.ReadKey();
        }
    }
}
