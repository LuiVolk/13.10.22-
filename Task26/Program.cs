// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int CountDigit(int number)
{
    // int count = default;
    // while (number>=1) 
    //{     
        //number /= 10;
        //count++;
    //}
    //return count;

number = Math.Abs(number); // для отрицательных чисел
    int i = default;
    for (i = 0; number>=1; i++) 
    {
        //number = number / 10;
        number /= 10;
     }
    return i > 0 ? i: 1;
}

int countDigit = CountDigit(num);
Console.WriteLine($"Количество цифр в числе {num} => {countDigit}");


//Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumDigit(int numDigit)
// {
// numDigit = Math.Abs(numDigit);
// int count = 0;
// while (numDigit > 0)
// {
// numDigit = numDigit / 10;
// count++;
// }
// return count > 0 ? count : 1;
// }
// int sumDigit = SumDigit(num);
// Console.WriteLine($"Количество цифр в числе = {sumDigit}");