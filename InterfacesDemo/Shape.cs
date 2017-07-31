namespace InterfacesDemo
{
    abstract class Shape
    {
        private float length;

        public float Length
        {
            get { return length; }
            set { length = value; }
        }

        public abstract void Area();
    }
}