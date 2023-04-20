// Задача 23: Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//Например:
//3 -> 1, 8, 27.
//5 -> 1, 8, 27, 64, 125

int num;
Console.WriteLine("Please enter number: ");
    while (!int.TryParse(Console.ReadLine(), out num))
    {
    Console.WriteLine("This is not number! Please enter number");
    }
for (int count = 1; count <= num; count++)
{
    int cube = (int) Math.Pow(count, 3);
    Console.Write($"  {cube}");
}
