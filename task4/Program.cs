
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    if(num1 > num3)
    {
        Console.WriteLine("первое число - максимальное");
    }
    else
    {
        Console.WriteLine("третье число - максимальное");
    }
}
else if(num2 > num3)
{
    Console.WriteLine("второе число - максимальное");
}
else
{
    Console.WriteLine("третье число - максимальное");
}
