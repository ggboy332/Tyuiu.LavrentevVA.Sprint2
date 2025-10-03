using Tyuiu.LavrentevVA.Sprint2.Task6.V4.Lib;
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

            Console.WriteLine(" Введите номер масти: ");
            int numMast = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMast < 1) || (numMast > 4))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "номер масти:" + ds.FindCardSuit(numMast);
            }

            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");


            Console.WriteLine(res);


            Console.ReadKey();

        }
    }
}
