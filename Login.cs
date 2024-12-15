namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Sample user passwords
            var users = new Dictionary<string, string>
            {
                { "Thomas", "WinterSnow2024" },
                { "Miranda", "SummerRain2024" },
                { "Admin", "BadApple2023" },
            };

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (users.TryGetValue(username, out string storedPassword) && storedPassword == password)
            {
                MessageBox.Show("Welcome " + username + ", you are successfully logged in!");

                if (username == "Admin")
                {
                    //Navigate the admin to their dashboard after welcome message confirms they are successfully logged in
                    DashboardAdmin dashboardAdmin = new DashboardAdmin();
                    dashboardAdmin.Show();
                }
                else
                {
                    //Navigate the user to their user dashboard after welcome message confirms they are successfully logged in
                    DashboardUser dashboardUser = new DashboardUser(username);
                    dashboardUser.Show();
                }

                //Hides the login form 
                this.Hide();
            }
            else //Error message letting user know they have not successfully logged in due to an error in their attempt
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
