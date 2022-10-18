// Задача 6: 
//Напишите программу, которая 
//1. на вход принимает число 
//2. выдаёт, является ли число чётным (делится ли оно на два без остатка).
//Пример:
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите, пожалуйста, число: ");
int number = Convert.ToInt32(Console.ReadLine());

int lastDigit = number % 2;

if (lastDigit == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}




