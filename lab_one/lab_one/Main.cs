using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab_one
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void oneToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormOne form_one = new FormOne();
            form_one.ShowDialog();
        }

        private void twoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTwo form_two = new FormTwo();
            form_two.ShowDialog();
        }

        private void threeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThree form_three = new FormThree();
            form_three.ShowDialog();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            Label lb_point_new = new Label();

            lb_point_new.AutoSize = true;
            lb_point_new.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            lb_point_new.Location = new Point(e.X, e.Y);
            lb_point_new.Size = new Size(18, 24);
            lb_point_new.TabIndex = 1;
            lb_point_new.Text = "#";
            
            Controls.Add(lb_point_new);
        }

        private void fourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFour form_four = new FormFour();
            form_four.ShowDialog();
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            string hello = "Hello!";

            PointF p = new PointF(ClientSize.Width / 2, ClientSize.Height / 2);

            e.Graphics.DrawString(hello, Font, SystemBrushes.WindowText, p);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
