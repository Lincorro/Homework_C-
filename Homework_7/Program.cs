// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// int Prompt(string message)
// {
//     System.Console.WriteLine(message);
//     string readInput = Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }
// int Power(int powerBase, int exponent)
// {
//     int power = 1;
//     for (int i = 0; i < exponent; i++)
//     {
//         power *= powerBase;
//     }
//     return power;
// }
// bool ValidateExponent(int exponent)
// {
//     if (exponent < 0)
//     {
//         System.Console.WriteLine(" Your Number < 0 ");
//         return false;
//     }
//     return true;
// }  


// int powerBase = Prompt("input Base");
// int exponent = Prompt("input exponent");
// if (ValidateExponent(exponent))
// {
//     System.Console.WriteLine($"number {powerBase} exponent {exponent} = {Power(powerBase, exponent)}");
// }



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
// int Prompt (string message)
// {
//     System.Console.WriteLine(message);
//     string readInput = Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }

// int SumAllDigit(int number)
// {
//     int result = 0 ;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
    
//     }
//     return result;
// }
// int number = Prompt("input number");
// System.Console.WriteLine($"summ numbers {number} = {SumAllDigit(number)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]