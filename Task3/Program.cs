using System;

namespace Task3
{
    class Program
    {
        /*
         3. Составить алгоритм: на входе есть числовой массив, 
         необходимо вывести элементы массива кратные 3
         */
        static void Main(string[] args)
        {
            int[] array = {1, 3, 34, 12, 6, 7, 8, 7, 68, 9, 68, 679};

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}