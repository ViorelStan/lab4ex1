/*
 * Cititi de la tastatura continutul unei matrici de intregi cu 2 dimensiuni avand lungimile m, n.
 * Lungimile celor doua dimensiuni ale matricii, m si n, vor fi citite de la tastatura.
 * - Scrieti o functie care va afisa continutul unei astfel de matrici si apelati-o.
 * - Scrieti o functie care va aduna doua matrici, apelati-o si afisati rezultatul.
*/

using System;
using System.Numerics;
using System.Runtime.Intrinsics;


var vector = ReadMatrix();
var vector2 = ReadMatrixTwo();

int[,] sumMatrix = SumMatrix2(vector2, vector);
Console.WriteLine(sumMatrix);

//ShowMatrix(vector);
//var vector2 = SumMatrix(vector);
//Console.WriteLine(vector2);
//var vector3 = SumMatrix2(vector);
//Console.WriteLine(vector3);
//SumMatrix2(vector);

int[,] ReadMatrix()
{
    Console.WriteLine("Insert n");
    var n = int.Parse(Console.ReadLine());

    Console.WriteLine("Insert m");
    var m = int.Parse(Console.ReadLine());

    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++)
    {

        for(int j = 0; j < m; j++)
        {
        Console.WriteLine("Give us the " + i + "th number for");
            result[i, j] = int.Parse(Console.ReadLine());
        }
    }

    return result;
}

int[,] ReadMatrixTwo()
{
    Console.WriteLine("Insert m");
    var m = int.Parse(Console.ReadLine());

    Console.WriteLine("Insert n");
    var n = int.Parse(Console.ReadLine());

    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            Console.WriteLine("Give us the " + i + "th number for");
            result[i, j] = int.Parse(Console.ReadLine());
        }
    }

    return result;
}

/*void ShowMatrix(int[,] matrix)
{ 
    foreach(var elem in matrix)
    {
        Console.WriteLine(elem);
    }    
}*/



/*int SumMatrix(int[,] matrix)
{
    int total = 0;
    foreach (var item in matrix)
        total += item;
    return total;
}*/



int[,] SumMatrix2(int[,] matrix, int[,] matrix2)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int[,] n = new int[rows, cols];
    int[,] m = new int[rows, cols];
    int[,] sum = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            sum[i, j] = n[i, j] + m[i, j];
    }
    Console.Write("\nThe Addition of two matrices is : \n");
    for (int i = 0; i < rows; i++)
    {
        Console.Write("\n");
        for (int j = 0; j < cols; j++)
            Console.Write("{0}\t", sum[i, j]);
    }
    return sum;
}
