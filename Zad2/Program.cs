using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое целое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе целое число: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine($"Сумма чисел {num1} и {num2} равна {sum}");
    }
}
