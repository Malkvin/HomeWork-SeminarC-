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

// System.Console.WriteLine("Введи число");
// int x = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= x; i++)
// {
// System.Console.Write(Math.Pow(i, 3)+ " ");
// }


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int step = a;


// for (int i = 1; i < b; i++)
// {
// step = step * a;
// }

// Console.WriteLine($"{a} в степени {b} равно: " + step);

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// 

// Console.WriteLine("введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (a > 0)
// {
// int num = a % 10;
// a = a / 10;
// sum = sum + num;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int[] Array = GetArray(8);
Console.Write($"[{String.Join(";", Array)}]");

int[] GetArray(int size)
{

    int[] Array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(3, 10);
    }
     return Array;

}