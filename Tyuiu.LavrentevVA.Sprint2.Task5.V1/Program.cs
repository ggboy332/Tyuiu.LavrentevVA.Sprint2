using Tyuiu.LavrentevVA.Sprint2.Task5.V1.Lib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.LavrentevVA.Sprint2.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

            Console.WriteLine(" Введите номер месяца: ");
            int numMounth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMounth < 1) || (numMounth > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Кол-во дней:" + ds.FindMonthDaysCount(numMounth);
            }

            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");


            Console.WriteLine(res);


            Console.ReadKey();

        }
    }
}
