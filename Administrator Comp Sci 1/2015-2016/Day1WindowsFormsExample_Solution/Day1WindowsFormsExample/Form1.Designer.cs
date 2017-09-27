namespace Day1WindowsFormsExample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bear = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Flower = new System.Windows.Forms.PictureBox();
            this.Knucklehead = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(432, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "My LAbel";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bear
            // 
            this.Bear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bear.BackgroundImage")));
            this.Bear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bear.InitialImage = ((System.Drawing.Image)(resources.GetObject("Bear.InitialImage")));
            this.Bear.Location = new System.Drawing.Point(32, 318);
            this.Bear.Name = "Bear";
            this.Bear.Size = new System.Drawing.Size(267, 202);
            this.Bear.TabIndex = 2;
            this.Bear.TabStop = false;
            this.Bear.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "This",
            "Next",
            "Haha",
            "No Way",
            "Knucklehead"});
            this.comboBox1.Location = new System.Drawing.Point(72, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Flower
            // 
            this.Flower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Flower.BackgroundImage")));
            this.Flower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Flower.Cursor = System.Windows.Forms.Cursors.Default;
            this.Flower.InitialImage = ((System.Drawing.Image)(resources.GetObject("Flower.InitialImage")));
            this.Flower.Location = new System.Drawing.Point(400, 318);
            this.Flower.Name = "Flower";
            this.Flower.Size = new System.Drawing.Size(244, 202);
            this.Flower.TabIndex = 4;
            this.Flower.TabStop = false;
            this.Flower.Click += new System.EventHandler(this.Flower_Click);
            // 
            // Knucklehead
            // 
            this.Knucklehead.Location = new System.Drawing.Point(197, 23);
            this.Knucklehead.Name = "Knucklehead";
            this.Knucklehead.Size = new System.Drawing.Size(208, 53);
            this.Knucklehead.TabIndex = 5;
            this.Knucklehead.Text = "Knucklehead";
            this.Knucklehead.UseVisualStyleBackColor = true;
            this.Knucklehead.Click += new System.EventHandler(this.Hello_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(445, 126);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(46, 171);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(191, 118);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Yeah\nal;kdfj\nasd;lkfjase;lkf\n\'adsfka;lkdsjf";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Knucklehead);
            this.Controls.Add(this.Flower);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Bear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Bear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Bear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox Flower;
        private System.Windows.Forms.Button Knucklehead;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

