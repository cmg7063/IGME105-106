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
    public partial class FormCen : Form
    {
        public FormCen()
        {
            InitializeComponent();
            pictureBoxJohn.Controls.Add(pictureBoxFire1);
            pictureBoxJohn.Controls.Add(pictureBoxFire2);
            pictureBoxJohn.Controls.Add(pictureBoxBottomFire);
            pictureBoxBottomFire.Location = new Point(-34, 112);
            pictureBoxFire2.BackColor = Color.Transparent;
            pictureBoxFire2.Location = new Point(183, 12);
            pictureBoxFire2.BackColor = Color.Transparent;
            pictureBoxFire1.Location = new Point(12, 12);
            pictureBoxFire1.BackColor = Color.Transparent;
        }

        private void FormCen_Load(object sender, EventArgs e)
        {
        }
    }
}
