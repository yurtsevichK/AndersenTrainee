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
            Console.Write("Введите количество элементов в массиве: ");

            try 
            {
                int elementsCount = int.Parse(Console.ReadLine());
                int[] array = new int[elementsCount];
                
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Введите элемент массива под индексом {i}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 3 == 0)
                    {
                        Console.Write($"\nЭлемент массива кратный 3 под индексом {i}: " + array[i]);
                    }
                }
            }
            catch (Exception){
            Console.Write("\nДопущена ошибка некоррекнтый ввод количества элементов " +
                              "массива или самого элемента массива!!!");
            }
        }
    }
}