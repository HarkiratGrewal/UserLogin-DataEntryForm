namespace FinalExam
{
    partial class DatEntryForm
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
            this.exit_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.employeeId_txt = new System.Windows.Forms.TextBox();
            this.employeeId_lbl = new System.Windows.Forms.Label();
            this.lastName_txt = new System.Windows.Forms.TextBox();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(569, 232);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(97, 41);
            this.exit_btn.TabIndex = 17;
            this.exit_btn.Text = "&Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(331, 232);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(97, 41);
            this.clear_btn.TabIndex = 16;
            this.clear_btn.Text = "&Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(68, 232);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(97, 41);
            this.save_btn.TabIndex = 15;
            this.save_btn.Text = "&Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // employeeId_txt
            // 
            this.employeeId_txt.Location = new System.Drawing.Point(208, 123);
            this.employeeId_txt.Name = "employeeId_txt";
            this.employeeId_txt.Size = new System.Drawing.Size(100, 31);
            this.employeeId_txt.TabIndex = 14;
            // 
            // employeeId_lbl
            // 
            this.employeeId_lbl.AutoSize = true;
            this.employeeId_lbl.Location = new System.Drawing.Point(63, 129);
            this.employeeId_lbl.Name = "employeeId_lbl";
            this.employeeId_lbl.Size = new System.Drawing.Size(139, 25);
            this.employeeId_lbl.TabIndex = 13;
            this.employeeId_lbl.Text = "Employee ID:";
            // 
            // lastName_txt
            // 
            this.lastName_txt.Location = new System.Drawing.Point(566, 49);
            this.lastName_txt.Name = "lastName_txt";
            this.lastName_txt.Size = new System.Drawing.Size(100, 31);
            this.lastName_txt.TabIndex = 12;
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.AutoSize = true;
            this.lastName_lbl.Location = new System.Drawing.Point(449, 49);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(115, 25);
            this.lastName_lbl.TabIndex = 11;
            this.lastName_lbl.Text = "LastName:";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(208, 40);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 31);
            this.name_txt.TabIndex = 10;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(63, 43);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(74, 25);
            this.name_lbl.TabIndex = 9;
            this.name_lbl.Text = "Name:";
            // 
            // DatEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 314);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.employeeId_txt);
            this.Controls.Add(this.employeeId_lbl);
            this.Controls.Add(this.lastName_txt);
            this.Controls.Add(this.lastName_lbl);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.name_lbl);
            this.Name = "DatEntryForm";
            this.Text = "DatEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox employeeId_txt;
        private System.Windows.Forms.Label employeeId_lbl;
        private System.Windows.Forms.TextBox lastName_txt;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label name_lbl;
    }
}