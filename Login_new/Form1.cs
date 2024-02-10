namespace Login_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string user = TxtUser.Text.ToUpper(); //not case sensitive
            string password = TxtPassword.Text; //case sensitive

            //tested
            if (user == "USER" && password == "pass")
            { MessageBox.Show("Login successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show("Login Unsuccessful", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            //declare variable of form2 with new object in class
            Form2 secondForm = new Form2();

            this.Hide(); // Hides the current form

            secondForm.Show();//makes form2 appear   
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
