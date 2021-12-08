using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_one
{
    public partial class FormThree : Form
    {
        public FormThree()
        {
            InitializeComponent();
        }

        int t = 0;

        private void bt_Start_Click(object sender, EventArgs e)
        {
            timer_Three.Interval = 1000;
            timer_Three.Enabled = true;
            timer_Three.Start();

            t = 0;
        }

        private void timer_Three_Tick(object sender, EventArgs e)
        {
            t += 10;

            tb_sec.Text = t.ToString();

            Size = new Size(300 + t, 300 + t);

            if (t == 500)
            {
                timer_Three.Stop();

                t = 0;
            }
        }

        private void bt_Pause_Click(object sender, EventArgs e)
        {
            if (timer_Three.Enabled == true)
            {
                timer_Three.Stop();
            }
            else
            {
                timer_Three.Start();
            }
        }
    }
}
