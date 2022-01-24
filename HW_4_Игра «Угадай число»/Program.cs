﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_Игра__Угадай_число_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Что нужно сделать
            //Разработайте программу по следующему алгоритму:

            //Пользователь вводит максимальное целое число диапазона. 
            //На основе диапазона целых чисел(от 0 до «введено пользователем») программа генерирует случайное целое число из диапазона.
            //Пользователю предлагается ввести загаданное программой случайное число.Пользователь вводит свои предположения в консоли приложения.
            //Если число меньше загаданного, программа сообщает об этом пользователю. 
            //Если больше, то тоже сообщает, что число больше загаданного.
            //Программа завершается, когда пользователь угадал число.
            //Если пользователь устал играть, то вместо ввода числа он вводит пустую строку и нажимает Enter. Тогда программа завершается, предварительно показывая,
            //какое число было загадано.


            //Советы и рекомендации
            //Чтобы организовать бесконечный ввод чисел и дать пользователю возможность вводить сколько угодно чисел, используйте цикл while или do while с условием(1 == 1)
            //или просто(true).
            //Для выхода из бесконечного цикла используйте break.


            //Что оценивается
            //Программа опрашивает пользователя и просит вводить числа.
            //Реализована возможность выхода из бесконечного цикла, когда пользователь устал.
            //Демонстрируется загаданный результат.

            Console.WriteLine("Игра \"Угадай-ка\"");
            

            Random rand = new Random();
            int MaxLimit;
            Console.Write("Введите число максимального предела диапазона: ");
            MaxLimit = int.Parse (Console.ReadLine());
            int iiNumber = rand.Next(0, MaxLimit);
            int count = 0;
            int userNumber;

            do
            {
                Console.Write("\nВведите число: ");
                count++;
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber < iiNumber)
                {
                    Console.WriteLine("Введенное число меньше загаданного. Попробуйте ещё раз");
                }
                else if (userNumber > iiNumber)
                {
                    Console.WriteLine("Введенное число больше загаданного. Попробуйте ещё раз");
                }
                else
                {
                    Console.WriteLine($"Поздравляю, число угадано! Число попыток: {count}.");
                    Console.ReadKey();
                    break;
                }
            }
            while (true);
        }
    }
}
