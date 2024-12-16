using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    //Information that pops up when an individual book is selected from the library catalogue
    public partial class BookDetails : Form
    {
        public BookDetails(Book book)
        {
            InitializeComponent();
            DisplayBookDetails(book);
        }

        private void DisplayBookDetails(Book book)
        {
            //Controls that allow book details to be displayed on the form when book is selected from library catalogue
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

