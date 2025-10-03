using Tyuiu.LavrentevVA.Sprint2.Task7.V8.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.LavrentevVA.Sprint2.Task7.V8
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
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(X, y);

            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находитья в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка находитья не в заштрихованной области");
            }
            


            Console.ReadKey();

        }
    }
}
