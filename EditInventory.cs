using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class EditInventory : Form
    {
        private Book _currentBook;

        public EditInventory(Book book)
        {
            InitializeComponent();
            _currentBook = book;
            PopulateFields(book);
        }

        private void PopulateFields(Book book)
        {
            // Populate TextBoxes with current book data
            txtBookName.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtISBN.Text = book.ISBN;
            txtPublished.Text = book.PublicationDate.ToString("yyyy-MM-dd");
            txtGenre.Text = book.Genre;
            txtDescription.Text = book.Description;

            // Load book cover
            pbBookCover.Image = book.ImageName;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Save changes back to the book object
            _currentBook.Title = txtBookName.Text;
            _currentBook.Author = txtAuthor.Text;
            _currentBook.ISBN = txtISBN.Text;

            if (DateTime.TryParse(txtPublished.Text, out DateTime publishedDate))
            {
                _currentBook.PublicationDate = publishedDate;
            }

            _currentBook.Genre = txtGenre.Text;
            _currentBook.Description = txtDescription.Text;

            // Close the form and return DialogResult.OK to indicate success
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnChangeCover_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    pbBookCover.ImageLocation = selectedImagePath;
                    _currentBook.ImageName = selectedImagePath; // Update the book's image path
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without saving changes
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
