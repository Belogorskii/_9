/*Смоделируйте работу простого калькулятора. Программа должна 
запрашивать 2 числа, а затем – код операции (например, 1 – сложение,
 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль 
 выводится ответ. Используйте обработку исключений для защиты от ввода 
 некорректных данных.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор");
            Console.WriteLine("Ведите целое чисто X");
            int X = 0;
            try
            {
                X = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("X = {0}", X);
            Console.WriteLine("Ведите целое чисто Y");

            //добавить разрыв программы

            int Y = 0;
            try
            {
                Y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            //добавить разрыв программы

            Console.WriteLine("Y = {0}", Y);
            Console.WriteLine("Введите код операции");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - произведение");
            Console.WriteLine("4 - частное");
            int Z = 0;
            try
            {
                Z = Convert.ToInt32(Console.ReadLine());
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("вне диап");
            }
            Console.WriteLine("Выбранна операция {0}", Z);
            int N = 0;
            if (Z == 1)
            {
                N = X + Y;
                Console.WriteLine("{0}", N);
            }
            else
            if (Z == 2)
            {
                N = X - Y;
                Console.WriteLine("{0}", N);
            }
            else
            if (Z == 3)
            {
                N = X * Y;
                Console.WriteLine("{0}", N);
            }
            else
            if (Z == 4)
            {
                N = X / Y;
                Console.WriteLine("{0}", N);
            }
            Console.ReadKey();
        }

    }

}