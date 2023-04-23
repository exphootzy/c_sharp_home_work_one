// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число 
// любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет.
// Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

Console.WriteLine("Введите любое число");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;
int remainder = inputNumber;
int divider = 10;
int answer = 0;

if (inputNumber < 0)
{
    inputNumber = inputNumber * -1;
    remainder = remainder * -1;
}

while (remainder > 0)
{
    remainder = remainder / divider;
    count++;
}

if (count == 1)
{
    Console.WriteLine("Нет второго числа");
    return;
}

if (count == 2)
{
    answer = inputNumber % 10;
    Console.WriteLine($"Второе число слева: {answer}");
    return;
}

count = count - 3;

while (count > 0)
{
    divider = divider * 10;
    count--;
}

answer = inputNumber / divider;

answer = answer % 10;

Console.WriteLine($"Второе число слева: {answer}");