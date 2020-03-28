using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new List<int>();

            var random = new Random();

            Console.WriteLine("Введите длину списка: ");
            int l = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < l; i++)
            {
                A.Add(random.Next(0, 50));
            }

            Console.WriteLine($"Длина списка: {l}");
            Console.WriteLine("Список до сортировки: \t\t");

            foreach (int a in A)
            {
                Console.Write(a + " ");
            }

            // Сортируем массив выбором.
            int temp = 0;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (A[j] > A[i])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
           
            }
            Console.WriteLine();

            Console.WriteLine("Список после сортировки : \t\t");
            foreach (int a in A)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Подмножество B, состоящее из максимально возможного числа элементов: \t");

            int sum = 0; // Сумма от 1-го до i-ого элементов множества А.
            int sum3 = 0; // Сумма 3-х первых элементов массива.
            int k = 0; // Индекс такого элемента множества А, что для а(1), ..., а(k) выполняется свойство (*).

            for (int i = 0; i < l-3; i++)
            {
                sum += A[i];
                sum3 = A[i] + A[i + 1] + A[i + 2]; 

                // Сравниваем сумму 3-х элементов и сумму всех элементов.
                if (sum3 <= sum) 
                {
                    k = i + 3;
                }
            }
            
            if (k == 0)
            {
                Console.WriteLine("Решения нет. \t");
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    Console.Write(A[i] + " ");
                }
            }

            Console.WriteLine("\n\nДля завершения нажмите клавишу Enter");

            Console.ReadLine();
        }
    }
}
