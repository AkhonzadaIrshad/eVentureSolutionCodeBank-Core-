namespace ClassAssociationDemo
{
    class Student
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Info info;

        public Info Info
        {
            get { return info; }
            set { info = value; }
        }

        public Student()
        {
            Info = new Info();
        }
    }
}