namespace GenericDemo
{
    class Dummy<T>
    {
        public bool Compare(T one, T two)
        {
            if (one.Equals(two))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}