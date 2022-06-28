// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

for (int result =1; result <= num; result++)


{
    if (result % 2 == 0)
    {
        Console.Write(result+" ");
    }
}