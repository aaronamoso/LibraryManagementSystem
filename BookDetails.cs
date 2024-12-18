﻿using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    //Information that pops up when an individual book is selected from the library catalogue
    public partial class BookDetails : Form
    {
        private Book _currentBook; // Define the variable to hold the current book object
        public BookDetails(Book book)
        {
            InitializeComponent();
            _currentBook = book; // Initialize _currentBook with the passed book
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // I want this block of code to edit or to be able to modify the texts and Image when its clicked

            // Open the EditInventory form
            EditInventory editForm = new EditInventory(_currentBook);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh the book details after editing
                DisplayBookDetails(_currentBook);
                MessageBox.Show("Book details updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

