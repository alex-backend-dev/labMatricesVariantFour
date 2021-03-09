using System;
using System.IO;

namespace labMatrices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int M = int.Parse(Console.ReadLine());

            int[,] A = new int[N, M];

            Random random = new Random();

            for (N = 0; N < A.GetLength(0); N++) // по строкам прошлись
            {
                for (M = 0; M < A.GetLength(1); M++) // по столбцам
                {
                    A[N, M] = random.Next(-500, 500);
                }
            }

            Console.WriteLine("\nИсходный массив:");

            for (N = 0; N < A.GetLength(0); N++) // по строкам прошлись
            {
                for (M = 0; M < A.GetLength(1); M++) // по столбцам
                {
                    Console.Write(A[N, M] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            bool isNegative = false;

            for (M=0; M < A.GetLength(1); M++)
            {
                isNegative = false;

                for (N = 0; N < A.GetLength(0); N++)
                {
                    if (A[N,M]<0)
                    {
                        isNegative = true;
                        break;
                    }
                }

                if (!isNegative) 
                    break;
            }

            if (!isNegative) 
                 Console.WriteLine("{0}-й столбец не имеет отрицательных элементов", ++M);

            else Console.WriteLine("В этом массиве нет столбцов с неотрицательными элементами");

            Console.ReadLine();
        }
    }
}
