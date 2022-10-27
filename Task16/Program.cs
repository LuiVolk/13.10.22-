// 16. Напишите программу, которая 
// 1. принимает на вход два числа 
// 2. проверяет, является ли одно число квадратом другого.
// Пример:
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result1 = number1 * number1;
int result2 = number2 * number2;

// if(result1 == number2) Console.WriteLine("да");
// else if (result2 == number1) Console.WriteLine("да");

// else Console.WriteLine("нет");

bool Sqwere(int num1, int num2, int result1, int result2)
{
    int res1 = number1 * number1;
    int res2 = number2 * number2;
    if (result1 == number2) return true;
    else if (result2 == number1) return true;
    return false;
}

bool result = Sqwere(number1, number2, result1, result2);
if (result)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}


