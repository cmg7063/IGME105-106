using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormHard
{
    class MyForm : Form
    {
        public MyForm()
        {
            this.Size = new Size(200, 200);
            this.Text = "Small buttons";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button a = new Button();
                    a.Text = ":)";
                    this.Controls.Add(a);
                    a.MouseEnter += ButtonCrap;
                    a.Location = new Point(i * 20, j * 20);
                    a.Size = new Size(20, 20);
                }
            }
        }

        public void ButtonCrap(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = (Button)sender;
                b.BackColor = Color.LightGoldenrodYellow;
            }
        }
    }
}
