using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_случайгая_матрица
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Что нужно сделать
            //Выведите на экран матрицу заданного размера и заполните её случайными числами.Детальный алгоритм работы приложения:

            //Сначала пользователю предлагается ввести количество строк в будущей матрице.
            //Затем — ввести количество столбцов в будущей матрице.
            //После того, как данные будут получены, нужно создать в памяти матрицу заданного размера.
            //Используя Random, заполнить матрицу случайными целыми числами.
            //Вывести полученную матрицу на экран.
            //Вывести суммы всех элементов этой матрицы на экран отдельной строкой.


            //Рекомендация
            //Для работы с матрицами используйте вложенные циклы.



            //Что оценивается
            //Программа выводит на экран случайно созданную матрицу предварительно заданного размера, а также сумму всех элементов в ней.


            int row = 1;
            int column = 1;
            int sum = 0;
            Random random = new Random();

            Console.Write("Введите количество строк: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            column = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(25);
                    Console.Write($"{matrix[i, j]}\t ");
                    sum = sum + matrix[i, j];
                }
                Console.WriteLine();
            }
            Console.Write($"Сумма равна: {sum}");

            Console.ReadKey();
        }
    }
}
