using System;

namespace IDisposableImplementation
{
    class TestClass:IDisposable
    {
        public string SomeData { get; set; }

        public void Dispose()
        {
           //GC.SuppressFinalize(this);   
        }

     }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test=new TestClass();
            test.SomeData = "SOME DATA HERE -before using";
            using (test)
            {
                test.SomeData = "SOME DATA HERE -in using";
            }

            test.SomeData = "SOME DATA HERE -after using";

            Console.WriteLine(test.SomeData);
            Console.ReadKey();
        }
    }
}
