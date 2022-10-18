//Напишите программу, 
//1. на вход принимает два числа 
//2. проверяет, является ли первое число квадратом второго.
//Пример:
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Введите, пожалуйста, два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else 
{
    Console.WriteLine("Первое число, не является квадратом второго");
}


