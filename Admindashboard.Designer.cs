using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace LibraryManagementSystem
{
    public partial class Admindashboard : Form
    {
        private List<LibraryItem> libraryItems = new List<LibraryItem>();
        private List<UserAccount> userAccounts = new List<UserAccount>();

        private Button btnAddItem;
        private Button btnEditUser;
        private Button btnViewOverdue;
        private DataGridView dgvLibraryItems;
        private Label label1;
        private TextBox txtOutput;

        public AdminDashboard()
        {
            InitializeComponent();
            LoadTestData();
        }
        private void LoadTestData()
        {
            // Add test library items
            libraryItems.Add(new LibraryItem { Title = "Book 1", IsOverdue = false });
            libraryItems.Add(new LibraryItem { Title = "Book 2", IsOverdue = true });

            // Add test user accounts
            userAccounts.Add(new UserAccount { Name = "John Doe" });

            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            dgvLibraryItems.DataSource = null;
            dgvLibraryItems.DataSource = libraryItems.Select(x => new { x.Title, x.IsOverdue }).ToList();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            libraryItems.Add(new LibraryItem { Title = "New Book", IsOverdue = false });
            txtOutput.Text = "New item added.";
            UpdateDataGrid();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            userAccounts[0].Name = "Jane Doe";
            txtOutput.Text = "User account edited.";
        }

        private void btnViewOverdue_Click(object sender, EventArgs e)
        {
            var overdueItems = libraryItems.Where(x => x.IsOverdue).Select(x => x.Title).ToList();
            txtOutput.Text = "Overdue Items: " + string.Join(", ", overdueItems);
        }
    }

    public class LibraryItem
    {
        public string Title { get; set; }
        public bool IsOverdue { get; set; }
    }

    public class UserAccount
    {
        public string Name { get; set; }
    }


    //#region Windows Form Designer generated code

    ///// <summary>
    ///// Required method for Designer support - do not modify
    ///// the contents of this method with the code editor.
    ///// </summary>
    //private void InitializeComponent()
    //{
    //    this.components = new System.ComponentModel.Container();
    //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //    this.ClientSize = new System.Drawing.Size(800, 450);
    //    this.Text = "Admindashboard";
    //}

    //#endregion
}