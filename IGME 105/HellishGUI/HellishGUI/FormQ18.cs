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
    public partial class FormQ18 : Form
    {
        public FormQ18()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked || radioButtonYes.Checked || radioButtonUnknown.Checked || radioButtonMaybe.Checked)
            {
                this.Hide();
                FormReady formReady = new FormReady();
                formReady.ShowDialog();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQ17 formQ17 = new FormQ17();
            formQ17.ShowDialog();
        }
    }
}
