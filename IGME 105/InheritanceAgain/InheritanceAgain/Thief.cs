using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAgain
{
    class Thief : DefaultCharacter
    {
        private int cellRings;

        public Thief(String name, int strength, int dexterity, int intelligence, int cellRings) : base (name, strength, dexterity, intelligence)
        {
            //this.name = "Thief";
            this.cellRings = cellRings;
        }

        public int CellRings
        {
            get { return cellRings; }
            set { cellRings = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " has had his/her phone ring " + cellRings + " times.";
        }
    }
}
