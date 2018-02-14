using System;

namespace MutableAndImmutable
{
    /// <summary>
    ///In C#, primarly we have two types of objects : reference type and
    ///value type. Value type objects always have default value and 
    ///created on stack. When we assign value type variable to another 
    ///variable, a new copy gets created. While reference types objects 
    ///default to null and created on heap. Multiple variables can point
    ///to the same object, it means changing the value using one will 
    ///reflect accross variables. There is one more type called Nullable
    ///type which is similar to value type with additional capability to
    ///have no value if it is unassigned. You can learn more about from one 
    ///of my previous posts here
    ///A reference type object can be categorized in two types : 
    ///Mutable and Immutable.The plain english meaning is 
    ///“Can Change” and “Cannot Change” respectively and which
    ///is same here as well.
    ///It means an Immutable object cannot be changed after it’s 
    ///creation/initialization and if one tries to change, a new copy
    ///gets created(if allowed) and returned.In other words, it is a 
    ///reference type but having value type semantics. String is one of 
    ///the most used immutable types and it is provided by the.NET framework.
    /// </summary>

    ///Normal class that we create, are mutable type.Let’s see an example
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person objPerson = new Person() { Name = "Irshad", Age = 21 };
            UpdatePerson(objPerson);
            Console.WriteLine(objPerson.Name);
            Console.ReadKey();
        }

        static void UpdatePerson(Person P)
        {
            P.Name += " Ahmed";
        }
    }
}
