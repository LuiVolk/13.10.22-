// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] RndMass(int size, int mn, int mx)   // Метод создания массива
{
int[] array = new int[size];
Random rnd = new Random();

for (int i = 0; i < size; i++)
{
array[i] = rnd.Next(mn, mx + 1);
}

return array;
}

void PrintArray(int[] array)   // Печать массива
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}

bool FindNUmArray(int[] array, int num)
{
for (int i = 0; i < array.Length; i++)
{
if (array[i] == num) return true;
}

return false;
}

Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = RndMass(12, -9, 9);
PrintArray(arr);

if (FindNUmArray(arr, number))
{
Console.WriteLine("Данное число пристутствует в массиве");
}
else
{
Console.WriteLine("Данное число отсутсвует в массиве");
}