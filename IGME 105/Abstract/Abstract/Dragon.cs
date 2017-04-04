using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Dragon
    {
        protected Random rng = new Random();
        protected int health;
        protected String name;

        public int Health
        {
            get { return health; }
            set
            {
                if (health < 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
        }

        public Dragon(int health, String name, Random rng)
        {
            this.health = health;
            this.name = name;
            this.rng = rng;
        }

        public abstract int Attack();

        public override string ToString()
        {
            return name + " has " + health + " health";
        }
    }
}
