﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


/*void SowNumbers(int N)
{
    if (N >=1)
    {
        System.Console.WriteLine(N);
        SowNumbers(N-1);
    }


}
System.Console.Write("Input Number: ");
int num = Convert.ToInt32(Console.ReadLine());
SowNumbers(num);*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*int SowNumbers(int max, int min)
{
    int result = min;
    if(max == min)
    return 1;
    else
    {
        min++;
        return SowNumbers(max,min) + min;
        
    }

    
}
System.Console.Write("Input max number: ");
int numMax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input min number: ");
int numMin = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SowNumbers(numMax, numMin));*/




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


/*int Ack (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return (Ack(m - 1, Ack(m, n - 1)));
    }
}

System.Console.Write("Input First number: ");
int numMax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input Second number: ");
int numMin = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Ack(numMax, numMin));