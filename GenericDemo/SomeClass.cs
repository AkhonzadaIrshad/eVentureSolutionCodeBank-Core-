using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    class SomeClass<T>
    {

        private T somedata;

        public T Somedata
        {
            get { return somedata; }
            set { somedata = value; }
        }


    }
}
