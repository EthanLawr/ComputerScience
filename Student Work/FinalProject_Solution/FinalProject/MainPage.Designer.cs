namespace FinalProject
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.MessageSender = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Smile = new System.Windows.Forms.PictureBox();
            this.Frown = new System.Windows.Forms.PictureBox();
            this.Heart = new System.Windows.Forms.PictureBox();
            this.BrokenHeart = new System.Windows.Forms.PictureBox();
            this.Poop = new System.Windows.Forms.PictureBox();
            this.Laugh = new System.Windows.Forms.PictureBox();
            this.DisplayBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Smile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrokenHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laugh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comp Sci II Classic Chat Room";
            // 
            // MessageSender
            // 
            this.MessageSender.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MessageSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageSender.Location = new System.Drawing.Point(18, 523);
            this.MessageSender.Name = "MessageSender";
            this.MessageSender.Size = new System.Drawing.Size(726, 29);
            this.MessageSender.TabIndex = 6;
            this.MessageSender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageSender_KeyDown);
            // 
            // Send
            // 
            this.Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(761, 524);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(95, 27);
            this.Send.TabIndex = 7;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Smile
            // 
            this.Smile.Image = ((System.Drawing.Image)(resources.GetObject("Smile.Image")));
            this.Smile.InitialImage = null;
            this.Smile.Location = new System.Drawing.Point(18, 484);
            this.Smile.Name = "Smile";
            this.Smile.Size = new System.Drawing.Size(38, 33);
            this.Smile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Smile.TabIndex = 8;
            this.Smile.TabStop = false;
            this.Smile.Click += new System.EventHandler(this.Smile_Click);
            // 
            // Frown
            // 
            this.Frown.Image = ((System.Drawing.Image)(resources.GetObject("Frown.Image")));
            this.Frown.Location = new System.Drawing.Point(62, 484);
            this.Frown.Name = "Frown";
            this.Frown.Size = new System.Drawing.Size(38, 33);
            this.Frown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Frown.TabIndex = 9;
            this.Frown.TabStop = false;
            this.Frown.Click += new System.EventHandler(this.Frown_Click);
            // 
            // Heart
            // 
            this.Heart.Image = ((System.Drawing.Image)(resources.GetObject("Heart.Image")));
            this.Heart.Location = new System.Drawing.Point(106, 484);
            this.Heart.Name = "Heart";
            this.Heart.Size = new System.Drawing.Size(38, 33);
            this.Heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Heart.TabIndex = 10;
            this.Heart.TabStop = false;
            this.Heart.Click += new System.EventHandler(this.Heart_Click);
            // 
            // BrokenHeart
            // 
            this.BrokenHeart.Image = ((System.Drawing.Image)(resources.GetObject("BrokenHeart.Image")));
            this.BrokenHeart.Location = new System.Drawing.Point(150, 484);
            this.BrokenHeart.Name = "BrokenHeart";
            this.BrokenHeart.Size = new System.Drawing.Size(38, 33);
            this.BrokenHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BrokenHeart.TabIndex = 11;
            this.BrokenHeart.TabStop = false;
            this.BrokenHeart.Click += new System.EventHandler(this.BrokenHeart_Click);
            // 
            // Poop
            // 
            this.Poop.Image = ((System.Drawing.Image)(resources.GetObject("Poop.Image")));
            this.Poop.Location = new System.Drawing.Point(194, 484);
            this.Poop.Name = "Poop";
            this.Poop.Size = new System.Drawing.Size(38, 33);
            this.Poop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Poop.TabIndex = 12;
            this.Poop.TabStop = false;
            this.Poop.Click += new System.EventHandler(this.Poop_Click);
            // 
            // Laugh
            // 
            this.Laugh.Image = ((System.Drawing.Image)(resources.GetObject("Laugh.Image")));
            this.Laugh.Location = new System.Drawing.Point(238, 484);
            this.Laugh.Name = "Laugh";
            this.Laugh.Size = new System.Drawing.Size(38, 33);
            this.Laugh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Laugh.TabIndex = 13;
            this.Laugh.TabStop = false;
            this.Laugh.Click += new System.EventHandler(this.Laugh_Click);
            // 
            // DisplayBox
            // 
            this.DisplayBox.AcceptsReturn = true;
            this.DisplayBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DisplayBox.Location = new System.Drawing.Point(18, 68);
            this.DisplayBox.Multiline = true;
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.Size = new System.Drawing.Size(731, 410);
            this.DisplayBox.TabIndex = 14;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(875, 592);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.Laugh);
            this.Controls.Add(this.Poop);
            this.Controls.Add(this.BrokenHeart);
            this.Controls.Add(this.Heart);
            this.Controls.Add(this.Frown);
            this.Controls.Add(this.Smile);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.MessageSender);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Smile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrokenHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laugh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MessageSender;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.PictureBox Smile;
        private System.Windows.Forms.PictureBox Frown;
        private System.Windows.Forms.PictureBox Heart;
        private System.Windows.Forms.PictureBox BrokenHeart;
        private System.Windows.Forms.PictureBox Poop;
        private System.Windows.Forms.PictureBox Laugh;
        private System.Windows.Forms.TextBox DisplayBox;
    }
}