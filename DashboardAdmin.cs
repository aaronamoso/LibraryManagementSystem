using System;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem
{
    public partial class DashboardAdmin : Form
    {
        private List<Book> books;
        private List<Book> borrowedBooks;
        private BindingSource catalogueBinding;
        private BindingSource borrowedBooksBinding;
        public DashboardAdmin()
        {
            // Call to method is OK, just not definition
            InitializeComponent();
            books = LibraryCatalogue.GetBooks();

            catalogueBinding = new BindingSource();
            catalogueBinding.DataSource = books;

            lbLibraryCatalogue.DataSource = catalogueBinding;
            lbLibraryCatalogue.DisplayMember = "Title";

            // SEARCH BAR
            lbLibraryCatalogue.MouseDoubleClick += lbLibraryCatalogue_MouseDoubleClick;
            // LOGOUT
            btnLogout.Click += btnLogout_Click;
        }

        private void btnAddOrEditInventory_Click(object sender, EventArgs e)
        {
            //Navigate the edit button from DashboardAdmin to AddOrEditInventory.
            AddOrEditInventory addOrEditInventory = new AddOrEditInventory(); // creates an instance

            addOrEditInventory.Show(); //shows the form
        }

       
        private void lbLibraryCatalogue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbLibraryCatalogue.SelectedItem is Book selectedBook)
            {
                var bookDetails = new BookDetails(selectedBook);
                bookDetails.Show();
            }
        }
            btnLogout.Click += btnLogout_Click;
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //When user clicks the Logout button, first shows them a message asking for confirmation:
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                "Logout Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //If the user says yes to the confirmation message, this hides the current form
                this.Hide();

                //And brings the user back to the homepage login screen
                Form Login = new Login();
                Login.Show();

                //Lastly, closes the user dashboard upon logout
                this.Close();
            }
        }
    }
}