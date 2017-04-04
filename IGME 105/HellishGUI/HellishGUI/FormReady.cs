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
    public partial class FormReady : Form
    {
        public FormReady()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked)
            {
                this.Hide();
                Form19 form19 = new Form19();
                form19.ShowDialog();
            }
            if (radioButtonNo.Checked)
            {
                MessageBox.Show("Well get ready!");
            }
        }
    }
}
