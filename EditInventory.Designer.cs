namespace LibraryManagementSystem
{
    partial class EditInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEdit = new Button();
            textBoxDescriptionEdit = new TextBox();
            textBoxISBNEdit = new TextBox();
            textBoxGenreEdit = new TextBox();
            textBoxDatePublishedEdit = new TextBox();
            textBoxAuthorEdit = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(139, 50, 44);
            buttonEdit.ForeColor = Color.FromArgb(234, 206, 167);
            buttonEdit.Location = new Point(261, 339);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(123, 37);
            buttonEdit.TabIndex = 13;
            buttonEdit.Text = "Submit Changes";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // textBoxDescriptionEdit
            // 
            textBoxDescriptionEdit.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxDescriptionEdit.Location = new Point(188, 296);
            textBoxDescriptionEdit.Name = "textBoxDescriptionEdit";
            textBoxDescriptionEdit.Size = new Size(279, 23);
            textBoxDescriptionEdit.TabIndex = 12;
            textBoxDescriptionEdit.Text = "Description";
            // 
            // textBoxISBNEdit
            // 
            textBoxISBNEdit.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxISBNEdit.Location = new Point(188, 248);
            textBoxISBNEdit.Name = "textBoxISBNEdit";
            textBoxISBNEdit.Size = new Size(279, 23);
            textBoxISBNEdit.TabIndex = 11;
            textBoxISBNEdit.Text = "ISBN #";
            // 
            // textBoxGenreEdit
            // 
            textBoxGenreEdit.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxGenreEdit.Location = new Point(188, 204);
            textBoxGenreEdit.Name = "textBoxGenreEdit";
            textBoxGenreEdit.Size = new Size(279, 23);
            textBoxGenreEdit.TabIndex = 10;
            textBoxGenreEdit.Text = "Genre";
            // 
            // textBoxDatePublishedEdit
            // 
            textBoxDatePublishedEdit.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxDatePublishedEdit.Location = new Point(188, 158);
            textBoxDatePublishedEdit.Name = "textBoxDatePublishedEdit";
            textBoxDatePublishedEdit.Size = new Size(279, 23);
            textBoxDatePublishedEdit.TabIndex = 9;
            textBoxDatePublishedEdit.Text = "Date Published";
            // 
            // textBoxAuthorEdit
            // 
            textBoxAuthorEdit.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxAuthorEdit.Location = new Point(188, 113);
            textBoxAuthorEdit.Name = "textBoxAuthorEdit";
            textBoxAuthorEdit.Size = new Size(279, 23);
            textBoxAuthorEdit.TabIndex = 8;
            textBoxAuthorEdit.Text = "Author";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(139, 50, 44);
            label1.Location = new Point(248, 66);
            label1.Name = "label1";
            label1.Size = new Size(156, 44);
            label1.TabIndex = 7;
            label1.Text = "Edit Inventory";
            // 
            // EditInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 206, 167);
            ClientSize = new Size(685, 450);
            Controls.Add(buttonEdit);
            Controls.Add(textBoxDescriptionEdit);
            Controls.Add(textBoxISBNEdit);
            Controls.Add(textBoxGenreEdit);
            Controls.Add(textBoxDatePublishedEdit);
            Controls.Add(textBoxAuthorEdit);
            Controls.Add(label1);
            Name = "EditInventory";
            Text = "EditInventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdit;
        private TextBox textBoxDescriptionEdit;
        private TextBox textBoxISBNEdit;
        private TextBox textBoxGenreEdit;
        private TextBox textBoxDatePublishedEdit;
        private TextBox textBoxAuthorEdit;
        private Label label1;
    }
}