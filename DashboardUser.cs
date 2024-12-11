using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class DashboardUser : Form
    {
        private List<Book> books;

        public DashboardUser()
        {
            InitializeComponent();
            books = LibraryCatalogue.GetBooks();
            lbLibraryCatalogue.DataSource = books.ToList();
            lbLibraryCatalogue.DisplayMember = "Title";
            lbLibraryCatalogue.MouseDoubleClick += lbLibraryCatalogue_MouseDoubleClick;
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
