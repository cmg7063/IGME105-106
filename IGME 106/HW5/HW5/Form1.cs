using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PuzzleSolver puzzleSolver = new PuzzleSolver(this);
            for(int i = 0; i < 15; i++)
            {
                puzzleSolver.Solved = false;
                while(puzzleSolver.Solved == false) // While the puzzle has yet to be solved, iterate through a different starting peg position
                {
                    puzzleSolver.SolvePuzzle(i);
                }
            }
        }
        // Display moves
        public void Display(string input)
        {
            textBox1.AppendText(input + Environment.NewLine);

        }
    }
}
