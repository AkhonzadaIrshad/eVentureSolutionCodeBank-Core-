using System;
using System.Collections.Generic;

namespace GenericsWith319Demo
{
    class Calucator<T1,T2> where T1:struct where T2:struct
    {
        public T1 Add(T1 one, T2 two)
        {
            return one;//Addition Logic Here
        }
        public T1 Subtract(T1 one, T2 two)
        {
            return one;//Subtraction Logic Here
        }
        public T1 Multiply(T1 one, T2 two)
        {
            return one;//Multiplication Logic Here
        }


        //public bool Add<T>(T one, T two)
        //{
        //    return one.Equals(two);
        //}




    }

    class Program
    {


        

        //public static void Print<Type>(Type text)// where Type:class
        //{
        //    Console.WriteLine(text);
        //}


        static void Main(string[] args)
        {
            //Print<string>("Koi b Text");
            //Print<int>(1);
            //Print<float>(4.00f);
            //Print<double>(4.00);

            Calucator<int,double> calucator1=new Calucator<int,double>();
            //Calucator<string> calucator2=new Calucator<string>();

            Console.WriteLine();


        }
    }
}
