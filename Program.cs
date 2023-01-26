
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите длину массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// RandomNumbers(numbers);
// Console.WriteLine("В этом массиве: ");
// PrintArray(numbers);

// void RandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < size; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }


// int count = 0;

// for (int x = 0; x < numbers.Length; x++)
// {
// if (numbers[x] % 2 == 0)
// count++;
// }
// Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 1; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];

//     Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int N = 10;
// int[] array = new int[N];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 10);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();

// int j = array.Length - 1;
// for (int i = 0; i < (array.Length + 1) / 2; i++)
// {
//     Console.Write(array[i] * array[j] + " ");
//     j--;
// }

// ЗаЗадача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
// Для строки можно использовать данный метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)(пользователь вводит в консоли числа через пробел и они формируют строку)

// Console.Write("Введите числа через пробел: ");
// int[] array = Console.ReadLine()!.Split(' ').Select(x => int.Parse(x)).ToArray();

// int Numbers(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }
// Console.WriteLine(Numbers(array));

// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).



 

// int[] array = GetArray(6,0,100);
// Console.Write("Начальный массив: ");
// Print1DArray(array);
// int[] bubble = BubbleSort(array);
// Console.Write("Итоговый массив: ");
// Print1DArray(bubble);


// int[] GetArray(int size, int minValue,int maxValue)
// {

//     int[] res = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue+1);        
//     }
//          return res;
     
// }

// void Print1DArray(int[] arr)
// {
//     Console.WriteLine($"[{string.Join(", ", arr)}]");
// }


// int[] BubbleSort(int[] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = i+1; j < array.Length; j++)
//         {
//             if (array[i] > array[j])
//             {
//                 temp = array[i];
//                 array[i] = array[j];
//                 array[j] = temp;
//             }
//         }
//     }
//     return array;
// }



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// int m = 3;
// int n = 4;
// double[,] array = new double [m, n];

// GetArray(array);
// PrintArray(array);


// //-------metods--------

// void GetArray(double[,] array)                                          
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().NextDouble();
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// void GetArray(int[,] array)
// {
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             array[m, n] = new Random().Next(1, 20);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             Console.Write($"{array[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int m = 5;
// int n = 5;
// int[,] array = new int[m, n];

// GetArray(array);
// PrintArray(array);

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// string Position(int[,] array)
// {
//     string result = string.Empty;
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             if (num == array[m, n]) result += $"({m}, {n})";
//         }
//     }
//     if (result == string.Empty) result = "Такого элемента нет";
//     return result;
// }
// Console.WriteLine(Position(array));


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int m = 5;
// int n = 5;
// int[,] array = new int[m, n];

// //--------metods-------

// void GetArray(int[,] array)
// {
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             array[m, n] = new Random().Next(1, 20);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             Console.Write($"{array[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// string ArithmeticMean(int[,] array)
// {
//     string result = string.Empty;
//     for (int n = 0; n < array.GetLength(1); n++)
//     {
//         int sum = 0;
//         int count = 0;
//         double mean = 0;
//         for (int m = 0; m < array.GetLength(0); m++)
//         {
//             sum += array[m, n];
//             count++;
//         }
//         mean = sum / count;
//         result += mean.ToString() + " ";
//     }
//     return result;
// }
 
//  GetArray(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine(ArithmeticMean(array));

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] matrix = new int[5, 5];
// GetArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Ordering(matrix);
// PrintArray(matrix);

// void GetArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void Ordering(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             for (int k = 0; k < matr.GetLength(1) - n - 1; k++)
//             {
//                 if (matr[m, k] < matr[m, k + 1])
//                 {
//                     int t = matr[m, k];
//                     matr[m, k] = matr[m, k + 1];
//                     matr[m, k + 1] = t;
//                 }
//             }
//         }
//     }
// }


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] table = new int[4, 4];
// FillArrayRandom(table);
// PrintArray(table);
// Console.WriteLine();
// NumberRowMinSumElements(table);


// void NumberRowMinSumElements(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < table.GetLength(1); i++)
//     {
//         minRow += table[0, i];
//     }
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка с наименьшей суммой элементов");
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10+1);
//         }
//     }
// }

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

GetArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

GetArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void GetArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}