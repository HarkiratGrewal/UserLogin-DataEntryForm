using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataEntryForm
{
    public partial class employeeInfo : Form
    {
        public employeeInfo()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            StoringInFile();
        }//Save button

        private void clear_btn_Click(object sender, EventArgs e)
        {
            employeeId_txt.Text = "";
            lastName_txt.Text = "";
            name_txt.Text = "";
        }//Clear

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Exit

        public void StoringInFile()
        {
            FileStream file = new FileStream(@"C:\College\COMP 123\Final\FinalExam\FinalExam\Employee.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamWriter writer = new StreamWriter(file);

            int number = 1;
            writer.WriteLine($"Employee #{number}");
            writer.WriteLine($"{name_txt.Text}, {lastName_lbl.Text}, ID:{employeeId_txt.Text}");
            number++;
        }//Storinginfile
    }
}
