using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomComparerDemo
{
    class Program
    {

        class Product:IComparable<Product>,IComparer<Product>
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private double price;

            public double Price
            {
                get { return price; }
                set { price = value; }
            }

            public int CompareTo(Product other)
            {
                return this.Price.CompareTo(other.Price);
            }

            public int Compare(Product x, Product y)
            {
                return x.Price.CompareTo(y.Price);
            }
        }



        static void Main(string[] args)
        {

            //string One = "StringOne";
            //string Two = "StringTwo";
            //One.CompareTo(Two);

            Product p1=new Product(){Name = "Product1",Price = 10000.00};
            Product p2=new Product(){Name = "Product2",Price = 12000.00};
            Console.WriteLine(p2.CompareTo(p1));


            Console.ReadKey();


        }
    }
}
