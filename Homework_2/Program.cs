//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Input first number ");
string numbers = Console.ReadLine();
int size = numbers.Length;
int index = 0;
int[] temp = new int[4];
int max = 0;
int scor = 0;
int temp2 = 0;
for (index = 0; index < size; index++)
{
    while(numbers[index] != ',')
    {
        temp[scor] = numbers[index];
        scor++;
        index++;
    }
     scor = 0;
     index++;
     temp2 = Convert.ToInt32(temp[] arg);
     if ( temp2 > max)
     {
         max = temp2;
     }
} 
 System.Console.WriteLine(max);

