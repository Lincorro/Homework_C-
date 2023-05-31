// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
// int Prompt (string message)
// {
//     System.Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int [] InputArray(int length)
// {
//     int [] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Prompt($"Input {i +1 } element");
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++ )
//     {
//         System.Console.WriteLine($"a[{i}] = {array[i]}");
//     }
// }
// int CountPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// int length = Prompt("Input quantity element >");
// int [] array;
// array = InputArray(length);
// PrintArray(array);
// System.Console.WriteLine($"quantity element mor 0 - {CountPositiveNumbers(array)}");
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);
if (ValidateLines(lineData1, lineData2))
{
    double [] coord = FindCoords(lineData1,lineData2);
    System.Console.WriteLine($"intersection point of equations y = {lineData1[COEFFICIENT]}* x +{lineData1[CONSTANT]} and {lineData2[COEFFICIENT]}* x +{lineData2[CONSTANT]}");
    System.Console.WriteLine($" have coordinate {coord[X_COORD]}, {coord[Y_COORD]}");

}
double Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"Input coefficient for {numberOfLine} line>");
    lineData[CONSTANT] = Prompt($"Input constant for {numberOfLine} line>");
    return lineData;
}
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData1[COEFFICIENT] -lineData2[COEFFICIENT]);
    coord[Y_COORD] = (lineData1[CONSTANT] * coord[X_COORD]) + lineData1[CONSTANT];
    return coord;
}
bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            System.Console.WriteLine(" line one by one");
            return false;
        }
        else
        {
            System.Console.WriteLine(" line paralel");
            return true;
        }
    }
    return true;
}