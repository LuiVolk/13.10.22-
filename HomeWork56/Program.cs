// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
            if (j < matrix.GetLength(1) - 1) Console.Write(" ");
        }
        Console.WriteLine(" ");
    }
}


int[] ArrayMinSumElemInRow(int[,] matrix)
{
    int sumElemInRow = 0;
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {            
            sumElemInRow += matrix[i, j];              
        }
        array[i] = sumElemInRow;
        sumElemInRow = 0;
    } 
    return array;
}

int RowMinSumIn(int[] array)
{
    int row = 0;
    int minSum = array[row];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSum) 
        {
            row = i;
            minSum = array[i];
        }
    }
    return row;
}

int[,] newMatrixRndInt = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(newMatrixRndInt);
int[] arrayMinSumElemInRow = ArrayMinSumElemInRow(newMatrixRndInt);
int rowMinSumIn = RowMinSumIn(arrayMinSumElemInRow);
Console.WriteLine($"номер строки с наименьшей суммой элементов -> {rowMinSumIn+1} строка");