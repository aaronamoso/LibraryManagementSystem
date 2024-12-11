using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookDetails : Form
    {
        public BookDetails(Book book)
        {
            InitializeComponent();
            DisplayBookDetails(book);
        }

        private void DisplayBookDetails(Book book)
        {
            // Assuming you have these controls on your form
            pbBookCover.Image = book.ImageName;
            lblBookName.Text = book.Title;
            lblAuthor.Text = book.Author;
            lblISBN.Text = book.ISBN;
            lblPublished.Text = book.PublicationDate;
            lblGenre.Text = book.Genre;
            lblDescription.Text = book.Description;
            
        }
    }
}

