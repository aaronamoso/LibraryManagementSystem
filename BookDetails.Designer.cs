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
            ((System.ComponentModel.ISupportInitialize)pbBookCover).BeginInit();
            SuspendLayout();
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookName.Location = new Point(65, 41);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(115, 48);
            lblBookName.TabIndex = 0;
            lblBookName.Text = "label1";
            // 
            // pbBookCover
            // 
            pbBookCover.BorderStyle = BorderStyle.Fixed3D;
            pbBookCover.Location = new Point(65, 119);
            pbBookCover.Name = "pbBookCover";
            pbBookCover.Size = new Size(234, 269);
            pbBookCover.TabIndex = 1;
            pbBookCover.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(342, 119);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 2;
            label1.Text = "Author:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F);
            lblAuthor.Location = new Point(512, 119);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(78, 32);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(342, 174);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 4;
            label2.Text = "Published:";
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Font = new Font("Segoe UI", 12F);
            lblPublished.Location = new Point(512, 174);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(78, 32);
            lblPublished.TabIndex = 5;
            lblPublished.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(342, 225);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 6;
            label4.Text = "Genre:";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 12F);
            lblGenre.Location = new Point(512, 225);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(78, 32);
            lblGenre.TabIndex = 7;
            lblGenre.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(342, 281);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 8;
            label3.Text = "Description:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.Location = new Point(347, 325);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(78, 32);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "label5";
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 206, 167);
            ClientSize = new Size(796, 450);
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
    }
}