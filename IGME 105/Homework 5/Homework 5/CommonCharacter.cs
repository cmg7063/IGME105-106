using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class CommonCharacter
    {
        protected int sleep;
        protected String name;
        protected String gender;
        protected String position;

        public CommonCharacter()
        {
            sleep = 7;
            name = "UNKNOWN";
            gender = "UNKNOWN";
            position = "UNKONWN";
        }

        public CommonCharacter(String name, String gender)
        {
            this.gender = gender;
            this.name = name;
        }

        public int Sleep
        {
            get { return sleep; }
        }

        public String Name
        {
            get { return name; }
        }
        
        public String Gender
        {
            get { return gender; }
        }

        public void Spawn()
        {
            Console.WriteLine(name + ", a " + gender + " " + position + ", has had " + sleep + " hours of sleep.");
        }

    }
}
