using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAgain
{
    class DefaultCharacter
    {
        protected String name;
        protected int strength;
        protected int dexterity;
        protected int intelligence;
        public DefaultCharacter(String name, int strength, int dexterity, int intelligence)
        {
            this.name = name;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }

        public String Name
        {
            get { return name; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        public override string ToString()
        {
            return "The " + name + " with strength level " + strength + ", dexterity level " + dexterity + ", and intelligence level " + intelligence;
        }

    }
}
