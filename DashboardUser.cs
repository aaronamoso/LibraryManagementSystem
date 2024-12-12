using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class DashboardUser : Form
    {
        private List<Book> books;
        private List<Book> borrowedBooks;
        private BindingSource catalogueBinding;
        private BindingSource borrowedBooksBinding;
        private TextBox txtSearch;

        public DashboardUser()
        {
            InitializeComponent();
            books = LibraryCatalogue.GetBooks();
            borrowedBooks = new List<Book>();

            catalogueBinding = new BindingSource();
            catalogueBinding.DataSource = books;
            borrowedBooksBinding = new BindingSource();
            borrowedBooksBinding.DataSource = borrowedBooks;

            lbLibraryCatalogue.DataSource = catalogueBinding;
            lbLibraryCatalogue.DisplayMember = "Title";
            lbLibraryCatalogue.MouseDoubleClick += lbLibraryCatalogue_MouseDoubleClick;

            lbBorrowedItems.DataSource = borrowedBooksBinding;
            lbBorrowedItems.DisplayMember = "ToString";

            btnBorrow.Click += btnBorrow_Click;
            btnReturn.Click += btnReturn_Click;

            // Add search textbox
            txtSearch = new TextBox();
            txtSearch.Location = new Point(lbLibraryCatalogue.Left, lbLibraryCatalogue.Top - 30);
            txtSearch.Width = lbLibraryCatalogue.Width;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            this.Controls.Add(txtSearch);

            // Add borrow button
            //Button btnBorrow = new Button();
            //btnBorrow.Text = "Borrow Selected Book";
            //btnBorrow.Location = new Point(lbLibraryCatalogue.Right + 10, lbLibraryCatalogue.Top);
            //btnBorrow.Click += btnBorrow_Click;
            //this.Controls.Add(btnBorrow);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                catalogueBinding.DataSource = books;
            }
            else
            {
                var filteredBooks = books.Where(b =>
                    b.Title.ToLower().Contains(searchText) ||
                    b.Author.ToLower().Contains(searchText)).ToList();
                catalogueBinding.DataSource = filteredBooks;
            }
            catalogueBinding.ResetBindings(false);
        }

        public void btnBorrow_Click(object sender, EventArgs e)
        {
            //if (lbLibraryCatalogue.SelectedItem is Book selectedBook && !selectedBook.IsBorrowed)
                Book selectedBook = lbLibraryCatalogue.SelectedItem as Book;
            if (selectedBook != null && !selectedBook.IsBorrowed)
            {
                selectedBook.IsBorrowed = true;
                selectedBook.DueDate = DateTime.Now.AddDays(14); // 2-week loan period
                borrowedBooks.Add(selectedBook);
                borrowedBooksBinding.ResetBindings(false);
                MessageBox.Show($"Book borrowed successfully! Due date: {selectedBook.DueDate.Value.ToShortDateString()}");
            }
            else if (selectedBook?.IsBorrowed ?? false)
            {
                MessageBox.Show("This book is already borrowed.");
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lbBorrowedItems.SelectedItem is Book bookToReturn)
            {
                borrowedBooks.Remove(bookToReturn);
                bookToReturn.IsBorrowed = false;
                bookToReturn.DueDate = null;
                borrowedBooksBinding.ResetBindings(false);
                MessageBox.Show("Book returned successfully!");
            }
            else
            {
                MessageBox.Show("Please select a book to return.");
            }
        }


        private void lbLibraryCatalogue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbLibraryCatalogue.SelectedItem is Book selectedBook)
            {
                var bookDetails = new BookDetails(selectedBook);
                bookDetails.Show();
            }
        }
    }
}
