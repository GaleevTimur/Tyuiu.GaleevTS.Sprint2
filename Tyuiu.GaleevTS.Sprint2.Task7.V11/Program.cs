using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GaleevTS.Sprint2.Task7.V11.Lib;

namespace Tyuiu.GaleevTS.Sprint2.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №2 | Выполнил: Галеев Т. С. | ИИПб-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание №7                                                               *");
            Console.WriteLine("* Вариант #11                                                              *");
            Console.WriteLine("* Выполнил: Галеев Тимур Серикович | ИИПб-23-3                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine(ds.CheckDotInShadedArea(x,y));
            Console.ReadKey();
        }
    }
}
