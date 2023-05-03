// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// bool checkPolinom(int userNumber)
// {
  
//    if (userNumber/10000 == userNumber%10 && userNumber%10000/1000 == userNumber%100/10 ) return true;
//    else return false;
// }

// System.Console.Write("Input  number typ (12345): ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"yur number {number} is polynomial? -> {checkPolinom(number)}");



// Задача 21

// Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double findDistant(double xa, double ya, double za, double xb, double yb, double zb)
// {

//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)+ Math.Pow(zb - za, 2)),2);
// }
// System.Console.WriteLine("Input coordinate x to A:");
// double xa = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input coordinate y to A:");
// double ya = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input coordinate z to A:");
// double za = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input coordinate x to B:");
// double xb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input coordinate y to B:");
// double yb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input coordinate z to B:");
// double zb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"distans betwin point a with coordinate ({xa}, {ya}, {za}) and point with coordinate ({xb}, {yb}, {zb}) -> {findDistant(xa, ya, za, xb, yb, zb)}");



// Задача 23

// Напишите программу, которая принимает на вход число (N) 
//  и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
System.Console.Write("Input  number typ (12345): ");
int number = Convert.ToInt32(Console.ReadLine());
void cube ( int num)
{
    int i = 1;
    while (i <= num)
    {
        System.Console.WriteLine($"{i} -> {i*i*i}");
        i++;
    }
}
cube(number);
