namespace LibraryManagementSystem
{
    partial class BookDetails
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
            lblBookName = new Label();
            pbBookCover = new PictureBox();
            label1 = new Label();
            lblAuthor = new Label();
            label2 = new Label();
            lblPublished = new Label();
            label4 = new Label();
            lblGenre = new Label();
            label3 = new Label();
            lblDescription = new Label();
            labelISBN = new Label();
            lblISBN = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBookCover).BeginInit();
            SuspendLayout();
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.Location = new Point(46, 25);
            lblBookName.Margin = new Padding(2, 0, 2, 0);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(124, 32);
            lblBookName.TabIndex = 0;
            lblBookName.Text = "Book title";
            // 
            // pbBookCover
            // 
            pbBookCover.BorderStyle = BorderStyle.Fixed3D;
            pbBookCover.Location = new Point(46, 71);
            pbBookCover.Margin = new Padding(2, 2, 2, 2);
            pbBookCover.Name = "pbBookCover";
            pbBookCover.Size = new Size(165, 163);
            pbBookCover.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBookCover.TabIndex = 1;
            pbBookCover.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 71);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 2;
            label1.Text = "Author:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F);
            lblAuthor.Location = new Point(358, 71);
            lblAuthor.Margin = new Padding(2, 0, 2, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(101, 21);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "Author name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 115);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 4;
            label2.Text = "Published:";
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Font = new Font("Segoe UI", 12F);
            lblPublished.Location = new Point(358, 115);
            lblPublished.Margin = new Padding(2, 0, 2, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(114, 21);
            lblPublished.TabIndex = 5;
            lblPublished.Text = "Date published";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(239, 157);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 6;
            label4.Text = "Genre:";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 12F);
            lblGenre.Location = new Point(358, 157);
            lblGenre.Margin = new Padding(2, 0, 2, 0);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(52, 21);
            lblGenre.TabIndex = 7;
            lblGenre.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 262);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 8;
            label3.Text = "Description:";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.Location = new Point(170, 262);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(330, 96);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Brief description of the book";
            // 
            // labelISBN
            // 
            labelISBN.AutoSize = true;
            labelISBN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelISBN.Location = new Point(239, 202);
            labelISBN.Margin = new Padding(2, 0, 2, 0);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(51, 21);
            labelISBN.TabIndex = 10;
            labelISBN.Text = "ISBN:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 12F);
            lblISBN.Location = new Point(358, 202);
            lblISBN.Margin = new Padding(2, 0, 2, 0);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(57, 21);
            lblISBN.TabIndex = 11;
            lblISBN.Text = "ISBN #";
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 206, 167);
            ClientSize = new Size(531, 434);
            Controls.Add(lblISBN);
            Controls.Add(labelISBN);
            Controls.Add(lblDescription);
            Controls.Add(label3);
            Controls.Add(lblGenre);
            Controls.Add(label4);
            Controls.Add(lblPublished);
            Controls.Add(label2);
            Controls.Add(lblAuthor);
            Controls.Add(label1);
            Controls.Add(pbBookCover);
            Controls.Add(lblBookName);
            ForeColor = Color.FromArgb(139, 50, 44);
            Margin = new Padding(2, 2, 2, 2);
            Name = "BookDetails";
            Text = "BookDetails";
            ((System.ComponentModel.ISupportInitialize)pbBookCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookName;
        private PictureBox pbBookCover;
        private Label label1;
        private Label lblAuthor;
        private Label label2;
        private Label lblPublished;
        private Label label4;
        private Label lblGenre;
        private Label label3;
        private Label lblDescription;
        private Label labelISBN;
        private Label lblISBN;
    }
}