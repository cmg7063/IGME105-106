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
    public partial class FormQ12 : Form
    {
        public FormQ12()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked || radioButtonYes.Checked || radioButtonUnknown.Checked || radioButtonMaybe.Checked)
            {
                this.Hide();
                FormQ13 formQ13 = new FormQ13();
                formQ13.ShowDialog();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQ11 formQ11 = new FormQ11();
            formQ11.ShowDialog();
        }
    }
}
