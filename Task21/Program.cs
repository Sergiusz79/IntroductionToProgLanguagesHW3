//Задача 21: Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.
//Например:
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int x1, x2, y1, y2, z1, z2;
Console.WriteLine("Please enter the coordinates of the first point (X Y Z): ");

ChekX1Y1Z1();

Console.WriteLine("Please enter the coordinates of the second point (X Y Z): ");

ChekX2Y2Z2();

int x = x2-x1; int y = y2 - y1; int z = z2 - z1;
double sqrt = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
double lgth =  Math.Round(sqrt, 2); // округление до 2-х знаков после запятой
Console.WriteLine($"Distance between points: {lgth}");








void ChekX1Y1Z1()
{
    while (!int.TryParse(Console.ReadLine(), out x1))
{
        Console.WriteLine("This is not number! Please enter number");
}
    while (!int.TryParse(Console.ReadLine(), out y1))
{
        Console.WriteLine("This is not number! Please enter number");
}
    while (!int.TryParse(Console.ReadLine(), out z1))
{
        Console.WriteLine("This is not number! Please enter number");
}
}

void ChekX2Y2Z2()
{
    while (!int.TryParse(Console.ReadLine(), out x2))
{
        Console.WriteLine("This is not number! Please enter number");
}
    while (!int.TryParse(Console.ReadLine(), out y2))
{
        Console.WriteLine("This is not number! Please enter number");
}
    while (!int.TryParse(Console.ReadLine(), out z2))
{
        Console.WriteLine("This is not number! Please enter number");
}
}
