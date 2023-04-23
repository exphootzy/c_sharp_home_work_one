// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int num_one = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num_two = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int num_three = Convert.ToInt32(Console.ReadLine());

int num_max = num_one;

if (num_two > num_max)
{
    num_max = num_two;
}
 if (num_three > num_max)
 {
    num_max = num_three;
 }
Console.Write($"Наибольшее число их трех: {num_max}");




