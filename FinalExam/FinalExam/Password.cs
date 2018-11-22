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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
            password_txt.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForCorrect();
            }
            catch
            {

            }
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

        public void CheckForCorrect()
        {
            //Reading File Info:
            FileStream file = new FileStream(@"username", FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(file);
            const char Delim = ',';
            string data = reader.ToString();

            string[] field = data.Split(Delim);

            reader.Close();
            file.Close();

            //StringConversion
            string username = "Harkirat"; //field[0];
            string password = "1234"; //field[1];

            //Authenticating
            int tries = 1;
            while (tries <= 3)
            {
                if(username_txt.Text == username && password_txt.Text == password)
                {
                    this.Close();
                    FinalExam.DatEntryForm form = new DatEntryForm();
                    form.Show();
                }//if
                else
                {
                    output_lbl.Text = "Username or Password are incorrect!";
                }//else
            }//while
            output_lbl.Text = "Your account is locked!";
        }//Authentication

        private void passwordShow_Click(object sender, EventArgs e)
        {
            //password_txt = visi;
        }//ShowPasswordButton

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }//Form class
}
