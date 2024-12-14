using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem
{
    public partial class AddOrEditInventory : Form
    {
        private List<Book> books;
        private List<Book> borrowedBooks;
        private BindingSource catalogueBinding;
        private BindingSource borrowedBooksBinding;
        public AddOrEditInventory()
        {
            InitializeComponent();
            books = LibraryCatalogue.GetBooks();
            catalogueBinding = new BindingSource(); // instance
            catalogueBinding.DataSource = books;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // when clicked, it should take  pbBookCover.Image = book.ImageName;
            //lblBookName.Text = book.Title;
            //lblAuthor.Text = book.Author;
            //lblISBN.Text = book.ISBN;
            //lblPublished.Text = book.PublicationDate;
            //lblGenre.Text = book.Genre;
            //lblDescription.Text = book.Description;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Navigate the edit button from admin to EditInventory.
            EditInventory editInventory = new EditInventory();
            editInventory.Show();
        }

        private void listBoxInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbLibraryCatalogue.SelectedItem is Book selectedBook)
            {
                var bookDetails = new BookDetails(selectedBook);
                bookDetails.Show();

                // edit the selected book when clicked edit button.
            }
        }

        // SEARCH BAR LOGIC
        private void TxtSearchCatalogue_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchCatalogue.Text.ToLower();
            {
                if (string.IsNullOrWhiteSpace(searchText)) // CHECKS FOR ANY WHITESPACES START AND END
                {
                    catalogueBinding.DataSource = books;
                }
                else
                { // LIST INSTANCE
                    List<Book> filteredBooks = books.Where(b =>
                        b.Title.ToLower().Contains(searchText) ||
                        b.Author.ToLower().Contains(searchText) ||
                        b.Genre.ToLower().Contains(searchText)).ToList();
                    catalogueBinding.DataSource = filteredBooks;
                }
                catalogueBinding.ResetBindings(false);
            }
        }

        private void listListCatalogue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbLibraryCatalogue.SelectedItem is Book selectedBook)
            {
                var bookDetails = new BookDetails(selectedBook);
                bookDetails.Show();
            }
        }

        //private void lbLibraryCatalogue_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}



        //private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        //{

        //}

        ////private void BrowseButton_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog1 = new OpenFileDialog
        //    {
        //        InitialDirectory = @"D:\",
        //        Title = "Browse Text Files",

        //        CheckFileExists = true,
        //        CheckPathExists = true,

        //        DefaultExt = "txt",
        //        Filter = "txt files (*.txt)|*.txt",
        //        FilterIndex = 2,
        //        RestoreDirectory = true,

        //        ReadOnlyChecked = true,
        //        ShowReadOnly = true
        //    };

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        textBox1.Text = openFileDialog1.FileName;
        //    }
        //}
    }
}
