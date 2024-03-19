/*
 * Scrie un program care afiseaza numerele de la 1 la N.
 * Daca numarul este multiplu de 3, sa se afiseze Fizz, daca este multiplu de 5 sa se afiseze Buzz, daca e multiplu si de 3 si de 5 sa se afiseze FizzBuzz,
 * in restul cazurilor sa se afiseze numarul.
*/
using System;

int n = int.Parse(Console.ReadLine());
//ShowNumbers(n);
ShowNumbers2(n);
/*void ShowNumbers(int n)
{
    for (int i = 1; i <= n; i++)
    {
       if(i % 3 == 0 && i % 5 == 0)
        { 
            Console.WriteLine(i + "FizzBuzz");
        }
       else if(i % 5 == 0 )
        {
            Console.WriteLine(i + "Buzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine(i + "Fizz");
        }
        else
        { 
        Console.WriteLine(i);
        }
    }
    return;
}*/

void ShowNumbers2(int n)
{
    for (int i = 1; i <= n; i++)
    {
        //if (i % 3 == 0 && i % 5 == 0)
        if (i % 15 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
    return;
}