﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 


            // За год получены два массива – расходов и поступлений.

            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10

            int[,] matrix = new int[12, 4]; // Задание двумерного массива, в котором 12 строк и 4 столбца 
            int[] profit = new int[12];     // Задание одномерного массива для записи прибыли
            int income = 0;                 // Задание переменной для подсчета месяцев с положительной прибылью
            string months = "";             // Задание переменной для вывода номеров месяцев с тремя наихудшими показателями
            Random r = new Random();        // Создание переменной г для получения псевдослучайных чисел
            Console.WriteLine($"{"Месяц",6}  {"Доход, тыс.руб.",16} { "Расход, тыс.руб.",16} {"Прибыль, тыс.руб.",16}"); //вывод шапки массива
            for (int i = 0; i < 12; i++)
            {
                matrix[i, 0] = i + 1;                          // Задание номера месяца
                matrix[i, 1] = r.Next(5, 20) * 10_000;         // Задание размера дохода случайным образом
                matrix[i, 2] = r.Next(5, 20) * 10_000;         // Задание размера расхода случайным образом
                matrix[i, 3] = matrix[i, 1] - matrix[i, 2];    // Расчет прибыли
                profit[i] = matrix[i, 3];                      // заполнение одномерного массиев profit значениями прибыли
                Console.WriteLine($"{matrix[i, 0],5} {matrix[i, 1],15} {matrix[i, 2],15} {matrix[i, 3],15}"); //Вывод значений массива
            }
            profit = profit.Distinct().ToArray(); //Метод, позволяющий не выводить повторы значений одномерного массива прибыли
            Array.Sort(profit);                    //упорядочиваем  прибыль

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (matrix[i, 3] > 0 && j == 0)                 //цикл для подсчета количества месяцев с положительной прибылью
                    {
                        income++;
                    }
                    if (matrix[i, 3] == profit[j])                  //цикл для вывода месяцев с тремя худшими показателями прибыли,
                    {                                               // если есть несколько месяцев, в которых худшая прибыль совпала выводит их все.                      
                        months = months + " " + (i + 1).ToString(); //Присвоение переменной mоnths номеров месяцев с тремя наихудшими показателями прибыли
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Худшая прибыль в месяцах: {months}");
            Console.WriteLine($"Месяцев с положительной прибылью: {income} ");
            Console.ReadKey();
        }
    }
}
