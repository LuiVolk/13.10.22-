// 12. Напишите программу, которая 
// 1. будет принимать на вход два числа
// 2.  выводить, является ли второе число кратным первому. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// Пример:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 % number2 == 0)
Console.WriteLine("кратно"); 


else 
Console.WriteLine($"не кратно, остаток от деления {number1 % number2}");
