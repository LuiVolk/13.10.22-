﻿// Задача 9. Напишите программу, которая 
// 1/ выводит случайное число из отрезка [10, 99] 
// 2/ показывает наибольшую цифру числа.
//  Пример:
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрезка 10-99 -> {number}");

// int firstDigit = number / 10; // 78 / 10 = 7
// int secondDigit = number % 10; // 78 % 10 = 8

// // if(firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа равна {firstDigit}");
// // else Console.WriteLine($"наибольшая цифра числа равна {secondDigit}");

// int MaxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// // Console.WriteLine ($"Наибольшая цифра числа равна {MaxDigit}");

// Console.WriteLine($"Наибольшая цифра числа {number} равна");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);


int MaxDigit(int number)
{
    int firstDigit = number / 10; // 78 / 10 = 7
    int secondDigit = number % 10; // 78 % 10 = 8
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);

Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");
