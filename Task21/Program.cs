





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