using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayWithOOP
{
    public class Course
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int duration;

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        private DateTime startingDateTime;

        public DateTime StartingDateTime
        {
            get { return startingDateTime; }
            set { startingDateTime = value; }
        }

        

    }
}
