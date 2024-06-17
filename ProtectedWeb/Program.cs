// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

namespace ExampleWithoutErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++) // Исправление #1: Индекс в пределах массива
            {
                numbers[i] = i * 2;
            }

            string text = string.Empty;
            if (!string.IsNullOrEmpty(text)) // Исправление #2: Инициализация строкой и проверка на пустоту
            {
                Console.WriteLine("Text is not empty");
            }

            int a = 10;
            int b = 1; // Исправление #3: Избегаем деления на ноль
            int result = a / b;

            int[] array = new int[10];
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = j * 2;
            }
            Console.WriteLine(array[9]); // Исправление #4: Индекс в пределах массива

            string input = Console.ReadLine();
            if (input.Equals("Hello", StringComparison.Ordinal)) // Исправление #5: Используем метод Equals для сравнения строк
            {
                Console.WriteLine("Hi there!");
            }
        }
    }
}