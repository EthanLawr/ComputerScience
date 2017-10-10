namespace WindowsFormsApplication2
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
            this.mytextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.MyTextbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mytextbox
            // 
            this.mytextbox.Location = new System.Drawing.Point(38, 39);
            this.mytextbox.Name = "mytextbox";
            this.mytextbox.Size = new System.Drawing.Size(100, 20);
            this.mytextbox.TabIndex = 0;
            this.mytextbox.Text = "Mytext";
            this.mytextbox.TextChanged += new System.EventHandler(this.mytextbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(46, 97);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(67, 13);
            this.DisplayLabel.TabIndex = 2;
            this.DisplayLabel.Text = "DisplayLabel";
            this.DisplayLabel.Visible = false;
            this.DisplayLabel.Click += new System.EventHandler(this.DisplayLabel_Click);
            // 
            // MyTextbox2
            // 
            this.MyTextbox2.Location = new System.Drawing.Point(38, 65);
            this.MyTextbox2.Name = "MyTextbox2";
            this.MyTextbox2.Size = new System.Drawing.Size(95, 20);
            this.MyTextbox2.TabIndex = 3;
            this.MyTextbox2.Text = "Mytext2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.MyTextbox2);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mytextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mytextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.TextBox MyTextbox2;
    }
}

