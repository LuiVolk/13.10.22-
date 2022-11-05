// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X не равен 0 и Y не равен 0. 
// И выдает номер четверти плоскости, в которой находится эта точка.




Console.WriteLine("введите координаты точки");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quartr(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quartr(x, y);
string result = quarter > 0 
? $"указанные координаты соотсветствуют четверти -> {quarter}" 
: "введены не корректные координаты";
Console.WriteLine(result);
