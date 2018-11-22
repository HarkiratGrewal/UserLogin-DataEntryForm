namespace FinalExam
{
    partial class Password
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
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.output_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.passwordShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(57, 82);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(116, 25);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username:";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(315, 82);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(100, 31);
            this.username_txt.TabIndex = 1;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(315, 159);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(100, 31);
            this.password_txt.TabIndex = 3;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(57, 159);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(112, 25);
            this.password_lbl.TabIndex = 2;
            this.password_lbl.Text = "Password:";
            // 
            // output_lbl
            // 
            this.output_lbl.AutoSize = true;
            this.output_lbl.Location = new System.Drawing.Point(230, 242);
            this.output_lbl.Name = "output_lbl";
            this.output_lbl.Size = new System.Drawing.Size(18, 25);
            this.output_lbl.TabIndex = 4;
            this.output_lbl.Text = ".";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // passwordShow
            // 
            this.passwordShow.Location = new System.Drawing.Point(422, 159);
            this.passwordShow.Name = "passwordShow";
            this.passwordShow.Size = new System.Drawing.Size(44, 31);
            this.passwordShow.TabIndex = 7;
            this.passwordShow.Text = "S";
            this.passwordShow.UseVisualStyleBackColor = true;
            this.passwordShow.Click += new System.EventHandler(this.passwordShow_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 438);
            this.Controls.Add(this.passwordShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output_lbl);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.username_lbl);
            this.Name = "Password";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label output_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button passwordShow;
    }
}

