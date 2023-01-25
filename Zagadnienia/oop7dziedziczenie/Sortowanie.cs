using System;
using System.Collections;
using System.Collections.Generic;

namespace Szorty
{
    class Sortowanie
    {
        protected List<int> L;

        /*public Sortowanie(List<int> lista)
        {
            this.lista = lista;
        }*/
        public void sortuj() { }
        public void wyswietl()
        {
            foreach (int i in this.L)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        public void setLista(List<int> lista)
        {
            this.L = lista;
        }

    }

    class Spryt : Sortowanie
    {
        /*public Spryt(List<int> lista)
        {
            this.lista = lista;
        }*/
        public void sortuj()
        {
            L.Sort();
        }
    }

    class Babelek : Sortowanie
    {
        public void sortuj()
        {
            for (int i = 0; i < L.Count - 1; i++)
            {
                for (int j = 0; j < L.Count - 1 - i; j++)
                {
                    if (L[j] > L[j + 1])
                    {
                        int tmp = L[j + 1];
                        L[j + 1] = L[j];
                        L[j] = tmp;
                    }
                }
            }
        }
    }

    

    /*class Wstawianie : Sortowanie
    {
        public List<int> sortuj(List<int> L)
        {
            for (int i = 1; i < L.Count; i++)
            {
                int x = L[i];
                int j = i - 1;
                while (j >= 0 && L[j] > x)
                {
                    L[j + 1] = L[j];
                    j = j - 1;
                }
                L[j + 1] = x;
            }
            return L;
        }
    }*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] D = new int[] { 4, 6, 7, 8, 2 };
            List<int> K = new List<int>() { 7, 3, 2, 5, 1, 5, 7, 2, 8 };
            ArrayList A = new ArrayList() { 7, 3, 2, 5, 1, 7, 5 };

            Sortowanie sor = new Sortowanie();
            sor.setLista(K);
            sor.wyswietl();
            sor.sortuj();
            sor.wyswietl();

            Spryt spr = new Spryt();
            spr.setLista(K);
            spr.wyswietl();
            spr.sortuj();
            spr.wyswietl();

            Babelek bab = new Babelek();
            bab.setLista(K);
            bab.wyswietl();
            bab.sortuj();
            bab.wyswietl();


            /*Babelek b = new Babelek();
            List<int> WYN = new List<int>();
            b.wyswietl(K);
            WYN = b.sortuj(K);
            b.wyswietl(WYN);*/

            /*Debilizm d = new Debilizm();
            List<int> WYN = new List<int>();
            d.wyswietl(K);
            WYN = d.sortuj(K);
            d.wyswietl(WYN);*/

            /*Wstawianie wst = new Wstawianie();
            wst.wyswietl(K);
            wst.sortuj(K);
            wst.wyswietl(K);*/

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
