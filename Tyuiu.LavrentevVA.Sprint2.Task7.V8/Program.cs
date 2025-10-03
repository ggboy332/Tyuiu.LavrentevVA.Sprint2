using Tyuiu.LavrentevVA.Sprint2.Task7.V8.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.LavrentevVA.Sprint2.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

            Console.WriteLine(" Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");


            if (res)
            {
                Console.WriteLine("Точка находится в закрашенной области");
            }
            else
            {
                Console.WriteLine("Точка находится не в закрашенной области");
            }


            Console.ReadKey();

        }
    }
}
