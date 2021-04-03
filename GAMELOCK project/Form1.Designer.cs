
namespace GAMELOCK_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.schedule = new System.Windows.Forms.Button();
            this.downtime = new System.Windows.Forms.Button();
            this.addanapp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.downtimetimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(127)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(23, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Good evening, Toby";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // schedule
            // 
            this.schedule.BackColor = System.Drawing.Color.Transparent;
            this.schedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("schedule.BackgroundImage")));
            this.schedule.FlatAppearance.BorderSize = 0;
            this.schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schedule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.schedule.Location = new System.Drawing.Point(79, 113);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(145, 129);
            this.schedule.TabIndex = 2;
            this.schedule.UseVisualStyleBackColor = false;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // downtime
            // 
            this.downtime.BackColor = System.Drawing.Color.Transparent;
            this.downtime.FlatAppearance.BorderSize = 0;
            this.downtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downtime.Image = ((System.Drawing.Image)(resources.GetObject("downtime.Image")));
            this.downtime.Location = new System.Drawing.Point(309, 113);
            this.downtime.Name = "downtime";
            this.downtime.Size = new System.Drawing.Size(145, 129);
            this.downtime.TabIndex = 3;
            this.downtime.UseVisualStyleBackColor = false;
            this.downtime.Click += new System.EventHandler(this.downtime_Click);
            // 
            // addanapp
            // 
            this.addanapp.BackColor = System.Drawing.Color.Transparent;
            this.addanapp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addanapp.BackgroundImage")));
            this.addanapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addanapp.FlatAppearance.BorderSize = 0;
            this.addanapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addanapp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addanapp.Location = new System.Drawing.Point(553, 113);
            this.addanapp.Name = "addanapp";
            this.addanapp.Size = new System.Drawing.Size(145, 129);
            this.addanapp.TabIndex = 4;
            this.addanapp.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(79, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 129);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(310, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 129);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(553, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 129);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "DATETIME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(718, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 100);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addanapp);
            this.Controls.Add(this.downtime);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Button downtime;
        private System.Windows.Forms.Button addanapp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer downtimetimer;
    }
}

