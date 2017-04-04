using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Student : CommonCharacter
    {
        // There were other fields here... but I had to move them to the CommonCharacter class
        private int year;

        public Student(String name, String gender, int year) : base(name, gender)
        {
            this.sleep = 5;
            this.year = year;
            this.position = "student";
        }

        public int Year
        {
            get { return year; }
        }

        public override string ToString()
        {
            return name + ", a " + gender + " year " + year + " " + position + ", has had " + sleep + " hours of sleep";
        }

    }
}
