// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minWalue, int maxWalue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++ )
//     {
//         newArray[i] =  new Random().Next(minWalue, maxWalue+1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void searchForEvenNumbers(int[] array)
// {
//     int size = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] %2 == 0) size++;
//     }
//     System.Console.WriteLine($"Your quantity even number ->{size}");
// }

// System.Console.WriteLine("input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// int minWalue = 100;
// int maxWalue = 999;

// int[] myArray = CreateRandomArray(size, minWalue, maxWalue);
// System.Console.WriteLine();
// PrintArray(myArray);
// System.Console.WriteLine();
// searchForEvenNumbers(myArray);

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minWalue, int maxWalue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++ )
//     {
//         newArray[i] =  new Random().Next(minWalue, maxWalue+1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void SumOdd(int[] array)
// {
//     int size = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i %2 == 1) size += array[i];
//     }
//     System.Console.WriteLine($"Summ odd -> {size}");
// }

// System.Console.WriteLine("input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input minmal Value of element");
// int minWalue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input maximum  Value of element");
// int maxWalue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minWalue, maxWalue);
// System.Console.WriteLine();
// PrintArray(myArray);
// System.Console.WriteLine();
// SumOdd(myArray);


// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] CreateRandomArray(int size, int minWalue, int maxWalue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++ )
    {
        newArray[i] =  new Random().Next(minWalue, maxWalue+1);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

void MinMax(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array [i] > max) max = array [i];
        else if(array [i] < min) min = array [i];      
    }
    System.Console.WriteLine($"max number = {max}, min number = {min} difference -> {max - min}");
}

System.Console.WriteLine("input array size");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input minmal Value of element");
int minWalue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input maximum  Value of element");
int maxWalue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minWalue, maxWalue);
System.Console.WriteLine();
PrintArray(myArray);
System.Console.WriteLine();
MinMax(myArray);

