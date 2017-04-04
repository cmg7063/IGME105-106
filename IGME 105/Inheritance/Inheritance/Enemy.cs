using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Enemy
    {
        protected int speed;
        protected String color;
        protected String shape;

        public int Speed
        {
            get { return speed; }
        }

        public String Color
        {
            get { return color; }
        }

        public String Shape
        {
            get { return shape; }
        }

        public Enemy()
        {
            speed = 75;
            color = "UNKNOWN";
            shape = "UNKNOWN";
        }

        public void Spawn()
        {
            Console.WriteLine("A " + color + shape + " has spawned.");
        }

    }
}
