using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля

            #region my 
            Console.WriteLine("Программа построения треугольника паскаля в заданное количество строк.");
            Console.Write("Задайте число строк треугольника: ");
            int N = int.Parse(Console.ReadLine());


            int[][] tring = new int[N][];

            tring[0] = new int[] { 1 }; // первая строка треугольника 1
            //int left = 0;
            // int center = Console.WindowWidth / 2;

            for (int i = 1; i < tring.Length; i++)
            {
                tring[i] = new int[i + 1];
                

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        tring[i][j] = 1;
                    else
                    {
                        tring[i][j] = tring[i - 1][j - 1] + tring[i - 1][j];
                    }
                   
                }
            }
           
            for (int i = 0; i < tring.Length; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth / 2) - (tring[i].Length / 2), 6);

                for (int j = 0; j < tring[i].Length; j++)
                {
                   
                    Console.Write(" {0:D}", tring[i][j]);
                }
               
                Console.WriteLine();
            }

            Console.ReadKey();
            #endregion



        }
    }
}
