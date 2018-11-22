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

namespace FinalExam
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
            //password_txt.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Calling check method
            CheckForCorrect();

        }//LoginButton

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//CancelButton

        #region Reading from a file
        //public void ReadingFromFile()
        //{
        //    FileStream file = new FileStream(@"C:\College\COMP 123\Final\FinalExam\FinalExam\userpass.txt", FileMode.Open, FileAccess.Read);
        //
        //    StreamReader reader = new StreamReader(file);
        //    const char Delim = ',';
        //    string data = reader.ToString();
        //
        //    string[] field = data.Split(Delim);
        //    
        //}//ReadingFromFile
        #endregion

        public void Disable()
        {
            password_txt.Clear();
            username_txt.Clear();
            button1.Enabled = false;
        }

        public void Clear()
        {
            password_txt.Clear();
            username_txt.Clear();
        }

        public void CheckForCorrect()
        {
            string filePath = "userpass.txt";
            //Reading File Info:
            FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(file);
            const char Delim = ',';
            string data = reader.ReadToEnd();

            string[] field = data.Split(Delim);

            reader.Close();
            file.Close();

            //Unnecessary Step
            //StringConversion
            string username = field[0];
            string password = field[1];

            //Authenticating
            int tries = 1;
            //while (tries <= 3)
            //{
            if (username_txt.Text == username && password_txt.Text == password && tries <= 3)
            {
                this.Hide();
                DatEntryForm form = new DatEntryForm();
                form.Show();
            }//if
            else
            {
                if (tries <= 3)
                {
                    output_lbl.Text = "Username or Password are incorrect!";
                    tries++;
                    Clear();
                }

                else
                {
                    output_lbl.Text = "Your account is locked!";
                    Disable();
                }//3rd tries
            }//else
            //}//while
            //output_lbl.Text = "Your account is locked!";

        }//Authentication

        private void passwordShow_Click(object sender, EventArgs e)
        {
            password_txt.PasswordChar = default(char);
        }//ShowPasswordButton

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            password_txt.PasswordChar = default(char);
        }
    }//Form class
}
