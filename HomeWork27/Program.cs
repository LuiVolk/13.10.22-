// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumResult(number);
Console.WriteLine($"Количество цифр в числе {number} -> {result}");


int SumResult(int num)
{
    num = Math.Abs(num);
    int sum = default;
    int digitNum = default;

    while (num > 0)
    {
        digitNum = num % 10;

        num = num / 10;

        sum = sum + digitNum;

    }
    return sum;
}
