// Задача 19

// Напишите программу, которая 
//  1. принимает на вход пятизначное число и 
//  2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int num31 = 0;
int num41 = 0;

if (num > 9999 && num < 100000)
{
    num1 = num / 10000;
    num2 = num % 10;
    num3 = num / 1000;
    num31 = num3 % 10;
    num4 = num % 100;
    num41 = num4 / 10;
    if (num1 == num2 && num31 == num41)
    {
        Console.Write("да");
    }

    else
    {
        Console.Write("нет");
    }
}
else
{
    Console.Write("Введите корректное число");
}




