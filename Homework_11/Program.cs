/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

// void OrderArrayLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }


// int UserInput(string text)
// {
//     System.Console.Write($"{text}");
    
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int [,] Create2DRandomArray (int rows, int coluns, int minValue, int maxValue )
// {
//     int[,] array = new int[rows, coluns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < coluns; j++)
//         {
//             array [i,j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2Darray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            System.Console.Write(array[i,j]+" "); 
//         }
//         System.Console.WriteLine();
//     }
// }



// int lines = UserInput("input number of lines: ");
// int coluns =  UserInput("input number of columns: ");
// int minValue = UserInput("input minimal value of matrix: ");
// int maxValue = UserInput("input maximal value of matrix: ");


// int[,] matrix = Create2DRandomArray(lines,coluns, minValue, maxValue);
// System.Console.WriteLine();
// Print2Darray(matrix);
// System.Console.WriteLine();
// OrderArrayLines(matrix);
// Print2Darray(matrix);

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

void SummRow(int[,] array)
{
    
    int[] summ = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ[i] +=array[i,j];
        }
       
    }
    int temp=summ[1];
    int tempPositiom=0;
    for (int n = 0; n < summ.GetLength(0); n++)
    {
        System.Console.WriteLine($"line №{n} {summ[n]} ");
        if(summ[n] < temp)
        {
            temp = summ[n];
            tempPositiom = n;
        }
    }
    System.Console.WriteLine($"minmal Rows -> {tempPositiom +1 }");
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
SummRow(matrix);*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

/*Console.Clear();
int UserInput(string text)
{
    System.Console.Write($"{text}");
    
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
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

int [,] SummMatrix(int[,] array1, int[,] array2)
{
    int rows1= array1.GetLength(0);
    int columns1 = array1.GetLength(1);
    int rows2 = array2.GetLength(0);
    int columns2 = array2.GetLength(1);
    int [,] result = new int[rows1, columns2];
    if ( rows1 != columns2)
    {
        System.Console.WriteLine("Input Fale");
        return result;
    }
    else
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    result [i,j] += array1 [i,k] * array2 [k,j];
                }
            }
        }
        return result;
    }
}

System.Console.WriteLine("Inout Information about first Martix");
int linesFirst = UserInput("input number of lines: ");
int colunsFirst =  UserInput("input number of columns: ");
int minValueFirst = UserInput("input minimal value of matrix: ");
int maxValueFirst = UserInput("input maximal value of matrix: ");

System.Console.WriteLine("Inout Information about second Martix");
int linesSecond = UserInput("input number of lines: ");
int colunsSecond =  UserInput("input number of columns: ");
int minValueSecond = UserInput("input minimal value of matrix: ");
int maxValueSecond = UserInput("input maximal value of matrix: ");

int[,] matrixFirst = Create2DRandomArray(linesFirst,colunsFirst, minValueFirst, maxValueFirst);
int[,] matrixSecond = Create2DRandomArray(linesSecond,colunsSecond, minValueSecond, maxValueSecond);
System.Console.WriteLine();
Print2Darray(matrixFirst);
System.Console.WriteLine();
Print2Darray(matrixSecond);
System.Console.WriteLine();
Print2Darray(SummMatrix(matrixFirst, matrixSecond));*/

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

/*Console.Clear();
int RandomNum(int [] array)//метод выбирающий случайное число из массива
{
    int temp;
    temp = new Random().Next(0, 91);
    int num = array [temp];
    return num;
}
int [] DelitNum(int [] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] == num ) array[i]=0;
    }
    return array;
}

int [, ,] Create3DRandomArray (int rows, int coluns, int page)
{
    int[, ,] array = new int[rows, coluns, page];
    int [] randomNum =new int[99];
    int  counter = 0;
    int empty = 0;

    for (int n = 10; n < 100; n++)//Цикл задающий массив  двухзнчных чисел
    {
        randomNum[counter] = n;
        counter++;
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coluns; j++)
        {
            for (int k = 0; k < page; k++)
            {
                int temp = RandomNum(randomNum);//получаем случайное число
                DelitNum(randomNum, temp);// убираем это число из списка
                while (temp == empty) 
                {
                    temp = RandomNum(randomNum);
                }
                
                array [i,j,k] = temp;
            }
        }
    }
    return array;
}

void Print3Darray(int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k <array.GetLength(2); k++)
           {
                System.Console.WriteLine($"{array[i,j,k]} ({i}, {j},{k})");
           } 
           
        }
        System.Console.WriteLine();
    }
}

int UserInput(string text)
{
    System.Console.Write($"{text}");
    
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int lines = UserInput("input number of lines: ");
int coluns =  UserInput("input number of columns: ");
int page = UserInput("input number  of page: ");


int [ , , ] MyArray = Create3DRandomArray(lines, coluns, page);
Print3Darray(MyArray);*/

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

/*void Print2Darray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           System.Console.Write(array[i,j]+"\t "); 
        }
        System.Console.WriteLine();
    }
}

int[,] Spiral(int[,] array)
{
    int i = 0;
    int j = 0;
    int count = 1;
    while( count < array.GetLength(0)*array.GetLength(1)+1 )
    {
    array[i, j] = count;
    count++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
    }

    return array;
}
int UserInput(string text)
{
    System.Console.Write($"{text}");
    
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int lines = UserInput("input number of lines: ");
int coluns =  UserInput("input number of columns: ");

int[,] matrix = new int[lines, coluns];
Spiral(matrix);
System.Console.WriteLine();
Print2Darray(matrix);


