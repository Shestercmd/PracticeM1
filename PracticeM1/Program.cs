using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Введите число для вычисления факториала: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Факториал числа {number} равен {Factorial(number)}");
    }
}

