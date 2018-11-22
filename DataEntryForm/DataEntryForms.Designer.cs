namespace DataEntryForm
{
    partial class employeeInfo
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
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.lastName_txt = new System.Windows.Forms.TextBox();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.employeeId_txt = new System.Windows.Forms.TextBox();
            this.employeeId_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(35, 13);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(74, 25);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Name:";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(180, 10);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 31);
            this.name_txt.TabIndex = 1;
            // 
            // lastName_txt
            // 
            this.lastName_txt.Location = new System.Drawing.Point(538, 19);
            this.lastName_txt.Name = "lastName_txt";
            this.lastName_txt.Size = new System.Drawing.Size(100, 31);
            this.lastName_txt.TabIndex = 3;
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.AutoSize = true;
            this.lastName_lbl.Location = new System.Drawing.Point(421, 19);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(115, 25);
            this.lastName_lbl.TabIndex = 2;
            this.lastName_lbl.Text = "LastName:";
            // 
            // employeeId_txt
            // 
            this.employeeId_txt.Location = new System.Drawing.Point(180, 93);
            this.employeeId_txt.Name = "employeeId_txt";
            this.employeeId_txt.Size = new System.Drawing.Size(100, 31);
            this.employeeId_txt.TabIndex = 5;
            // 
            // employeeId_lbl
            // 
            this.employeeId_lbl.AutoSize = true;
            this.employeeId_lbl.Location = new System.Drawing.Point(35, 99);
            this.employeeId_lbl.Name = "employeeId_lbl";
            this.employeeId_lbl.Size = new System.Drawing.Size(139, 25);
            this.employeeId_lbl.TabIndex = 4;
            this.employeeId_lbl.Text = "Employee ID:";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(40, 202);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(97, 41);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "&Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(303, 202);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(97, 41);
            this.clear_btn.TabIndex = 7;
            this.clear_btn.Text = "&Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(541, 202);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(97, 41);
            this.exit_btn.TabIndex = 8;
            this.exit_btn.Text = "&Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // employeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 300);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.employeeId_txt);
            this.Controls.Add(this.employeeId_lbl);
            this.Controls.Add(this.lastName_txt);
            this.Controls.Add(this.lastName_lbl);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.name_lbl);
            this.Name = "employeeInfo";
            this.Text = "Employee Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox lastName_txt;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.TextBox employeeId_txt;
        private System.Windows.Forms.Label employeeId_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

