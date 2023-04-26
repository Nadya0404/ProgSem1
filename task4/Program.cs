// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write ("Введите 1ое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите 2ое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите 3ье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1>number2)
{
    if (number1>number3)
    {
    Console.WriteLine ($"Наибольшее число {number1}");
    }
    else if (number1==number3)
        {
        Console.WriteLine ($"Первое и Третье числа наибольшие и равны  {number3}");
        }
        else 
        {
        Console.WriteLine ($"Наибольшее число {number3}");    
        }
}
else 
{
    if (number3>number2)
    {
    Console.WriteLine ($"Наибольшее число {number3}");
    }
    else if (number3==number1)
            {
            Console.WriteLine ($"Все числа одинаковые и равны  {number1}");
            }
            else if (number3<number2)
                {
                Console.WriteLine ($"Наибольшее число {number2}");   
                }
                else
                {
                Console.WriteLine ($"Третье и второе число наибольшие и равны  {number3}");
                }
         
        
}