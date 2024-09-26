using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        char[] reversed = input.ToCharArray();
        Array.Reverse(reversed);
        Console.WriteLine($"Строка в обратном порядке: {new string(reversed)}");
    }
}
