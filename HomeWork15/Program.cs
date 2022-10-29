// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)  Console.WriteLine("да");
else if ( number > 0 && number < 6) Console.WriteLine("нет");
else Console.WriteLine("Введено не коректное число!");







