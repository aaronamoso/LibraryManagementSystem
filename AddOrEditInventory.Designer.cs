namespace LibraryManagementSystem
{
    partial class AddOrEditInventory
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
            textBoxAuthor = new TextBox();
            textBoxDatePublished = new TextBox();
            textBoxGenre = new TextBox();
            textBoxISBN = new TextBox();
            textBoxDescription = new TextBox();
            buttonAdd = new Button();
            lbLibraryCatalogue = new ListBox();
            label2 = new Label();
            btnEdit = new Button();
            txtSearchCatalogue = new TextBox();
            textBoxBookName = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(139, 50, 44);
            label1.Location = new Point(121, 130);
            label1.Name = "label1";
            label1.Size = new Size(175, 38);
            label1.TabIndex = 0;
            label1.Text = "Add Inventory";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxAuthor.Location = new Point(255, 201);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(145, 23);
            textBoxAuthor.TabIndex = 1;
            textBoxAuthor.Text = "Author";
            // 
            // textBoxDatePublished
            // 
            textBoxDatePublished.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxDatePublished.Location = new Point(255, 230);
            textBoxDatePublished.Name = "textBoxDatePublished";
            textBoxDatePublished.Size = new Size(145, 23);
            textBoxDatePublished.TabIndex = 2;
            textBoxDatePublished.Text = "Date Published";
            // 
            // textBoxGenre
            // 
            textBoxGenre.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxGenre.Location = new Point(255, 259);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(145, 23);
            textBoxGenre.TabIndex = 3;
            textBoxGenre.Text = "Genre";
            // 
            // textBoxISBN
            // 
            textBoxISBN.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxISBN.Location = new Point(121, 288);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(279, 23);
            textBoxISBN.TabIndex = 4;
            textBoxISBN.Text = "ISBN #";
            // 
            // textBoxDescription
            // 
            textBoxDescription.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxDescription.Location = new Point(121, 317);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(279, 23);
            textBoxDescription.TabIndex = 5;
            textBoxDescription.Text = "Description";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(139, 50, 44);
            buttonAdd.ForeColor = Color.FromArgb(234, 206, 167);
            buttonAdd.Location = new Point(315, 124);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(85, 37);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // lbLibraryCatalogue
            // 
            lbLibraryCatalogue.FormattingEnabled = true;
            lbLibraryCatalogue.ItemHeight = 15;
            lbLibraryCatalogue.Location = new Point(448, 200);
            lbLibraryCatalogue.Name = "lbLibraryCatalogue";
            lbLibraryCatalogue.Size = new Size(279, 139);
            lbLibraryCatalogue.TabIndex = 7;
            lbLibraryCatalogue.MouseDoubleClick += listListCatalogue_MouseDoubleClick;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(139, 50, 44);
            label2.Location = new Point(448, 130);
            label2.Name = "label2";
            label2.Size = new Size(297, 44);
            label2.TabIndex = 8;
            label2.Text = "Inventory List";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(139, 50, 44);
            btnEdit.ForeColor = Color.FromArgb(234, 206, 167);
            btnEdit.Location = new Point(642, 124);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 37);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtSearchCatalogue
            // 
            txtSearchCatalogue.Location = new Point(448, 171);
            txtSearchCatalogue.Name = "txtSearchCatalogue";
            txtSearchCatalogue.Size = new Size(279, 23);
            txtSearchCatalogue.TabIndex = 10;
            txtSearchCatalogue.Text = "Search";
            txtSearchCatalogue.TextChanged += TxtSearchCatalogue_TextChanged;
            // 
            // textBoxBookName
            // 
            textBoxBookName.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxBookName.Location = new Point(255, 172);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(145, 23);
            textBoxBookName.TabIndex = 11;
            textBoxBookName.Text = "Book Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 171);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 111);
            textBox1.TabIndex = 12;
            // 
            // AddOrEditInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 206, 167);
            ClientSize = new Size(835, 460);
            Controls.Add(textBox1);
            Controls.Add(textBoxBookName);
            Controls.Add(txtSearchCatalogue);
            Controls.Add(btnEdit);
            Controls.Add(label2);
            Controls.Add(lbLibraryCatalogue);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxISBN);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxDatePublished);
            Controls.Add(textBoxAuthor);
            Controls.Add(label1);
            Name = "AddOrEditInventory";
            Text = "AddOrEditInventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAuthor;
        private TextBox textBoxDatePublished;
        private TextBox textBoxGenre;
        private TextBox textBoxISBN;
        private TextBox textBoxDescription;
        private Button buttonAdd;
        private ListBox lbLibraryCatalogue;
        private Label label2;
        private Button btnEdit;
        private TextBox txtSearchCatalogue;
        private TextBox textBoxBookName;
        private TextBox textBox1;
    }
}