namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Initialize Components
            txtUsername = new TextBox { PlaceholderText = "Username" };
            txtPassword = new TextBox { PlaceholderText = "Password", UseSystemPasswordChar = true };
            btnLogin = new Button { Text = "Login" };
            lblStatus = new Label { AutoSize = true };
            btnLogin.Click += BtnLogin_Click;

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
