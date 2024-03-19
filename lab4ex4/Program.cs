/*
 * Scrieti o functie care pentru un numar "n" va primit ca parametru, va afisa urmatoarea piramida a numerelor:
 * 1
 * 2 2
 * 3 3 3
 * 4 4 4 4
 * .........
 * n n n n n n
*/

var n = int.Parse(Console.ReadLine());
Piramida(n);

void Piramida (int n)
{
    var suma = "";
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            suma = suma + " " + i;
        }
        Console.WriteLine(suma);
        suma = "";
    }
   return;
}
