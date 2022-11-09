// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите натуральное число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numB = Convert.ToInt32(Console.ReadLine());


if (numA > 0 && numB > 0)
{
int result = DigitDegree(numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} = {result}");
}

else
{
    Console.WriteLine("Введите натуральное число!");
}



int DigitDegree(int numberA, int numberB)
{
    int count = 1;
    int digit = 1;
    while (count <= numberB)
    {
        digit = digit * numberA;
        count++;
    }
    return digit;
}
