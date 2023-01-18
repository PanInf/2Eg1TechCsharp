using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    class Sortowanie
    {
        private List<int> lista;

        public List<int> sortuj(List<int> L)
        {
            return lista;
        }
        public void wyswietl(List<int> L)
        {
            foreach (int i in L)
            { 
                Console.Write(i + " "); 
            }
            Console.WriteLine("\n");
        }
    }

    class Babelek : Sortowanie
    {
        public List<int> sortuj(List<int> L)
        {
            for (int i = 0; i < L.Count - 1; i++)
            {
                for (int j = 0; j < L.Count - 1 - i; j++)
                {
                    if (L[j] > L[j+1])
                    {
                        int tmp = L[j + 1];
                        L[j + 1] = L[j];
                        L[j] = tmp;
                    }
                }
            }
            return L;
        }
    }

    class Debilizm : Sortowanie
    {
        public List<int> sortuj(List<int> L)
        {
            L.Sort();
            L.Reverse();
            return L;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] D = new int[] {4, 6, 7, 8, 2};
            List<int> K = new List<int>() { 7, 3, 2, 5, 1, 5, 7, 2 };
            ArrayList A = new ArrayList() { 7, 3, 2, 5, 1 };

            /*Babelek b = new Babelek();
            List<int> WYN = new List<int>();
            b.wyswietl(K);
            WYN = b.sortuj(K);
            b.wyswietl(WYN);*/

            Debilizm d = new Debilizm();
            List<int> WYN = new List<int>();
            d.wyswietl(K);
            WYN = d.sortuj(K);
            d.wyswietl(WYN);

            /*for (int i = 0; i < K.Count; i++)
            {
                Console.Write(K[i] + " ");
            }*/

            /*foreach (int i in K)
            {
                Console.Write(i + " ");
            }*/
            Console.ReadKey();
        }
    }
}
