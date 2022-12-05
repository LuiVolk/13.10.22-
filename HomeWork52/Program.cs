// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




int[,] CreateArrayDbl(int row, int column, int min, int max)
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
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("\t{0} ", array[i, j]);

        Console.WriteLine(" ");
    }
    Console.WriteLine();
}

void PrintArrayDbl(double[] array)
{
    Console.Write(" среднее арифметическое элементов - > ");
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write("{0:F1}; " ,  array[i] );
    }
    Console.WriteLine("");
    Console.WriteLine();
}

double[] ArrayAverage(int[,] array)
{
    int size = array.GetLength(1);                      
    double[] average = new double[size];                
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)   
        {
            average[i] += array[j, i];              
        }
        average[i] = Math.Round(average[i] / (double)array.GetLength(0), 1);    
    }
    return average;
}

int[,] arr = CreateArrayDbl(3, 5, 0, 10);
PrintArray(arr);
double[] array = ArrayAverage(arr);
PrintArrayDbl(array);