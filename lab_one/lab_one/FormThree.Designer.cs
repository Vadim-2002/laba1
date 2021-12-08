
namespace lab_one
{
    partial class FormThree
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
            this.components = new System.ComponentModel.Container();
            this.bt_Start = new System.Windows.Forms.Button();
            this.bt_Pause = new System.Windows.Forms.Button();
            this.tb_sec = new System.Windows.Forms.TextBox();
            this.timer_Three = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bt_Start
            // 
            this.bt_Start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Start.Location = new System.Drawing.Point(12, 119);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(75, 23);
            this.bt_Start.TabIndex = 0;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = false;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // bt_Pause
            // 
            this.bt_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Pause.Location = new System.Drawing.Point(185, 119);
            this.bt_Pause.Name = "bt_Pause";
            this.bt_Pause.Size = new System.Drawing.Size(75, 23);
            this.bt_Pause.TabIndex = 1;
            this.bt_Pause.Text = "Pause";
            this.bt_Pause.UseVisualStyleBackColor = true;
            this.bt_Pause.Click += new System.EventHandler(this.bt_Pause_Click);
            // 
            // tb_sec
            // 
            this.tb_sec.Location = new System.Drawing.Point(87, 55);
            this.tb_sec.Name = "tb_sec";
            this.tb_sec.Size = new System.Drawing.Size(100, 26);
            this.tb_sec.TabIndex = 2;
            // 
            // timer_Three
            // 
            this.timer_Three.Interval = 1000;
            this.timer_Three.Tick += new System.EventHandler(this.timer_Three_Tick);
            // 
            // FormThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tb_sec);
            this.Controls.Add(this.bt_Pause);
            this.Controls.Add(this.bt_Start);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormThree";
            this.Text = "FormThree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Button bt_Pause;
        private System.Windows.Forms.TextBox tb_sec;
        private System.Windows.Forms.Timer timer_Three;
    }
}