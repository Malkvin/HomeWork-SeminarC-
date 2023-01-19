
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



 

int[] array = GetArray(6,0,100);
Console.Write("Начальный массив: ");
Print1DArray(array);
int[] bubble = BubbleSort(array);
Console.Write("Итоговый массив: ");
Print1DArray(bubble);


int[] GetArray(int size, int minValue,int maxValue)
{

    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);        
    }
         return res;
     
}

void Print1DArray(int[] arr)
{
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}


int[] BubbleSort(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

