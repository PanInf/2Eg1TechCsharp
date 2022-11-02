// Zad 1 - Medium - Oblicz sumę n początkowych liczb trzycyfrowych
// 100 + 101 + 102 + 103 ...

// 1
/*int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 100; i < 100 + n; i++)
{
    suma = suma + i;
}
Console.WriteLine(suma);*/

//2 
/*int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0; i < n; i++)
{
    suma = suma + 100 + i;
}
Console.WriteLine(suma);*/

//3 
/*
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0; i < n; i++)
{
    suma = suma + i;
}
Console.WriteLine(suma + n*100);
*/

//4
/*int n = int.Parse(Console.ReadLine());
Console.WriteLine((99+n)*(n+100)/2 - 99*100/2);*/


// Zad 2 - Light Hard - Napisz sumę k początkowych liczb fibonacciego
// 1 + 2 + 3 + 5 + 8 + 13 + 21 + ....
/*
int n = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
int temp;
int suma = 0;
for (int i = 0; i < n; i++)
{
    temp = a;
    a = b;
    b = temp + b;
    suma = suma + b;
}
Console.WriteLine(suma);*/



// Zad 3 - Light Hard - Sprawdenie czy liczba n jest doskonała, czyli równa sumie swoich dzielników
// bez niej samej

// 6 = 1 + 2 + 3 (JEST)
// 10 = 1 + 2 + 5 (NIE)
// 28 = 1 + 2 + 4 + 7 + 14 (JEST)
// 496 (JEST)
// 8128
/*
int x = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 1; i < x; i++)
{
    if (x % i == 0)
    {
        suma = suma + i;
    }
}
if (x == suma)
{
    Console.WriteLine("JEST DOSKONAŁA");
}
else
{
    Console.WriteLine("NIE JEST DOSKONAŁA");
}
*/

// Zad 4 - Medium - Znajdź sumę n początkowych wyazów ciągu:
// a) 3 + 6 + 12 + 24 + 48 ...
/*int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0; i < n; i++)
{
    suma += 3 * (int)Math.Pow(2, i);
}
Console.WriteLine(suma);*/
// b) 1 + 4 + 7 + 10 + 13 ...
/*int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0; i < n; i++)
{
    suma += 3 * i + 1;
}
Console.WriteLine(suma);*/
// c) 5 - 10 + 20 - 40 + 80 ...
/*int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0; i < n; i++)
{
    suma += 5 * (int)Math.Pow(-2, i);
}
Console.WriteLine(suma);*/
