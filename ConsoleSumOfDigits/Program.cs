﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Подсчет суммы цифр числа
//Структура:
//Входные данные: целое число number.
//Выходные данные: сумма его цифр.

namespace ConsoleSumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(SumOfDigits(num));
        }
        static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

    }
}
