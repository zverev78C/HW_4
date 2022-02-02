using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //

            Console.WriteLine("Приложение для перемножения матриц.\n");
            Console.Write("Введите количство строк в матрице: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int col= int.Parse(Console.ReadLine());
            Random random = new Random();
            double [,] matrix1 = new double[row,col];
            double [,] matrix2 = new double[row, col];
            double[,] matrix3 = new double[row, col];

            Console.WriteLine("матрица №1:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix1[i,j] = random.Next(1,10);   
                    Console.Write($"{matrix1[i,j]} ");
                }
                Console.WriteLine ();
            }

            Console.WriteLine("матрица №2:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix2[i, j] = random.Next(1, 10);
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix3[i, j] = random.Next(1, 10);
                    Console.Write($"{matrix3[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
