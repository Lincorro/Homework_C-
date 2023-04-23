// Task_1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньше

Console.Clear();
Console.Write("Input first number ");
int first_Number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int second_Number = Convert.ToInt32(Console.ReadLine());
if (first_Number > second_Number)
{
     Console.WriteLine($"Max number = {first_Number}");
}

else
{
    Console.WriteLine($"Max number = {second_Number}");
}
