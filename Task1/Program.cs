using System;

namespace Task1
{
    class Program
    {
        // 1.Составить алгоритм: если введенное число больше 7, то вывести “Привет”
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());

            if (number > 7)
            {
                Console.WriteLine("Привет");   
            }
        }
    }
}