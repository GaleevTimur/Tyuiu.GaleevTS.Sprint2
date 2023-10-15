using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GaleevTS.Sprint2.Task3.V28.Lib
{
    public class DataService : ISprint2Task3V28
    {
        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)
            {
                res = x + Math.Pow(((Math.Cos(x*x)) / (x - 1)), x+3);
            }
            else if (x == 0)
            {
                res = ((x*x+Math.Cos(x*x) - 11)/(x*x - Math.Sin(x*x) + 2));
            }
            else if (-32 < x && x < -1)
            {
                res = Math.Pow(Math.Cos(x)/(Math.PI-x), 2);
            }
            else if (x < -32)
            {
                res = x + 10 * x - (7 / x);
            }
            return Math.Round(res, 3);
        }
    }
}
