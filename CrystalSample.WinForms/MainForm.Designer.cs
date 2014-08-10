namespace CrystalSample.WinForms
{
    partial class MainForm
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
            this.HelloWorlButton = new System.Windows.Forms.Button();
            this.HelloYou = new System.Windows.Forms.Button();
            this.MyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloWorlButton
            // 
            this.HelloWorlButton.Location = new System.Drawing.Point(13, 13);
            this.HelloWorlButton.Name = "HelloWorlButton";
            this.HelloWorlButton.Size = new System.Drawing.Size(75, 23);
            this.HelloWorlButton.TabIndex = 0;
            this.HelloWorlButton.Text = "HelloWorld!";
            this.HelloWorlButton.UseVisualStyleBackColor = true;
            this.HelloWorlButton.Click += new System.EventHandler(this.HelloWorlButton_Click);
            // 
            // HelloYou
            // 
            this.HelloYou.Location = new System.Drawing.Point(13, 43);
            this.HelloYou.Name = "HelloYou";
            this.HelloYou.Size = new System.Drawing.Size(75, 23);
            this.HelloYou.TabIndex = 1;
            this.HelloYou.Text = "Hello you!";
            this.HelloYou.UseVisualStyleBackColor = true;
            this.HelloYou.Click += new System.EventHandler(this.HelloYou_Click);
            // 
            // MyName
            // 
            this.MyName.Location = new System.Drawing.Point(95, 45);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(100, 20);
            this.MyName.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MyName);
            this.Controls.Add(this.HelloYou);
            this.Controls.Add(this.HelloWorlButton);
            this.Name = "MainForm";
            this.Text = "CrystalExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HelloWorlButton;
        private System.Windows.Forms.Button HelloYou;
        private System.Windows.Forms.TextBox MyName;
    }
}

