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

            Random random = new Random();                     // создаю рандом для заполнения массивов

            int[] income = new int[13];                       // создаю массив прибыль
            int[] expenses = new int[13];                       // массив расходы
            int[] profit = new int[13];                         // массив прибыль
            Console.Write($"  месяц\t приход\t расход\t прибыль\n");      //название столбиков массива
            int profiton = 0;                                             // счетчик лучшего месяца
            int []low = new int[3];                                       // поиск меньшой прибыли
            int tlow = int.MinValue;

            for (int i = 1; i < income.Length; i++)           // цикл для заполнения массивов
            {
                income[i] = random.Next(1, 10) * 10_000;        // заполнения массива доход
                expenses[i] = random.Next(1,10) * 10_000;       // заполнение массива расходы
                profit[i] = income[i] - expenses[i];           // высчитывание прибыли
                Console.Write($"{i} мес.\t {income[i]}\t {expenses[i]} \t {profit[i]}\n");         //выведение на экран результатов
                int temp = 0 < profit[i] ? profiton++: profit[i] ;                              // считаем положительную прибыль
                //int templow = low > profit[i] ? low = i : low;
            }

            for (int i = 1; i < profit.Length; i++)
            {
                if (tlow < profit[i])
                {
                    tlow = profit[i];
                    low[i] = profit[i];
                }

            }


            Console.WriteLine();
            Console.Write($"Количество месяцев с положительной прибылью : {profiton} мес.\n");  // выводим на экран количство месяцев с полоижительной прибылью
            Console.WriteLine($"Худшая прибыль в месяцах: {low} ");
            Console.ReadKey();
        }
    }
}
