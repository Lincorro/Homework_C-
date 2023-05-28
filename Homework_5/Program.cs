// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1
int secondNumber(int num)
{
    if (num / 100 == 0)
        return num % 10;
    else
        num = num / 10;
       return num = num % 10;
}
System.Console.Write("Input  number typ (adc): ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"second number is -> {secondNumber(number)}");


// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int secondNumber(int num)
{
    if (num / 100 == 0)
    {
        System.Console.WriteLine("no third digit");
        return num =-1;
    }
    else
       return num = num % 10;
}
System.Console.Write("Input  number typ (adc): ");
int number = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"second number is -> {secondNumber(number)}");

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// // 6 -> да
// // 7 -> да
// // 1 -> нет

bool calendar(int num)
{
    if (num == 7 || num == 6)
    return true;
    else return false;
}
System.Console.Write("Input  number day of week : ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"today vacation? -> {calendar(number)}");
