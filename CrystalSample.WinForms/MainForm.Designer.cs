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
            this.People = new System.Windows.Forms.Button();
            this.Team = new System.Windows.Forms.Button();
            this.Complex = new System.Windows.Forms.Button();
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
            // People
            // 
            this.People.Location = new System.Drawing.Point(13, 73);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(75, 23);
            this.People.TabIndex = 3;
            this.People.Text = "People";
            this.People.UseVisualStyleBackColor = true;
            this.People.Click += new System.EventHandler(this.People_Click);
            // 
            // Team
            // 
            this.Team.Location = new System.Drawing.Point(13, 103);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(75, 23);
            this.Team.TabIndex = 4;
            this.Team.Text = "Team";
            this.Team.UseVisualStyleBackColor = true;
            this.Team.Click += new System.EventHandler(this.Team_Click);
            // 
            // Complex
            // 
            this.Complex.Location = new System.Drawing.Point(13, 133);
            this.Complex.Name = "Complex";
            this.Complex.Size = new System.Drawing.Size(75, 23);
            this.Complex.TabIndex = 5;
            this.Complex.Text = "Complex";
            this.Complex.UseVisualStyleBackColor = true;
            this.Complex.Click += new System.EventHandler(this.Complex_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Complex);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.People);
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
        private System.Windows.Forms.Button People;
        private System.Windows.Forms.Button Team;
        private System.Windows.Forms.Button Complex;
    }
}

