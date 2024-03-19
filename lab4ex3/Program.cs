/*
 * Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n m, respectiv m,n.
 * Lungimile celor doua dimensiuni ale matricelor, m si n, vor fi citite de la tastatura.
 * - Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati matricea rezultata.
*/

var matrix1 = ReadMatrix1();
var matrix2 = ReadMatrix2();
var results = FalkScheme(matrix1, matrix2);
//Console.WriteLine(results);


int[,] ReadMatrix1()
{
    Console.WriteLine("Insert n");
    var n = int.Parse(Console.ReadLine());

    Console.WriteLine("Insert m");
    var m = int.Parse(Console.ReadLine());

    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < m; j++)
        {
            Console.WriteLine("Give us the " + i + "th number for");
            result[i, j] = int.Parse(Console.ReadLine());
        }
    }

    return result;
}
int[,] ReadMatrix2()
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

int[,] FalkScheme(int[,] Matrix1, int[,] Matrix2)
{

    int r1 = Matrix1.GetLength(0);
    int c1 = Matrix1.GetLength(1);

    int r2 = Matrix2.GetLength(0);
    int c2 = Matrix2.GetLength(1);

    if (c1 != r2)
        throw new ArgumentOutOfRangeException("Matrix2", "Matrixes dimensions don't fit.");

    int[,] result = new int[r1, c2];
    for (int r = 0; r < r1; ++r)
        for (int c = 0; c < c2; ++c)
        {
            int s = 0;
            for (int z = 0; z < c1; ++z)
                s += Matrix1[r, z] * Matrix2[z, c];
            result[r, c] = s;
        }
    return result;
}