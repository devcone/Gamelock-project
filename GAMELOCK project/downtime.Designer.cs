
namespace GAMELOCK_project
{
    partial class downtime
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.endtime = new System.Windows.Forms.TextBox();
            this.starttime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mondayaddtime = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.weekday = new System.Windows.Forms.Button();
            this.weekend = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.endtime);
            this.panel1.Controls.Add(this.starttime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mondayaddtime);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(276, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 99);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // endtime
            // 
            this.endtime.Location = new System.Drawing.Point(110, 35);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(72, 20);
            this.endtime.TabIndex = 7;
            this.endtime.TextChanged += new System.EventHandler(this.mondayendtime_TextChanged);
            // 
            // starttime
            // 
            this.starttime.Location = new System.Drawing.Point(110, 8);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(72, 20);
            this.starttime.TabIndex = 6;
            this.starttime.TextChanged += new System.EventHandler(this.mondaystarttime_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "end time: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Start time: ";
            // 
            // mondayaddtime
            // 
            this.mondayaddtime.BackColor = System.Drawing.Color.Black;
            this.mondayaddtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mondayaddtime.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayaddtime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mondayaddtime.Location = new System.Drawing.Point(62, 65);
            this.mondayaddtime.Name = "mondayaddtime";
            this.mondayaddtime.Size = new System.Drawing.Size(75, 26);
            this.mondayaddtime.TabIndex = 4;
            this.mondayaddtime.Text = "Add time";
            this.mondayaddtime.UseVisualStyleBackColor = false;
            this.mondayaddtime.Click += new System.EventHandler(this.mondayaddtime_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(313, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "edit times";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(12, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 37;
            this.button2.Text = "monday";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(112, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 33);
            this.button3.TabIndex = 38;
            this.button3.Text = "tuesday";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(212, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 33);
            this.button4.TabIndex = 39;
            this.button4.Text = "wednesday";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(322, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 33);
            this.button5.TabIndex = 40;
            this.button5.Text = "thursday";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(432, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 33);
            this.button6.TabIndex = 41;
            this.button6.Text = "friday";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(542, 66);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 33);
            this.button7.TabIndex = 42;
            this.button7.Text = "saturday";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(652, 66);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 33);
            this.button8.TabIndex = 43;
            this.button8.Text = "sunday";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(12, 264);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(104, 33);
            this.button9.TabIndex = 44;
            this.button9.Text = "every day";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // weekday
            // 
            this.weekday.BackColor = System.Drawing.Color.Black;
            this.weekday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weekday.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.weekday.Location = new System.Drawing.Point(122, 264);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(104, 33);
            this.weekday.TabIndex = 45;
            this.weekday.Text = "week day";
            this.weekday.UseVisualStyleBackColor = false;
            this.weekday.Click += new System.EventHandler(this.weekday_Click);
            // 
            // weekend
            // 
            this.weekend.BackColor = System.Drawing.Color.Black;
            this.weekend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weekend.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.weekend.Location = new System.Drawing.Point(232, 264);
            this.weekend.Name = "weekend";
            this.weekend.Size = new System.Drawing.Size(104, 33);
            this.weekend.TabIndex = 46;
            this.weekend.Text = "weekend";
            this.weekend.UseVisualStyleBackColor = false;
            this.weekend.Click += new System.EventHandler(this.weekend_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 60);
            this.panel2.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(127)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Downtime";
            // 
            // downtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(763, 307);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.weekend);
            this.Controls.Add(this.weekday);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "downtime";
            this.Text = "downtime";
            this.Load += new System.EventHandler(this.downtime_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox endtime;
        private System.Windows.Forms.TextBox starttime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mondayaddtime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button weekday;
        private System.Windows.Forms.Button weekend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}