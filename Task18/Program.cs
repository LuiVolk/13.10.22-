// Задача 18: 
// Напишите программу, которая 
// 1. по заданному номеру четверти,
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());


string Quartr(int quarterXY)
{
    if (quarterXY == 1) return "x > 0 ; y > 0";
    if (quarterXY == 2) return  "x < 0 ; y > 0";
    if (quarterXY == 3) return  "x < 0 ; y < 0";
    if (quarterXY == 4) return  "x > 0 ; y < 0";
    return "не корректный номер четверти";
}
string xy = Quartr(quarter);
Console.Write($"Диапазон координат для четверти {quarter}: ");
Console.WriteLine(xy);

