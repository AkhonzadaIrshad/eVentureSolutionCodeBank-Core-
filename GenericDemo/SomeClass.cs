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