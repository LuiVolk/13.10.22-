// Задача 10: 
// Напишите программу, которая 
//  1. принимает на вход трёхзначное число и 
//  2. на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//  Пример:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int result = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа -> {result}");
}
else
{
    Console.WriteLine("Введите корректное число!");
}

int SecondDigit(int num)
{
    int dig1 = 0;
    int dig2 = 0;
    dig1 = num / 10;
    dig2 = dig1 % 10;
    return dig2;
}







