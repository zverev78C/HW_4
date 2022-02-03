using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |




            Console.Write("Введите количство строк матрицы: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int col = int.Parse(Console.ReadLine());
            
            //Console.Write($"{ action}\n");
            int[,] matrix1 = new int[row, col];
            int[,] matrix2 = new int[row, col];

            Random random = new Random();
            Console.WriteLine("Мытрица №1:  ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix1[i, j] = random.Next(1, 50);
                    //matrix2[i, j] = random.Next(1, 50);
                    Console.Write ($"{matrix1[i, j],5}");
                    //Console.Write($"{matrix2[i, j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Мытрица №2:  ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //matrix1[i, j] = random.Next(1, 50);
                    matrix2[i, j] = random.Next(1, 50);
                    //Console.Write($"{matrix1[i, j],5}");
                    Console.Write ($"{matrix2[i, j],5}");
                }
                Console.WriteLine();
            }
            Console.Write("Что необходимо сделать?\n Сложение матриц: 1 \n вычитание матриц: 2 \n");
            int action = int.TryParse (Console.ReadLine());

              switch (action)
              {
                    case 1: // сложение
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {

                            }
                        }
                        break;
                    case 2: // вычитание
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {

                            }
                        }
                        break;
              }
            
            Console.ReadKey();
        }
    }
}
