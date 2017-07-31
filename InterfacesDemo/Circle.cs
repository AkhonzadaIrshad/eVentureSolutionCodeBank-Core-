using System;
using System.Collections;

namespace InterfacesDemo
{
    class Circle : Shape, IEnumerable
    {
        public override void Area()
        {
            ///
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}