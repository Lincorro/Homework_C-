// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N<0)Console.WriteLine("invalid input N");
int count = 0;
while (count <= N)
{
    Console.Write( count+" " );
    count++;
}
