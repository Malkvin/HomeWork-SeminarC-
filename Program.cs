//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine()!;
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }

// //Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// System.Console.Write("Введите коррдинату x точки А: ");
// int x1 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.Write("Введите коррдинату y точки А: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координату z точки A: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите коордианту x точки B: ");
// int x2 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.Write("Введите коордианту y точки B: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите коррдинату x точки А: ");
// int z2 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.Write("Введите коордианту z точки B: ");

// double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2)),2); 
// System.Console.WriteLine($"Расстояние между тремя точками: {result}");

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введи число");
int x = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= x; i++)
{
System.Console.Write(Math.Pow(i, 3)+ " ");
}