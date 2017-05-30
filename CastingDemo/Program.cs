using System;

namespace CastingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            short _short = 1;
            int _int = 2;
            long _long = 3;

            //Precise Types
            float _float = 10.00f;
            double _double = 20;

            ///
            decimal _decimal = 30;

            //implicit Casting
            _int = _short;
            _double = _float;
            _float = _int;
            //Explicit Casting
            _short = (short)_int;
            _short = Convert.ToInt16(_int);
            _float = (float)_double;
            _int = (int)_float;
        }
    }
}