using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Создаем массив из 15 случайных чисел в диапазоне от -100 до 100
        Random rand = new Random();
        int[] numbers = new int[15];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(-100, 101); // Генерация числа от -100 до 100 включительно
        }

        // Находим все положительные числа
        var positiveNumbers = numbers.Where(n => n > 0).ToArray();

        // Проверяем, есть ли положительные числа в массиве
        if (positiveNumbers.Length > 0)
        {
            // Находим среднее значение положительных чисел
            double averagePositive = positiveNumbers.Average();
            Console.WriteLine("Массив: " + string.Join(", ", numbers));
            Console.WriteLine("Положительные числа: " + string.Join(", ", positiveNumbers));
            Console.WriteLine("Среднее значение положительных чисел: " + averagePositive);
        }
        else
        {
            Console.WriteLine("В массиве нет положительных чисел.");
        }
    }
}
