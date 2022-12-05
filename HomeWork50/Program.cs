// Задача 50. Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// 2. или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет



Console.Write("Введите номер индекса строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер индекса столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] CreateArrayRnd(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void CheckElement(int[,] array, int userRow, int userColumn)
{
    if (userRow < array.GetLength(0) && userColumn < array.GetLength(1)) Console.WriteLine($"{array[userRow, userColumn]} -> элемент есть в массиве");
    else Console.WriteLine($"{userRow}, {userColumn} -> такого элемента в массиве нет");
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],5}, ");
            else Console.Write($"{array[i, j],5}");
        }
        Console.WriteLine(" ");
    }
}

int[,] array = CreateArrayRnd(3, 4, -100, 100);
PrintArray(array);
CheckElement(array, row, column);