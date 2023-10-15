using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GaleevTS.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            int firstDayOfWeek = 1;

            int remainder = (k % 30) % 7;

            int dayOfWeek = (firstDayOfWeek + remainder) % 7;

            string n = "";
            switch (dayOfWeek)
            {
                case 0: n = "Воскресенье"; break;
                case 1: n = "Понедельник"; break;
                case 2: n = "Вторник"; break;
                case 3: n = "Среда"; break;
                case 4: n = "Четверг"; break;
                case 5: n = "Пятница"; break;
                case 6: n = "Суббота"; break;
            }
            return n;
        }
    }
}
