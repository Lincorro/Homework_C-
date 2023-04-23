// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Input number ");
int first_Number = Convert.ToInt32(Console.ReadLine());
int N = first_Number % 2 ;
if (N == 0 )
{  
    System.Console.WriteLine($"{first_Number}  is even");
}
else 
System.Console.WriteLine($"{first_Number}  NOT even, Try agan");