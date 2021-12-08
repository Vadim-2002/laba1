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
    public partial class FormFour : Form
    {
        public FormFour()
        {
            InitializeComponent();
        }

        private void FormFour_MouseDown(object sender, MouseEventArgs e)
        {
            Button bt_create = new Button();
            bt_create.BackColor = SystemColors.MenuText;
            bt_create.ForeColor = SystemColors.ButtonHighlight;
            bt_create.Location = new Point(e.X, e.Y);
            bt_create.Name = "bt_create";
            bt_create.Size = new Size(75, 23);
            bt_create.TabIndex = 4;
            bt_create.Text = "Create";
            bt_create.UseVisualStyleBackColor = false;
            bt_create.Click += new EventHandler(bt_create_Click);

            Controls.Add(bt_create);
        }

        int i = 0;

        private void bt_create_Click(object sender, EventArgs e)
        {
            Size = new Size(400 + i, 250 + i);

            i += 10;

            pb_progress.PerformStep();
        }

        bool isDown;
        private void date_four_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void date_four_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;

            if (isDown)
                c.Location = this.PointToClient(Control.MousePosition);
        }

        private void date_four_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            web_browser.Navigate(tb_input.Text);
        }
    }
}
