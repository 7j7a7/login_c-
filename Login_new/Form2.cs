using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_new
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void BtnBackToLogin_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            firstForm.Show(); // Shows the login form
        }

        private void BtnSubmit_R_Click(object sender, EventArgs e)
        {
            string user_R = TxtUser_R.Text.ToUpper(); //not case sensitive
            string password_R = TxtPassword_R.Text; //case sensitive

            //tested
            if (user_R == "USER" && password_R == "pass")
            { 
                MessageBox.Show("Registration successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(textBox2.Text == user_R && textBox1.Text == password_R) 
            { 
                MessageBox.Show("Registration successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Unable to Register", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_R_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
