using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21
{
    class TalentTreeNode
    {
        // attributes
        private TalentTreeNode left; // left link to another node
        private TalentTreeNode right; // right link to another node
        private string ability;
        private bool learned;

        // constructor
        public TalentTreeNode(string ability, bool learned)
        {
            this.ability = ability;
            this.learned = learned;
        }

        // properties
        public TalentTreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        public TalentTreeNode Right
        {
            get { return right; }
            set { right = value; }
        }

        public void ListKnownAbilities(TalentTreeNode node)
        {
            if(node != null)
            {
                ListKnownAbilities(node.Left);
                if (node.learned)
                {
                    Console.WriteLine(node.ability);
                }
                ListKnownAbilities(node.Right);
            }
        }

        public void ListPossibleAbilities()
        {

        }
    }
}
