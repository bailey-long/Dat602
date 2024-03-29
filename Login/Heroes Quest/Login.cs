using Heroes_Quest;
using System.Media;
using System.Security.Cryptography.X509Certificates;

namespace Heroes_Quest
{
    public partial class Login : Form
    {
        //set starting values
        public SoundPlayer menuMusic = new SoundPlayer("C:\\Users\\fiveb\\workspace\\Dat602\\Login\\Heroes Quest\\Resources\\menuTheme.wav");
        public bool musicPlaying = true;
        public string lc_name = null;

        public string displayName;
        public Login()
        {
            InitializeComponent();
            menuMusic.Play();
        }
        //login button handler
        public void button1_Click(object sender, EventArgs e)
        {
            lc_name = txtUser.Text;
            string lc_password = txtPassword.Text;
            //validate login details
            DatabaseAccessObject dbaccess = new DatabaseAccessObject();
            if (string.IsNullOrEmpty(lc_name) || string.IsNullOrEmpty(lc_password))
            {
                MessageBox.Show("Missing input from one or more fields.");
            }
            else if (dbaccess.CheckUsernameAndPassword(lc_name, lc_password))
            {
                MessageBox.Show("User logged in.");
                //setup public display string for future windows.
                PlayerHub playerhub = new PlayerHub();
                playerhub.Show();
            }
            else
            {
                MessageBox.Show("incorrect details.");
            }
        }
        //Sign up button handler
        private void button2_Click(object sender, EventArgs e)
        {
            string lc_name = txtUser.Text;
            string lc_password = txtPassword.Text;
            //validate login details
            DatabaseAccessObject dbaccess = new DatabaseAccessObject();
            if (string.IsNullOrEmpty(lc_name) || string.IsNullOrEmpty(lc_password))
            {
                MessageBox.Show("Missing input from one or more fields.");
            }
            else if (dbaccess.CheckUsernameAndPassword(lc_name, lc_password) != true)
            {
                dbaccess.RegisterPlayer(lc_name, lc_password);
                MessageBox.Show("Account created, welcome to Hero Quest " + lc_name + "! You may now login.");
                txtUser.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("User already exists");
            }
        }
        //quit button handler
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //music button handler
        private void btn_mute_Click(object sender, EventArgs e)
        {
            if (musicPlaying)
            {
                menuMusic.Stop();
                musicPlaying = false;
                btn_mute.Text = "unmute";
            }
            else
            {
                menuMusic.Play();
                musicPlaying = true;
                btn_mute.Text = "mute";
            }
        }
    }
}