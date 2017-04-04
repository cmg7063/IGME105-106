using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Peg
    {
        // Attributes
        // Treat a Peg like a Vertex; this is how I track which peg holes are adjacent to one another
        private Peg left; // Left link to another node
        private Peg right; // Right link to another node
        private Peg down; // Down link to another node
        private Peg downLeft; // Down and to the Left link to another node
        private Peg downRight; // Down and to the Right link to another node
        private Peg upRight; // Up and to the Right link to another node
        private Peg upLeft; // Up and to the Left link to another node

        private bool isEmpty; // Track which holes are occupied/empty
        private int numPeg;

        // Properties
        public bool IsEmpty
        {
            get { return isEmpty; }
            set { isEmpty = value; }
        }      
        public int NumPeg
        {
            get { return numPeg; }
        }  
        public Peg Left
        {
            get { return left; }
            set { left = value; }
        }
        public Peg Right
        {
            get { return right; }
            set { right = value; }
        }
        public Peg Down
        {
            get { return down; }
            set { down = value; }
        }
        public Peg DownLeft
        {
            get { return downLeft; }
            set { downLeft = value; }
        }
        public Peg DownRight
        {
            get { return downRight; }
            set { downRight = value; }
        }
        public Peg UpRight
        {
            get { return upRight; }
            set { upRight = value; }
        }
        public Peg UpLeft
        {
            get { return upLeft; }
            set { upLeft = value; }
        }

        // Constructor
        public Peg(int numPeg)
        {
            this.numPeg = numPeg;
            isEmpty = false;
        }
    }
}
