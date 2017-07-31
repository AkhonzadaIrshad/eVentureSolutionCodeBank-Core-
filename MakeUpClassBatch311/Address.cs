namespace MakeUpClassBatch311
{
    class Address
    {
        private string streetAddress;

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        private City city;

        public City City
        {
            get { return city; }
            set { city = value; }
        }
    }
}