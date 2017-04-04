using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21
{
    class Program
    {
        static void Main(string[] args)
        {
            TalentTreeNode root = new TalentTreeNode("exist", true);
            TalentTreeNode paceLeft = new TalentTreeNode("walk", true);
            TalentTreeNode paceRight = new TalentTreeNode("sprint", true);
            TalentTreeNode commLeft = new TalentTreeNode("cry", false);
            TalentTreeNode commRight = new TalentTreeNode("scream", true);
            TalentTreeNode prodLeft = new TalentTreeNode("game", false);
            TalentTreeNode prodRight = new TalentTreeNode("be productive", false);

            root.Left = paceLeft;
            root.Right = paceRight;

            paceLeft.Left = commLeft;
            paceLeft.Right = commRight;

            paceRight.Left = commLeft;
            paceRight.Right = commRight;

            root.ListKnownAbilities(root);
        }
    }
}
