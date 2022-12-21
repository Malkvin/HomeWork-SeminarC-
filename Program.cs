/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков
Console.WriteLine("Введи трехзначное число: ");
int number= int.Parse(Console.ReadLine()!);
int result = (number/10)%10;
if(number < 1000 && number > 99) Console.WriteLine($"{number} -> {result}");
else Console.WriteLine ($"Введенное число не трехзначное");
*/

/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

Console.WriteLine("Введи трехзначное число: ");
int number= int.Parse(Console.ReadLine()!);
int result = number%10;
if(number < 1000 && number > 99) Console.WriteLine($"{number} -> {result}");
if(number < 100-999 || number > 10000-99999 ) Console.WriteLine($"Некоректно введено число");
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

Console.WriteLine("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 1)Console.WriteLine ($"Для числа {num} соотвествует день недели Понедельник");
if (num == 2)Console.WriteLine ($"Для числа {num} соотвествует день недели Вторник");
if (num == 3)Console.WriteLine ($"Для числа {num} соотвествует день недели Среда");
if (num == 4)Console.WriteLine ($"Для числа {num} соотвествует день недели Четверг");
if (num == 5)Console.WriteLine ($"Для числа {num} соотвествует день недели Пятница");
if (num == 6)Console.WriteLine ($"Для числа {num} соотвествует день недели Суббота(Выходной день)");
if (num == 7)Console.WriteLine ($"Для числа {num} соотвествует день недели Воскресенье(Выходной день)");
if (num>7 || num<1)Console.WriteLine($"Некоректоно введена, повторите попытку");