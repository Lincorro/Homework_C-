// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

/*Console.Clear();
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(-10, 10);
    }
}
System.Console.WriteLine("input number of lines");
int lines = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input number of columns");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[lines, columns];
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

/*Console.Clear();

int [,] Create2DRandomArray (int rows, int coluns, int minValue, int maxValue )
{
    int[,] array = new int[rows, coluns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coluns; j++)
        {
            array [i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Print2Darray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           System.Console.Write(array[i,j]+" "); 
        }
        System.Console.WriteLine();
    }
}

void SerchPositionNumber(int[,] array, int positionRows, int positiomColuns)
{
if(positionRows> array.GetLength(0) || positiomColuns > array.GetLength(1)) System.Console.WriteLine($"{positionRows}, {positiomColuns} -> there is no such"); 
else
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if(i == positionRows && j==positiomColuns  ) System.Console.WriteLine($"Your position {positionRows}, {positiomColuns} Yournumber ->{array[i,j]}");     
        }
        
    }
}



}

System.Console.WriteLine("input number of lines");
int lines = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input number of columns");
int coluns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input minimal value of matrix");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input maximal value of matrix");
int maxValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input position rows");
int positionRows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input position Coluns");
int positiomColuns = Convert.ToInt32(Console.ReadLine());


int[,] matrix = Create2DRandomArray(lines,coluns, minValue, maxValue);
System.Console.WriteLine();
Print2Darray(matrix);
System.Console.WriteLine();
SerchPositionNumber(matrix, positionRows, positiomColuns);*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Clear();
int [,] Create2DRandomArray (int rows, int coluns, int minValue, int maxValue )
{
    int[,] array = new int[rows, coluns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coluns; j++)
        {
            array [i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Print2Darray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           System.Console.Write(array[i,j]+" "); 
        }
        System.Console.WriteLine();
    }
}

void SummColuns(int[,] array)
{
    
    int[] summ = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ[j] +=array[i,j];
        }
       
    }
    for (int i = 0; i < summ.GetLength(0); i++)
        {
           System.Console.Write(summ[i]+" "); 
        }
}

System.Console.WriteLine("input number of lines");
int lines = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input number of columns");
int coluns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input minimal value of matrix");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input maximal value of matrix");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,] matrix = Create2DRandomArray(lines,coluns, minValue, maxValue);
System.Console.WriteLine();
Print2Darray(matrix);
System.Console.WriteLine();
SummColuns(matrix);