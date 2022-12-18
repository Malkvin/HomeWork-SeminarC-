/*Console.WriteLine("Введи первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (a > b ) {
    Console.WriteLine ($"Число {a} наибольшее ");}
    else
    {
       Console.WriteLine ($"Число {b} наибольшее ");
    }
*/


/*Console.WriteLine("Введи первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int c = int.Parse(Console.ReadLine()!);

if (a > b) 
{
    if (a > c)
    {
     Console.WriteLine ($"Число {a} наибольшее ");   
    }
    else 
    {
       Console.WriteLine ($"Число {c} наибольшее "); 
    }   
    
}   
else if (b > c)
{
    Console.WriteLine ($"Число {b} наибольшее");
}
else 
{
   Console.WriteLine ($"Число {c} наибольшее"); 
}*/


/*Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine()!);

            if (a  % 2 == 1)
            {
                Console.WriteLine($"Число {a} является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine($"Число  {a} является: ЧЁТНЫМ" );
            }*/

Console.WriteLine("Введи число: ");
int num = int.Parse(Console.ReadLine()!);

int num1 = 1;

bool not = true;

Console.WriteLine($"Чётные числа от 1 до {num}");
while(num1 <= num){
    if(num1 % 2 != 1){
        Console.Write(num1 + ", ");
        not = false;
    }       
    num1++;
    }

 if(not){
    Console.WriteLine("Нет чётных чисел!");
 }            
             
               
             
