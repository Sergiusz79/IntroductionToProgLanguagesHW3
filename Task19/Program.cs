// Задача 19: Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.


int dig = 4;
int num;
Console.WriteLine("Please enter five-digit number ");
    while (!int.TryParse(Console.ReadLine(), out num))
    {
    Console.WriteLine("This is not number! Please enter fiwe-digit number");
    }

if ((int)Math.Log10(num) == dig)
{
    int a = num / 10000, a1 = num % 10,  
    b = num / 1000 % 10, b1 = num / 10 % 10;
    if (a == a1 && b == b1)
    {
                Console.WriteLine("It's a palindrome!");
    }
    else 
    {
                Console.WriteLine("It's not a palindrome!");
    }
}
else 
{
    Console.WriteLine("This is not fiwe-digit number!");
}
