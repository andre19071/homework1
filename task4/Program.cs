// Напишите программу, которая принимает на вход три числа и
//выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число с");
int с = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < с) max = с;
Console.Write("Максимальное число ");
Console.WriteLine(max);

