using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAgain
{
    class Warrior : DefaultCharacter
    {
        private int smellFactor;

        public Warrior(String name, int strength, int dexterity, int intelligence, int smellFactor) : base (name, strength, dexterity, intelligence)
        {
            //this.name = "Warrior";
            this.smellFactor = smellFactor;
        }

        public int SmellFactor
        {
            get { return smellFactor; }
            set { smellFactor = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " has not bathed in " + smellFactor + " days.";
        }

    }
}
