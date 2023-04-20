// Задача 19: Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.


int num;
int lgth = 0;
Console.WriteLine("Please enter five-digit number ");
    while (!int.TryParse(Console.ReadLine(), out num))
    {
    Console.WriteLine("This is not number! Please enter fiwe-digit number");
    }

CheckFiveDiget();

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


void CheckFiveDiget()
{
    do 
    {
        lgth = (int) Math.Log10(num);
        if (lgth != 4)
        {Console.WriteLine("It's not five-digits number! Please enter fiwe-digit number!");
        int num = int.TryParse(Console.ReadLine(), out num);
        }
           
            while (!int.TryParse(Console.ReadLine(), out num))
            {
            Console.WriteLine("This is not number! Please enter fiwe-digit number");
            }
          
    }
    while (lgth != 4);
}
