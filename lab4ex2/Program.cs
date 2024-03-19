/*
 * Cititi de la tastatura continutul unei matrici intregi cu 3 dimensiuni avand lungimile n, m, k.
 * Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastatura
 * - Scrieti o functie care va calcula suma elementelor unei astfel de matrici, apelati-o si afisati-i rezultatul
 * - Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i rezultatul
*/

using System.Xml.Linq;

var vector = ReadMatrix();
var sumMatrix = SumMatrix(vector);
Console.WriteLine(sumMatrix);

var maxElement = MaxElement(vector);
Console.WriteLine(maxElement);

int[,,] ReadMatrix()
{
    Console.WriteLine("Insert n");
    var n = int.Parse(Console.ReadLine());

    Console.WriteLine("Insert m");
    var m = int.Parse(Console.ReadLine());

    Console.WriteLine("Insert k");
    var k = int.Parse(Console.ReadLine());

    int[,,] result = new int[n, m, k];

    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < m; j++)
        {
            for (int l = 0; l < k; l++)
            {
                Console.WriteLine("Give us the " + i + "th number for");
                result[i, j, l] = int.Parse(Console.ReadLine());
            }
        }
    }
    return result;
}


int SumMatrix(int[,,] matrix)
{
    int total = 0;
    foreach (var item in matrix)
        total += item;
    return total;
}

int MaxElement(int[,,] matrix)
{
    int max = matrix[0,0,0];

    foreach (int element in matrix)
    {
        if (element > max);
        {
            max = element;
        }
    }
    return max;
}