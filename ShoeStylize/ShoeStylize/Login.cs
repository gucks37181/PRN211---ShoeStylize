using Data;

namespace ShoeStylize
{
    public partial class Login : Form
    {
        public UserRepository userRepository;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userRepository = new UserRepository();
            var users = userRepository.GetAll().ToList();
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            var user = users.Where(u => u.Email == email && u.Password == password).FirstOrDefault();
            if (user != null)
            {
                string roleID = user.RoleId;
                if (roleID == "ADMIN")
                {
                    MessageBox.Show("Welcome, Admin");
                    AdminManage AdminManage = new AdminManage();
                    AdminManage.Show();
                }

                if (roleID == "PROVIDER")
                {
                    MessageBox.Show("Welcome, Provider");
                    ProviderManage ProviderManager = new ProviderManage();
                    ProviderManager.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login fail");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}