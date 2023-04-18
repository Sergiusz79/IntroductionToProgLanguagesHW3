// Задача 19: Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.


int dig = 4;
int num;

Console.WriteLine("Please enter five-digit number ");
int.TryParse(Console.ReadLine(), out num);

//CheckText(num);
//int numcheck = num;








//CheckText(num);

//CheckDig(num);





void InputNum(int num)
{
    int.TryParse(Console.ReadLine(), out num);
}







void CheckText(int num)
{
        while (!int.TryParse(Console.ReadLine(), out num))
    {
    Console.WriteLine("This is not number! Please enter fiwe-digit number");
    }
}  
  
void CheckDig(int num)   
{
    while ((int) Math.Log10(num) != dig)
    {
    Console.WriteLine("This is not fiwe-digit number! Please enter fiwe-digit number");
    InputNum(num);
    }
}
