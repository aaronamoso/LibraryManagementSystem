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
        //private TextBox txtSearch;

        // public DashboardUser()
        //{
        //  InitializeComponent();
        //books = LibraryCatalogue.GetBooks();
        //borrowedBooks = new List<Book>();

        private string currentUser;
        private static Dictionary<string, List<BorrowedBookInfo>> allBorrowedBooks;

        public DashboardUser(string username)
        {
            InitializeComponent();
            currentUser = username;
            books = LibraryCatalogue.GetBooks();
            borrowedBooks = new List<Book>();
            allBorrowedBooks = BookPersistence.LoadBorrowedBooks();

            if (allBorrowedBooks.ContainsKey(currentUser))
            {
                foreach (var borrowedInfo in allBorrowedBooks[currentUser])
                {
                    var book = books.Find(b => b.ISBN == borrowedInfo.ISBN);
                    if (book != null)
                    {
                        book.IsBorrowed = true;
                        book.DueDate = borrowedInfo.DueDate;
                        borrowedBooks.Add(book);
                    }
                }
            }



            catalogueBinding = new BindingSource();
            catalogueBinding.DataSource = books;
            borrowedBooksBinding = new BindingSource();
            borrowedBooksBinding.DataSource = borrowedBooks;

            lbLibraryCatalogue.DataSource = catalogueBinding;
            //Displays book title and available or borrowed status
            lbLibraryCatalogue.DisplayMember = "ToString";
            lbLibraryCatalogue.MouseDoubleClick += lbLibraryCatalogue_MouseDoubleClick;

            lbBorrowedItems.DataSource = borrowedBooksBinding;
            lbBorrowedItems.DisplayMember = "ToString";

            btnBorrow.Click += btnBorrow_Click;
            btnReturn.Click += btnReturn_Click;
            btnClear.Click += btnClear_Click;

            btnLogout.Click += btnLogout_Click;

            //Search textbox
            txtSearchCatalogue.TextChanged += TxtSearchCatalogue_TextChanged;

            // Add search textbox
            //txtSearch = new TextBox();
            //txtSearch.Location = new Point(lbLibraryCatalogue.Left, lbLibraryCatalogue.Top - 30);
            //txtSearch.Width = lbLibraryCatalogue.Width;
            //txtSearch.TextChanged += TxtSearch_TextChanged;
            //this.Controls.Add(txtSearch);

            // Add borrow button
            //Button btnBorrow = new Button();
            //btnBorrow.Text = "Borrow Selected Book";
            //btnBorrow.Location = new Point(lbLibraryCatalogue.Right + 10, lbLibraryCatalogue.Top);
            //btnBorrow.Click += btnBorrow_Click;
            //this.Controls.Add(btnBorrow);
        }

        private void TxtSearchCatalogue_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchCatalogue.Text.ToLower();
            {
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    catalogueBinding.DataSource = books;
                }
                else
                {
                    List<Book> filteredBooks = books.Where(b =>
                        b.Title.ToLower().Contains(searchText) ||
                        b.Author.ToLower().Contains(searchText) ||
                        b.Genre.ToLower().Contains(searchText)).ToList();
                    catalogueBinding.DataSource = filteredBooks;
                }
                catalogueBinding.ResetBindings(false);
            }
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
                if (!allBorrowedBooks.ContainsKey(currentUser))
                {
                    allBorrowedBooks[currentUser] = new List<BorrowedBookInfo>();
                }
                allBorrowedBooks[currentUser].Add(new BorrowedBookInfo { ISBN = selectedBook.ISBN, DueDate = selectedBook.DueDate.Value });
                BookPersistence.SaveBorrowedBooks(allBorrowedBooks);
              
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
                if (allBorrowedBooks.ContainsKey(currentUser))
                {
                    allBorrowedBooks[currentUser].RemoveAll(b => b.ISBN == bookToReturn.ISBN);
                    BookPersistence.SaveBorrowedBooks(allBorrowedBooks);
                }
                borrowedBooksBinding.ResetBindings(false);
                MessageBox.Show("Book returned successfully!");
            }
            else
            {
                MessageBox.Show("Please select a book to return.");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchCatalogue.Clear();
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

    }
}
