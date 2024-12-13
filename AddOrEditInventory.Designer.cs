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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(139, 50, 44);
            label1.Location = new Point(184, 124);
            label1.Name = "label1";
            label1.Size = new Size(246, 44);
            label1.TabIndex = 0;
            label1.Text = "Add Inventory";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxAuthor.Location = new Point(121, 171);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(279, 23);
            textBoxAuthor.TabIndex = 1;
            textBoxAuthor.Text = "Author";
            // 
            // textBoxDatePublished
            // 
            textBoxDatePublished.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxDatePublished.Location = new Point(121, 216);
            textBoxDatePublished.Name = "textBoxDatePublished";
            textBoxDatePublished.Size = new Size(279, 23);
            textBoxDatePublished.TabIndex = 2;
            textBoxDatePublished.Text = "Date Published";
            // 
            // textBoxGenre
            // 
            textBoxGenre.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxGenre.Location = new Point(121, 262);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(279, 23);
            textBoxGenre.TabIndex = 3;
            textBoxGenre.Text = "Genre";
            // 
            // textBoxISBN
            // 
            textBoxISBN.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxISBN.Location = new Point(121, 306);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(279, 23);
            textBoxISBN.TabIndex = 4;
            textBoxISBN.Text = "ISBN #";
            // 
            // textBoxDescription
            // 
            textBoxDescription.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxDescription.Location = new Point(121, 351);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(279, 23);
            textBoxDescription.TabIndex = 5;
            textBoxDescription.Text = "Description";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(139, 50, 44);
            buttonAdd.ForeColor = Color.FromArgb(234, 206, 167);
            buttonAdd.Location = new Point(211, 406);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(85, 37);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // AddOrEditInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 206, 167);
            ClientSize = new Size(540, 546);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxISBN);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxDatePublished);
            Controls.Add(textBoxAuthor);
            Controls.Add(label1);
            Name = "AddOrEditInventory";
            Text = "AddOrEditInventory";
            Load += AddOrEditInventory_Load;
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
    }
}