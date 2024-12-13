
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
            label1 = new Label();
            btnChangeCover = new Button();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            txtPublished = new TextBox();
            txtISBN = new TextBox();
            txtDescription = new TextBox();
            txtGenre = new TextBox();
            pbBookCover = new PictureBox();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pbBookCover).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(139, 50, 44);
            label1.Location = new Point(149, 48);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 7;
            label1.Text = "Edit Inventory";
            // 
            // btnChangeCover
            // 
            btnChangeCover.BackColor = Color.FromArgb(139, 50, 44);
            btnChangeCover.ForeColor = Color.FromArgb(234, 206, 167);
            btnChangeCover.Location = new Point(80, 215);
            btnChangeCover.Name = "btnChangeCover";
            btnChangeCover.Size = new Size(142, 30);
            btnChangeCover.TabIndex = 21;
            btnChangeCover.Text = "Change Cover";
            btnChangeCover.UseVisualStyleBackColor = false;
            //btnChangeCover.Click += buttonSaveEdit_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(228, 135);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(142, 23);
            txtAuthor.TabIndex = 22;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(228, 106);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(142, 23);
            txtBookName.TabIndex = 23;
            // 
            // txtPublished
            // 
            txtPublished.Location = new Point(228, 193);
            txtPublished.Name = "txtPublished";
            txtPublished.Size = new Size(142, 23);
            txtPublished.TabIndex = 25;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(228, 164);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(142, 23);
            txtISBN.TabIndex = 24;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(80, 251);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(290, 23);
            txtDescription.TabIndex = 27;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(228, 222);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(142, 23);
            txtGenre.TabIndex = 26;
            // 
            // pbBookCover
            // 
            pbBookCover.Location = new Point(80, 108);
            pbBookCover.Name = "pbBookCover";
            pbBookCover.Size = new Size(142, 101);
            pbBookCover.TabIndex = 28;
            pbBookCover.TabStop = false;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(139, 50, 44);
            btnSaveChanges.ForeColor = Color.FromArgb(234, 206, 167);
            btnSaveChanges.Location = new Point(80, 282);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(142, 30);
            btnSaveChanges.TabIndex = 29;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(139, 50, 44);
            btnCancel.ForeColor = Color.FromArgb(234, 206, 167);
            btnCancel.Location = new Point(228, 282);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 30);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // EditInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 206, 167);
            ClientSize = new Size(492, 428);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveChanges);
            Controls.Add(pbBookCover);
            Controls.Add(txtDescription);
            Controls.Add(txtGenre);
            Controls.Add(txtPublished);
            Controls.Add(txtISBN);
            Controls.Add(txtBookName);
            Controls.Add(txtAuthor);
            Controls.Add(btnChangeCover);
            Controls.Add(label1);
            Name = "EditInventory";
            Text = "EditInventory";
            ((System.ComponentModel.ISupportInitialize)pbBookCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Label label1;
        private PictureBox bookCoverEdit;
        private TextBox textBoxBookNameEdit;
        private TextBox textBoxDescriptionEdit;
        private TextBox textBoxISBNEdit;
        private TextBox textBoxGenreEdit;
        private TextBox textBoxDatePublishedEdit;
        private TextBox textBoxAuthorEdit;
        private Button btnChangeCover;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private TextBox txtPublished;
        private TextBox txtISBN;
        private TextBox txtDescription;
        private TextBox txtGenre;
        private PictureBox pbBookCover;
        private Button btnSaveChanges;
        private Button btnCancel;
    }
}