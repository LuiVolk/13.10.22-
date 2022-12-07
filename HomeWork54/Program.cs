// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateArrayRnd(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,4} ", array[i, j]);

        Console.WriteLine("]");
    }
    Console.WriteLine();
}

void SortRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = array[i, j];
            int index = j;
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, k] > max)
                {
                    max = array[i, k];
                    index = k;
                }
            }
            array[i, index] = array[i, j];
            array[i, j] = max;
        }
    }
}
int[,] arr = CreateArrayRnd(3, 5, 0, 10);
PrintArray(arr);
SortRow(arr);
PrintArray(arr);

