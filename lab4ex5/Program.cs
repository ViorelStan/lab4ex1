/*
 * Se citesct doua numere de la tastatura. Scrieti un program care va calcula cel mai mare divizor comun al numerelor
*/

Console.WriteLine("Insert first number");
int numberOne = int.Parse(Console.ReadLine());


Console.WriteLine("Insert second number");
int numberTwo = int.Parse(Console.ReadLine());


while(numberTwo != 0)
{
    int r = numberOne % numberTwo;
    numberOne = numberTwo;
    numberTwo = r;
}
Console.WriteLine(numberOne);