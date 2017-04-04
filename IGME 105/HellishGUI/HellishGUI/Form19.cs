using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HellishGUI
{
    public partial class Form19 : Form
    {
        private SoundPlayer _soundPlayer;
        public Form19()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Time Is Now.wav");
            _soundPlayer.Play();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void FormQ19_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 11000)
            {
                this.Hide();
                timer1.Stop();
                FormCen formCen = new FormCen();
                Form20 form20 = new Form20();
                Form21 form21 = new Form21();
                Form22 form22 = new Form22();
                Form23 form23 = new Form23();
                formCen.Show();
                form20.Show();
                form22.Show();
                form23.Show();
                form21.Show();
                formCen.Show();
            }
        }
    }
}
