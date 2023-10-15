using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GaleevTS.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int value)
        {
            int cardnumber = value;
            switch (cardnumber)
            {
                case 6:
                    return "шестёрка";
                case 7:
                    return "семёрка";
                case 8:
                    return "восьмёрка";
                case 9:
                    return "девятка";
                case 10:
                    return "десятка";
                case 11:
                    return "валет";
                case 12:
                    return "дама";
                case 13:
                    return "король";
                case 14:
                    return "туз";
                default:
                    return "Некорректная карта";

            }
        }
    }
}
