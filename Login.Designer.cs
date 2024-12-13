namespace LibraryManagementSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblStatus = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(139, 50, 44);
            btnLogin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(234, 206, 167);
            btnLogin.Location = new Point(411, 486);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(128, 66);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(468, 377);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(189, 31);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(468, 432);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 31);
            txtPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(234, 206, 167);
            lblUsername.Location = new Point(303, 374);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(139, 32);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(234, 206, 167);
            lblPassword.Location = new Point(307, 431);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(135, 32);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.FlatStyle = FlatStyle.Flat;
            lblStatus.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(234, 206, 167);
            lblStatus.Location = new Point(393, 311);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(146, 54);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Login:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(234, 206, 167);
            label1.Location = new Point(12, 149);
            label1.Name = "label1";
            label1.Size = new Size(987, 86);
            label1.TabIndex = 6;
            label1.Text = "Welcome to National Library, ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(234, 206, 167);
            label2.Location = new Point(199, 235);
            label2.Name = "label2";
            label2.Size = new Size(602, 48);
            label2.TabIndex = 7;
            label2.Text = "Please login below to get started";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 206, 167);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 610);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "National Library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblStatus;
        private Label label1;
        private Label label2;
    }
}
