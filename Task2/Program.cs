using System;

namespace Task2
{
    class Program
    {
        /*
        2.Составить алгоритм: если введенное имя совпадает с Вячеслав,
        то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени"
        */
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            if (name=="Вячеслав")
            {
                Console.WriteLine("Привет, Вячеслав");
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }
        }
    }
}