using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Введите число для проверки на простоту: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
            Console.WriteLine($"{number} является простым числом.");
        else
            Console.WriteLine($"{number} не является простым числом.");
    }
}