﻿// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите любое число");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int index = 0;
int arrayMin = 1;

Console.Write("Положительные числа: ");

while (arrayMin <= inputNumber)
{
    if (arrayMin % 2 == 0)
    {
        if (index == 0)
        {
            Console.Write(arrayMin);
        }
        else 
        {
            Console.Write($", {arrayMin}");
        }
        
        arrayMin = arrayMin + 1;
        index++;
    }    
    else 
    {
        arrayMin  = arrayMin + 1;
    }       
}


