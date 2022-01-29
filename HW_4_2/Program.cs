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
            string[] massStr2 = new string[tring.Length];
            tring[0] = new int[] { 1 }; // первая строка треугольника 1
            int row ;
            int col ;


            for (row = 1; row < tring.Length; row++)
                
            {
                tring[row] = new int[row + 1];
                

                for (col = 0; col <= row; col++)
                {
                    if (col == 0 || col == row)
                        tring[row][col] = 1;
                    else
                    {
                        tring[row][col] = tring[row - 1][col - 1] + tring[row - 1][col];   // складывает две верхние ячейки для нахождения своего числа
                    }
                }
                //massStr2[row] = tring[row].ToString();
                //var massStr = Array.ConvertAll(tring[row], x => x.ToString());
                //Console.SetCursorPosition((Console.WindowWidth / 2) - (tring [row].Length / 2), (Console.WindowHeight / 4) + row);
                //Console.Write($"{massStr2[row]);
               
            }
            //Console.Write(Convert.ToString($"{ tring}"));
            for (int i = 0; i < tring.Length; i++)
            {
               // Console.SetCursorPosition((Console.WindowWidth / 2) - (massStr2[i].Length / 2), (Console.WindowHeight / 4) + i);
                Console.Write($"{massStr2[i]}  ");
                Console.WriteLine(); // делит массивы на строчки при заполнении
                //for (int j = 0; j < massStr2[i].Length; j++)
                //{
                //    Console.Write($"{massStr2[i][j]}  ");
                //    Console.WriteLine(); // делит массивы на строчки при заполнении
                //}
            }


            //for (int i = 0; i < tring.Length; i++)
            //{

            //}


            Console.ReadKey();
            #endregion



        }
    }
}
