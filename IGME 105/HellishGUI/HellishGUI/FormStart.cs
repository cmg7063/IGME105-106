using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellishGUI
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.Hide(); // This closes the intial form... Might want to remove this line.
            FormQ1 formQ1 = new FormQ1();
            formQ1.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Think of anything and I will try and guess what you are thinking in 20 guesses or less!");
        }
    }
}
