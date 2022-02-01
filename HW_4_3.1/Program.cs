using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Условие задачи.

            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |

            #endregion
            Console.Write("введите количество строк матрицы:");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int col = int.Parse(Console.ReadLine());
            Console.Write("Введите множитель: ");
            int factor = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Исходная матрица:");

            int[,] matrix = new int[row, col];
            Random random = new Random();

            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = random.Next(1, 101);
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Итоговая матрица: ");
            for (int i = 0;i < col; i++)
            {
                for (int j = 0;j < row; j++)
                {
                    matrix[i, j] = matrix[i, j] * factor;
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
