using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class DashboardAdmin : Form
    {
        private List<Book> books;
        private BindingSource catalogueBinding;
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

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search term from the text box
            string searchTerm = txtBoxSearch.Text.Trim().ToLower();

            // Check if search term is empty
            if (string.IsNullOrEmpty(searchTerm))
            {
                // Reset to the full list of books
                catalogueBinding.DataSource = books;
            }
            else
            {
                // Filter the books based on the search term
                var filteredBooks = books.Where(book =>
                    book.Title.ToLower().Contains(searchTerm) ||
                    book.Author.ToLower().Contains(searchTerm) ||
                    book.ISBN.ToLower().Contains(searchTerm)
                ).ToList();

                // Update the BindingSource with the filtered list
                catalogueBinding.DataSource = filteredBooks;
            }

            // Refresh the list box
            lbLibraryCatalogue.Refresh();
        }
    }
}