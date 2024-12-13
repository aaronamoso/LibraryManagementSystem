namespace LibraryManagementSystem
{
    partial class DashboardUser
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
            lbLibraryCatalogue = new ListBox();
            label2 = new Label();
            txtSearchCatalogue = new TextBox();
            label3 = new Label();
            lbBorrowedItems = new ListBox();
            label4 = new Label();
            btnBorrow = new Button();
            btnReturn = new Button();
            btnClear = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 32);
            label1.Name = "label1";
            label1.Size = new Size(288, 48);
            label1.TabIndex = 0;
            label1.Text = "User Dashboard";
            // 
            // lbLibraryCatalogue
            // 
            lbLibraryCatalogue.FormattingEnabled = true;
            lbLibraryCatalogue.HorizontalScrollbar = true;
            lbLibraryCatalogue.ItemHeight = 25;
            lbLibraryCatalogue.Location = new Point(36, 278);
            lbLibraryCatalogue.Name = "lbLibraryCatalogue";
            lbLibraryCatalogue.Size = new Size(366, 229);
            lbLibraryCatalogue.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 237);
            label2.Name = "label2";
            label2.Size = new Size(253, 38);
            label2.TabIndex = 2;
            label2.Text = "Library catalogue:";
            // 
            // txtSearchCatalogue
            // 
            txtSearchCatalogue.Location = new Point(199, 133);
            txtSearchCatalogue.Name = "txtSearchCatalogue";
            txtSearchCatalogue.Size = new Size(463, 31);
            txtSearchCatalogue.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(199, 102);
            label3.Name = "label3";
            label3.Size = new Size(463, 28);
            label3.TabIndex = 4;
            label3.Text = "Search catalogue by book title, author or genre:";
            // 
            // lbBorrowedItems
            // 
            lbBorrowedItems.FormattingEnabled = true;
            lbBorrowedItems.ItemHeight = 25;
            lbBorrowedItems.Location = new Point(467, 278);
            lbBorrowedItems.Name = "lbBorrowedItems";
            lbBorrowedItems.Size = new Size(389, 229);
            lbBorrowedItems.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(467, 237);
            label4.Name = "label4";
            label4.Size = new Size(306, 38);
            label4.TabIndex = 6;
            label4.Text = "Your borrowed books:";
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.FromArgb(139, 50, 44);
            btnBorrow.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.ForeColor = Color.FromArgb(234, 206, 167);
            btnBorrow.Location = new Point(54, 535);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(314, 53);
            btnBorrow.TabIndex = 7;
            btnBorrow.Text = "Borrow selected book";
            btnBorrow.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(139, 50, 44);
            btnReturn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.FromArgb(234, 206, 167);
            btnReturn.Location = new Point(483, 535);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(329, 51);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "Return selected book";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(139, 50, 44);
            btnClear.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(234, 206, 167);
            btnClear.Location = new Point(372, 181);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 41);
            btnClear.TabIndex = 9;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(139, 50, 44);
            btnLogout.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(234, 206, 167);
            btnLogout.Location = new Point(363, 612);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(133, 41);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // DashboardUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 206, 167);
            ClientSize = new Size(910, 665);
            Controls.Add(btnLogout);
            Controls.Add(btnClear);
            Controls.Add(btnReturn);
            Controls.Add(btnBorrow);
            Controls.Add(label4);
            Controls.Add(lbBorrowedItems);
            Controls.Add(label3);
            Controls.Add(txtSearchCatalogue);
            Controls.Add(label2);
            Controls.Add(lbLibraryCatalogue);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(139, 50, 44);
            Name = "DashboardUser";
            Text = "National Library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbLibraryCatalogue;
        private Label label2;
        private TextBox txtSearchCatalogue;
        private Label label3;
        private ListBox lbBorrowedItems;
        private Label label4;
        private Button btnBorrow;
        private Button btnReturn;
        private Button btnClear;
        private Button btnLogout;
    }
}