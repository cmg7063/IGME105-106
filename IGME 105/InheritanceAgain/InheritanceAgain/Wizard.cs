using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAgain
{
    class Wizard : DefaultCharacter
    {
        private int hotPocketPercent;

        public Wizard(String name, int strength, int dexterity, int intelligence, int hotPocketPercent) : base (name, strength, dexterity, intelligence)
        {
            //this.name = "Wizard";
            this.hotPocketPercent = hotPocketPercent;
        }

        public int HotPocketPercent
        {
            get { return hotPocketPercent; }
            set { hotPocketPercent = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " has had " + hotPocketPercent + "% of spells backfire on him/her.";
        }
    }
}
