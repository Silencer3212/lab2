// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

using System;

namespace ExampleWithErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i <= numbers.Length; i++) 
            {
                numbers[i] = i * 2;
            }

            string text = null;
            if (text.Length > 0) 
            {
                Console.WriteLine("Text is not empty");
            }

            int a = 10;
            int b = 0;
            int result = a / b; 

            int[] array = new int[10];
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = j * 2;
            }
            Console.WriteLine(array[10]); 

            int unusedVariable; 
            Console.WriteLine("End of program");
        }
    }
}