// 14. Напишите программу, которая 
// 1. принимает на вход число
// 2.  проверяет, кратно ли оно одновременно 7 и 23.
// Пример:
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if(Aliquot(number))
Console.WriteLine("да"); 

else 
Console.WriteLine("нет");

bool Aliquot(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}


