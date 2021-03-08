using System;
using System.Globalization;

namespace CSharpExercises.Edabit
{
    public class MonthNameByNumber
    {
        static void Main(string[] args)
        {
        }
        public static string MonthNameMethod(int num)
        {
            return CultureInfo.CurrentUICulture.DateTimeFormat.GetMonthName(num);
        }
    }


}