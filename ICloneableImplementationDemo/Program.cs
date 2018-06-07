using System;

namespace ICloneableImplementationDemo
{
    class TestClass:ICloneable
    {
        public string SomeText { get; set; }
        public int SomeNumber { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass first = new TestClass();
            first.SomeText = "First Class";
            first.SomeNumber = 1;
            TestClass second = (TestClass)first.Clone();
             

            Console.WriteLine($"First Object Text Data : {first.SomeText}\n" +
                              $"First Object Number Data: {first.SomeNumber}\n" +
                              $"Second Object Text Data: {second.SomeText}\n" +
                              $"Second Object Number Data: {second.SomeNumber}\n");

            second.SomeText = "Second Class";
            second.SomeNumber = 2;

            Console.WriteLine($"First Object Text Data : {first.SomeText}\n" +
                              $"First Object Number Data: {first.SomeNumber}\n" +
                              $"Second Object Text Data: {second.SomeText}\n" +
                              $"Second Object Number Data: {second.SomeNumber}\n");


            Console.ReadKey();

        }
    }
}
