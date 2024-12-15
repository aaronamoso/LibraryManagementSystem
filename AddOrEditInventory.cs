using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LibraryManagementSystem
{
    public partial class AddOrEditInventory : Form
    {
        public AddOrEditInventory()
        {
            InitializeComponent();
        }

        private void AddOrEditInventory_Load(object sender, EventArgs e)
        {

        }

        private void m_downloadButton_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All Files (*.*)|*.*";


                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occcured", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Book instance
                Book newBook = new Book
                {
                    Title = textBoxTitle.Text,
                    Author = textBoxAuthor.Text,
                    ISBN = textBoxISBN.Text,
                    PublicationDate = textBoxDatePublished.Text,
                    Genre = textBoxGenre.Text,
                    Description = textBoxDescription.Text,
                    ImageName = pictureBox.Image // Assuming the Image property is correctly set
                };

                // Add the new book to the LibraryCatalogue
                LibraryCatalogue.AddBook(newBook);

                // Notify the user
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the input fields
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Clears the form fields after adding a book
        private void ClearFormFields()
        {
            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxISBN.Clear();
            textBoxDatePublished.Clear();
            textBoxGenre.Clear();
            textBoxDescription.Clear();
            pictureBox.Image = null;
        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDatePublished_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGenre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
