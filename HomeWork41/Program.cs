// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Write("Задайте количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] NumberM(int mx)
{
    int[] numbers = new int[mx];
    for (int i = 0; i < mx; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}

int PositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] arr = NumberM(m);
PrintArray(arr);
Console.Write($"-> {PositiveNum(arr)}");
