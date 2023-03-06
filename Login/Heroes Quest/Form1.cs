using Login;

namespace Heroes_Quest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //login button
        private void button1_Click(object sender, EventArgs e)
        {
            string lc_name = txtUser.Text;
            string lc_password = txtPassword.Text;

            DatabaseAccessObject dbaccess = new DatabaseAccessObject();
            if (string.IsNullOrEmpty(lc_name) || string.IsNullOrEmpty(lc_password))
            {
                MessageBox.Show("Missing input from one or more fields.");
            }
            else if (dbaccess.CheckUsernameAndPassword(lc_name, lc_password))
            {
                MessageBox.Show("User logged in.");
            } 
            else
            {
                MessageBox.Show("incorrect details.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}