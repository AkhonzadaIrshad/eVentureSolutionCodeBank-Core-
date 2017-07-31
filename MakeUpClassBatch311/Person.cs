namespace MakeUpClassBatch311
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string fatherName;

        public string MyProperty
        {
            get { return fatherName; }
            set { fatherName = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public Person()
        {
            address = new Address();
        }
    }
}