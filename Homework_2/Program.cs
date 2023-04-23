//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Input first number ");
int first_Number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int second_Number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number ");
int third_Number = Convert.ToInt32(Console.ReadLine());
int max = first_Number;
if (second_Number > max)
{
    max = second_Number;
}
if (third_Number > max)
{
    max = third_Number;
}
System.Console.WriteLine(max);