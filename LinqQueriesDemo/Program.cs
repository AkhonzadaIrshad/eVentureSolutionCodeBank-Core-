using System.Linq;

namespace LinqQueriesDemo
{
    class Program
    {
        static string[] days = { "Monday",
                          "Tuesday",
                          "Wednesday",
                          "Thursday",
                          "Friday",
                          "Saturday",
                          "Sunday"
                         };
        static void Main(string[] args)
        {
            var a = (
                from n in days
                where n.Length > 3
                orderby n descending
                select n.ToUpper()
            );
        }
    }
}