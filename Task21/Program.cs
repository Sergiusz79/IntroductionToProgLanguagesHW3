//Задача 21: Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.
//Например:
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53



int dig = 4;
int num;


while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("This is not number! Please enter fiwe-digit number");
}



while ((int)Math.Log10(num) != dig)
{
    Console.WriteLine("This is not fiwe-digit number! Please enter fiwe-digit number");
}