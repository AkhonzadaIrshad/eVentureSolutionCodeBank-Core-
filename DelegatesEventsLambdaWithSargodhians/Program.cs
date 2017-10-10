using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambdaWithSargodhians
{



    class Program
    {

        delegate void MyDelegate(int a, int b);

        static void Main(string[] args)
        {



            MyDelegate myDelegate = (a, b) =>            
            {
                Console.WriteLine(a + b);
            };
            myDelegate += (a, b) => Console.WriteLine(a + b);
            myDelegate(1, 4);

            Console.ReadKey();
        }

    }
}
