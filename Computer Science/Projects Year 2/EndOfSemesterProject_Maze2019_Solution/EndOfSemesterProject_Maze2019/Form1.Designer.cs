namespace EndOfSemesterProject_Maze2019
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
            this.End = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // End
            // 
            this.End.BackColor = System.Drawing.SystemColors.Control;
            this.End.Location = new System.Drawing.Point(575, 418);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(40, 40);
            this.End.TabIndex = 0;
            this.End.Text = "End";
            this.End.UseVisualStyleBackColor = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(613, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 476);
            this.panel1.TabIndex = 1;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(-51, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1274, 27);
            this.panel2.TabIndex = 2;
            this.panel2.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 1284);
            this.panel3.TabIndex = 3;
            this.panel3.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(12, 936);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1250, 45);
            this.panel4.TabIndex = 0;
            this.panel4.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(1220, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 1000);
            this.panel5.TabIndex = 0;
            this.panel5.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.TimerEventProcessor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SpringGreen;
            this.panel6.Cursor = System.Windows.Forms.Cursors.No;
            this.panel6.Location = new System.Drawing.Point(551, 397);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(78, 80);
            this.panel6.TabIndex = 1;
            this.panel6.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // radioButton1
            // 
            this.radioButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(593, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 200);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Location = new System.Drawing.Point(86, 117);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(529, 77);
            this.panel7.TabIndex = 0;
            this.panel7.Visible = false;
            this.panel7.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel10.Location = new System.Drawing.Point(592, 117);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(20, 24);
            this.panel10.TabIndex = 9;
            this.panel10.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightCoral;
            this.panel8.Location = new System.Drawing.Point(22, 140);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(20, 24);
            this.panel8.TabIndex = 7;
            this.panel8.Visible = false;
            this.panel8.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(593, 200);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Location = new System.Drawing.Point(87, 219);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(528, 38);
            this.panel9.TabIndex = 0;
            this.panel9.Visible = false;
            this.panel9.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightCoral;
            this.panel11.Location = new System.Drawing.Point(22, 219);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(21, 34);
            this.panel11.TabIndex = 0;
            this.panel11.Visible = false;
            this.panel11.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightCoral;
            this.panel12.Location = new System.Drawing.Point(70, 189);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(21, 34);
            this.panel12.TabIndex = 1;
            this.panel12.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1165, 954);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.End);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel12;
    }
}

