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
    public partial class FormQ11 : Form
    {
        public FormQ11()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked || radioButtonYes.Checked || radioButtonUnknown.Checked || radioButtonSometimes.Checked)
            {
                this.Hide();
                FormQ12 formQ12 = new FormQ12();
                formQ12.ShowDialog();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQ10 formQ10 = new FormQ10();
            formQ10.ShowDialog();
        }
    }
}
