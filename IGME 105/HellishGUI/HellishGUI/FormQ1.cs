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
    public partial class FormQ1 : Form
    {
        public FormQ1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonAnimal.Checked || radioButtonMineral.Checked || radioButtonVegetable.Checked)
            {
                this.Hide();
                FormQ2 formQ2 = new FormQ2();
                formQ2.ShowDialog();
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStart formStart = new FormStart();
            formStart.ShowDialog();
        }
    }
}
