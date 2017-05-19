using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Circle:Shape,IEnumerable
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
