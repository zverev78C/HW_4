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
            #region Задание 1.
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
            Console.Write($"  мес.\t приход\t расход\t прибыль\n");      //название столбиков массива
            for (int i = 1; i < income.Length; i++)           // цикл для заполнения массивов
            {
                income[i] = random.Next(1, 10) * 10_000;        // заполнения массива доход
                expenses[i] = random.Next(1,10) * 10_000;       // заполнение массива расходы
                profit[i] = income[i] - expenses[i];           // высчитывание прибыли
                
                Console.Write($"{i} мес.\t{income[i]}\t{expenses[i]} \t{profit[i]}\n");         //выведение на экран результатов

            }

            Console.ReadKey();
            #endregion



            #region * Задание 2
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

            #endregion

            #region Задание 3.1
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
            //
            #endregion

            #region Задание 3.2

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

            #endregion

            #region Задание 3.3
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
            #endregion

            //                ДЗ 4.8

            //            Цели домашнего задания
            //Научиться использовать одномерные и двумерные массивы. 
            //Закрепить знания по применению циклов.


            //Что входит в задание
            //Задание 1.Случайная матрица.
            //Задание 2.Наименьший элемент в последовательности.
            //Задание 3.Игра «Угадай число».




            #region Задание 1.Случайная матрица


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

            #endregion

            #region Задание 2.Наименьший элемент в последовательности


            //Что нужно сделать
            //Найдите наименьший элемент в последовательности, которую вводит пользователь.Последовательность нужно сохранить в массив.Детальный алгоритм программы:

            //            Пользователь вводит длину последовательности. 
            //Затем пользователь последовательно вводит целые числа(как положительные, так и отрицательные). Числа разделяются клавишей Enter.
            //Каждое введённое число помещается в соответствующий элемент массива.
            //После окончания ввода данных отдельный цикл проходит по последовательности и находит минимальное число.Для этого он сравнивает каждое число в итерации с предыдущим найденным минимальным числом.


            //Рекомендация
            //Чтобы правильно организовать поиск наименьшего числа, на этапе инициализации, в качестве начального значения минимального числа, выберите int.MaxValue.Тогда любое число из массива, какое бы вы ни взяли, окажется меньше, чем это значение.



            //Что оценивается
            //Программа выводит на экран наименьшее число из последовательности пользователя.

            #endregion

            #region Задание 3.Игра «Угадай число» 



            //Что нужно сделать
            //Разработайте программу по следующему алгоритму:

            //Пользователь вводит максимальное целое число диапазона. 
            //На основе диапазона целых чисел(от 0 до «введено пользователем») программа генерирует случайное целое число из диапазона.
            //Пользователю предлагается ввести загаданное программой случайное число.Пользователь вводит свои предположения в консоли приложения.
            //Если число меньше загаданного, программа сообщает об этом пользователю. 
            //Если больше, то тоже сообщает, что число больше загаданного.
            //Программа завершается, когда пользователь угадал число.
            //Если пользователь устал играть, то вместо ввода числа он вводит пустую строку и нажимает Enter. Тогда программа завершается, предварительно показывая, какое число было загадано.


            //Советы и рекомендации
            //Чтобы организовать бесконечный ввод чисел и дать пользователю возможность вводить сколько угодно чисел, используйте цикл while или do while с условием(1 == 1) или просто(true).
            //Для выхода из бесконечного цикла используйте break.


            //Что оценивается
            //Программа опрашивает пользователя и просит вводить числа.
            //Реализована возможность выхода из бесконечного цикла, когда пользователь устал.
            //Демонстрируется загаданный результат.
            #endregion



        }
    }
}
