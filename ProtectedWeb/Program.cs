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
            for (int i = 0; i < numbers.Length; i++) // ����������� #1: ������ � �������� �������
            {
                numbers[i] = i * 2;
            }

            string text = string.Empty;
            if (!string.IsNullOrEmpty(text)) // ����������� #2: ������������� ������� � �������� �� �������
            {
                Console.WriteLine("Text is not empty");
            }

            int a = 10;
            int b = 1; // ����������� #3: �������� ������� �� ����
            int result = a / b;

            int[] array = new int[10];
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = j * 2;
            }
            Console.WriteLine(array[9]); // ����������� #4: ������ � �������� �������

            string input = Console.ReadLine();
            if (input.Equals("Hello", StringComparison.Ordinal)) // ����������� #5: ���������� ����� Equals ��� ��������� �����
            {
                Console.WriteLine("Hi there!");
            }
        }
    }
}