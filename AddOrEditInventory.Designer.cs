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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            m_downloadButton = new Button();
            pictureBox = new PictureBox();
            textBoxTitleLabel = new Label();
            textBoxTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(139, 50, 44);
            label1.Location = new Point(122, 91);
            label1.Name = "label1";
            label1.Size = new Size(171, 44);
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
            textBoxAuthor.TextChanged += textBoxAuthor_TextChanged;
            // 
            // textBoxDatePublished
            // 
            textBoxDatePublished.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxDatePublished.Location = new Point(121, 200);
            textBoxDatePublished.Name = "textBoxDatePublished";
            textBoxDatePublished.Size = new Size(279, 23);
            textBoxDatePublished.TabIndex = 2;
            textBoxDatePublished.TextChanged += textBoxDatePublished_TextChanged;
            // 
            // textBoxGenre
            // 
            textBoxGenre.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxGenre.Location = new Point(121, 229);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(279, 23);
            textBoxGenre.TabIndex = 3;
            textBoxGenre.TextChanged += textBoxGenre_TextChanged;
            // 
            // textBoxISBN
            // 
            textBoxISBN.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxISBN.Location = new Point(121, 258);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(279, 23);
            textBoxISBN.TabIndex = 4;
            textBoxISBN.TextChanged += textBoxISBN_TextChanged;
            // 
            // textBoxDescription
            // 
            textBoxDescription.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxDescription.Location = new Point(121, 287);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(279, 23);
            textBoxDescription.TabIndex = 5;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(139, 50, 44);
            buttonAdd.ForeColor = Color.FromArgb(234, 206, 167);
            buttonAdd.Location = new Point(315, 92);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(85, 37);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 174);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 7;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 232);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 203);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 9;
            label4.Text = "Date Published";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 290);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 10;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 261);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "ISBN #";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 322);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 12;
            label7.Text = "Picture Cover";
            // 
            // m_downloadButton
            // 
            m_downloadButton.BackColor = Color.FromArgb(139, 50, 44);
            m_downloadButton.ForeColor = Color.FromArgb(234, 206, 167);
            m_downloadButton.Location = new Point(122, 316);
            m_downloadButton.Name = "m_downloadButton";
            m_downloadButton.Size = new Size(92, 40);
            m_downloadButton.TabIndex = 14;
            m_downloadButton.Text = "Upload Image";
            m_downloadButton.UseVisualStyleBackColor = false;
            m_downloadButton.Click += m_downloadButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(220, 316);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(180, 152);
            pictureBox.TabIndex = 15;
            pictureBox.TabStop = false;
            // 
            // textBoxTitleLabel
            // 
            textBoxTitleLabel.AutoSize = true;
            textBoxTitleLabel.Location = new Point(72, 145);
            textBoxTitleLabel.Name = "textBoxTitleLabel";
            textBoxTitleLabel.Size = new Size(29, 15);
            textBoxTitleLabel.TabIndex = 17;
            textBoxTitleLabel.Text = "Title";
            // 
            // textBoxTitle
            // 
            textBoxTitle.ForeColor = Color.FromArgb(139, 50, 44);
            textBoxTitle.Location = new Point(122, 142);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(279, 23);
            textBoxTitle.TabIndex = 16;
            // 
            // AddOrEditInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 206, 167);
            ClientSize = new Size(491, 546);
            Controls.Add(textBoxTitleLabel);
            Controls.Add(textBoxTitle);
            Controls.Add(pictureBox);
            Controls.Add(m_downloadButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private OpenFileDialog openFileDialog1;
        private Button m_downloadButton;
        private PictureBox pictureBox;
        private Label textBoxTitleLabel;
        private TextBox textBoxTitle;
    }
}