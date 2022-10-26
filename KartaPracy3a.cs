// Zad 1
// int n = int.Parse(Console.ReadLine());
// for (int i = 0; i < n; i++)
// {
//     Console.Write("*-|");
// }

// Zad 2 - PRE
// Tabliczke mnozenia
// for (int i=1; i < 11; i++)
// {
//     for (int j=1 ; j < 11; j++)
//     {
//         Console.Write(i*j + "\t");
//     }
//     Console.WriteLine();
// }

// *
// **
// ***
// ****
// *****

// *****
// ****
// ***
// **
// *

//     *
//    **
//   ***
//  ****
// *****

// *****
//  ****
//   ***
//    **
//     *

/*
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        Console.Write(" ");
    }
    for (int k = n - i - 1; k < n; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int k = i; k < n; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
*/
/*
int n = int.Parse(Console.ReadLine());

for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/

/*

*****
*****
*****
*****
*****

punkty (i, j)

(1, 1) (1, 2) (1, 3) (1, 4) (1, 5)
(2, 1) (2, 2) (2, 3) (2, 4) (2, 5)
(3, 1) (3, 2) (3, 3) (3, 4) (3, 5)
(4, 1) (4, 2) (4, 3) (4, 4) (4, 5)
(5, 1) (5, 2) (5, 3) (5, 4) (5, 5)
* 
**
***
****
*****


*/

/*
(1)
// *
// **
// ***
// ****
// *****

(2)
// *****
// ****
// ***
// **
// *

(3)
//     *
//    **
//   ***
//  ****
// *****

(4)
// *****
//  ****
//   ***
//    **
//     *

*/

/*
// 1
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (i >= j) Console.Write("*");
        else        Console.Write(" ");    
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

// 2

for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (n - i + 1 >= j) Console.Write("*");
        else Console.Write(" ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

// 3

for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (n - i < j) Console.Write("*");
        else Console.Write(" ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

// 4
for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (j >= i) Console.Write("*");
        else Console.Write(" ");
    }
    Console.WriteLine();
}*/

// Zad 4
// n -> n/2 + 2
// 5 -> 4  (1,3) (2,2) (3,1)
// 7 -> 5  (1,4) (3,2) (2,3) (4,1)
// 9 -> 6
// 11-> 7
// 31-> 

// prawy dól
// 5 -> 8    2  6
// 7 -> 11   3  8
// 9 -> 14   4  10
// n + n/2 + 1  => 3 * n/2 + 1
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{

    for (int j = 1; j < n + 1; j++)
    {
        
        if (i + j == n/2 + 2 || i + j == 14) Console.Write("*");
        else Console.Write("#");
    }
    Console.WriteLine();


    // Zad 5

    /*int n = int.Parse(Console.ReadLine());
    for (int i = 1; i < n + 1; i++)
    {
        for (int j = 1; j < n + 1; j++)
        {
            if (j == n / 2 + 1) Console.Write("*");
            else if (i == n / 2 + 1) Console.Write("-");
            else Console.Write(" ");
        }
        Console.WriteLine();
    */

    // Zad 6
    /*
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i < n + 1; i++)
    {
        for (int j = 1; j < n + 1; j++)
        {
            if (j == n - i + 1) Console.Write("?");
            else if (i == j) Console.Write("*");
            else Console.Write(" ");
        }
        Console.WriteLine();*/


    /*for (int j = 1; j < n + 1; j++)
    {
        // (1,5) (2,4) (3,3) (4,2) (5,1)
        // (1, 4) (2, 3) (3, 2) (4, 1) (5, 0)
        // i == n
        // i + 1 == n - 1
        // i + j == n
        // i == n - j

        // i + j == n + 1

        // i == n - j + 1
        // gdy j == 1 to i == n

        if (j <= n - i + 1) Console.Write("*");
        else        Console.Write("#");
    }
    Console.WriteLine();*/
}


// Zad 7
/*
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (i == 1 || j == 1 || i == n || j == n || (i == n/2 + 1 && j == n/2 + 1)) Console.Write("*");
        else Console.Write(" ");
    }
    Console.WriteLine();
}*/
