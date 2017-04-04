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
    public partial class FormQ14 : Form
    {
        public FormQ14()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked || radioButtonYes.Checked || radioButtonUnknown.Checked || radioButtonMaybe.Checked)
            {
                this.Hide();
                FormQ15 formQ15= new FormQ15();
                formQ15.ShowDialog();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQ13 formQ13 = new FormQ13();
            formQ13.ShowDialog();
        }
    }
}
