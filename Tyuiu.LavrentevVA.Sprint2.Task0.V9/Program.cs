using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LavrentevVA.Sprint2.Task0.V9.Lib;

namespace Tyuiu.LavrentevVA.Sprint2.Task0.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1054;
            int y = 375;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Сприт #1 | Выполнил: Лаврентьев В. А. | ИСПБ-25-1";
            Console.WriteLine("**************************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                                       *");
            Console.WriteLine("* Задание #0                                                                                                             *");
            Console.WriteLine("* Вариант #9                                                                                                             *");
            Console.WriteLine("* Выполнил: Лаврентьев В. А. | ИСПБ-25-1                                                                                 *");
            Console.WriteLine("**************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                               *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)      *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность(массив): (True, True, True, True, True, False)*");
            Console.WriteLine("**************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                       *");
            Console.WriteLine("* x = 1054 y = 375                                                                                                       *");
            Console.WriteLine("**************************************************************************************************************************");

            
            Console.WriteLine("X = : " + x);
            Console.WriteLine("Y = : " + y);

            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            for (int i=0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
            
        }
    }
}

