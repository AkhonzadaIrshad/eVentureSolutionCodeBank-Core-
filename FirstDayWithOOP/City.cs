namespace FirstDayWithOOP
{
    public class City
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int code;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        private Country country;

        public Country Country
        {
            get { return country; }
            set { country = value; }
        }

    }
}