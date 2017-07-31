namespace ClassDemo
{
    class DummyClass
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private static int counter = 0;

        public int CountIt()
        {
            counter++;
            return counter;
        }
    }
}