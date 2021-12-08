
namespace lab_one
{
    partial class FormFour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.date_four = new System.Windows.Forms.DateTimePicker();
            this.pb_progress = new System.Windows.Forms.ProgressBar();
            this.web_browser = new System.Windows.Forms.WebBrowser();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.bt_input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date_four
            // 
            this.date_four.Location = new System.Drawing.Point(12, 26);
            this.date_four.Name = "date_four";
            this.date_four.Size = new System.Drawing.Size(200, 20);
            this.date_four.TabIndex = 0;
            this.date_four.MouseDown += new System.Windows.Forms.MouseEventHandler(this.date_four_MouseDown);
            this.date_four.MouseMove += new System.Windows.Forms.MouseEventHandler(this.date_four_MouseMove);
            this.date_four.MouseUp += new System.Windows.Forms.MouseEventHandler(this.date_four_MouseUp);
            // 
            // pb_progress
            // 
            this.pb_progress.BackColor = System.Drawing.SystemColors.Control;
            this.pb_progress.Location = new System.Drawing.Point(12, 472);
            this.pb_progress.Maximum = 500;
            this.pb_progress.Name = "pb_progress";
            this.pb_progress.Size = new System.Drawing.Size(917, 23);
            this.pb_progress.TabIndex = 1;
            // 
            // web_browser
            // 
            this.web_browser.Location = new System.Drawing.Point(345, 12);
            this.web_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_browser.Name = "web_browser";
            this.web_browser.Size = new System.Drawing.Size(584, 451);
            this.web_browser.TabIndex = 2;
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(12, 132);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(234, 20);
            this.tb_input.TabIndex = 3;
            this.tb_input.Text = "https://yandex.ru";
            // 
            // bt_input
            // 
            this.bt_input.Location = new System.Drawing.Point(252, 132);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(75, 23);
            this.bt_input.TabIndex = 4;
            this.bt_input.Text = "Input";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // FormFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 505);
            this.Controls.Add(this.bt_input);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.web_browser);
            this.Controls.Add(this.pb_progress);
            this.Controls.Add(this.date_four);
            this.Name = "FormFour";
            this.Text = "FormFour";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormFour_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_four;
        private System.Windows.Forms.ProgressBar pb_progress;
        private System.Windows.Forms.WebBrowser web_browser;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button bt_input;
    }
}