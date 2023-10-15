using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GaleevTS.Sprint2.Task1.V13.Lib;

namespace Tyuiu.GaleevTS.Sprint2.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 145;
            int b = 916;
            int c = 164;
            int d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);



            Console.Title = "Спринт №2 | Выполнил: Галеев Т. С. | ИИПб-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание №0                                                               *");
            Console.WriteLine("* Вариант #30                                                              *");
            Console.WriteLine("* Выполнил: Галеев Тимур Серикович | ИИПб-23-3                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)          *");
            Console.WriteLine("* и арифмитических выражений, которая вернет логическую последовательность *");
            Console.WriteLine("* (True, True, True, True True, False)                                  *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Значение a = " + a);
            Console.WriteLine("Значение b = " + b);
            Console.WriteLine("Значение c = " + c);
            Console.WriteLine("Значение d = " + d);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);

            }

            Console.ReadKey();
        }
    }
}
