using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HelpingMaterials.IEnumerableImplementation
{

    //static void Main(string[] args)
    //{

    //    WeekDays week = new WeekDays();
    //    foreach (var weekDay in week)
    //    {

    //        Console.WriteLine(weekDay);

    //    }

    //    Console.ReadKey();

    //}



    class WeekDays:IEnumerable
    {
        private string[] Days = {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
        public IEnumerator GetEnumerator()
        {
            foreach (string day in Days)
            {
                yield return day;
            }
        }
    }
}
