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
            

            Random rand = new Random();                                                                         //рандом для задания игрового числа
            int MaxLimit;                                                                                       // предел диапозона загадываемого числа
            Console.Write("Введите число максимального предела диапазона: ");
            MaxLimit = int.Parse (Console.ReadLine());
            int iiNumber = rand.Next(0, MaxLimit);                                                              // загадываемое число
            // int count = 0;                                                                                   // счетчик попыток
            string num;                                                                                         // вводимое пользователем переменная
            int userNumber;                                                                                     // вводимое  пользователем число

            do
            {
                Console.Write("\nВведите число: ");                                                             // приглашение для пользователя ввести число
                //count++;
                num = Console.ReadLine();
                bool res = int.TryParse(num, out userNumber);                                                   // определение число ли введено пользователем
                if (res == true)
                {
                    if (userNumber < iiNumber)                                                                  // если число меньше
                    {
                        Console.WriteLine("Введенное число меньше загаданного. Попробуйте ещё раз");
                    }
                    else if (userNumber > iiNumber)
                    {
                        Console.WriteLine("Введенное число больше загаданного. Попробуйте ещё раз");            // если число больше
                    }
                    else
                    {
                        Console.WriteLine($"Поздравляю, число угадано! ");                                      // если число угадано
                        Console.ReadKey();
                        break;
                    }
                }
                else //if (res == null)
                {
                    Console.Write($"Загаданое число: {iiNumber}.");                                             // если пользователь ввел не число то игра закрывается
                    Console.ReadKey();
                    break;                   
                }
                //else
                //{
                //    Console.Write($"Необходимо ввести число.");
                //}
            }
            while (true);
        }
    }
}
