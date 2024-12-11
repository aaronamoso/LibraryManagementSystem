namespace LibraryManagementSystem
{
    partial class DashboardAdmin
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
            btnAddOrEditPatrons = new Button();
            btnAddOrEditInventory = new Button();
            btnOverdueInventory = new Button();
            listBox1 = new ListBox();
            searchItem = new TextBox();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // btnAddOrEditPatrons
            // 
            btnAddOrEditPatrons.Location = new Point(176, 109);
            btnAddOrEditPatrons.Name = "btnAddOrEditPatrons";
            btnAddOrEditPatrons.Size = new Size(160, 63);
            btnAddOrEditPatrons.TabIndex = 2;
            btnAddOrEditPatrons.Text = "Add / Edit Patrons";
            btnAddOrEditPatrons.UseVisualStyleBackColor = true;
            // 
            // btnAddOrEditInventory
            // 
            btnAddOrEditInventory.Location = new Point(360, 109);
            btnAddOrEditInventory.Name = "btnAddOrEditInventory";
            btnAddOrEditInventory.Size = new Size(160, 63);
            btnAddOrEditInventory.TabIndex = 3;
            btnAddOrEditInventory.Text = "Add / Edit Inventory";
            btnAddOrEditInventory.UseVisualStyleBackColor = true;
            // 
            // btnOverdueInventory
            // 
            btnOverdueInventory.Location = new Point(545, 109);
            btnOverdueInventory.Name = "btnOverdueInventory";
            btnOverdueInventory.Size = new Size(160, 63);
            btnOverdueInventory.TabIndex = 4;
            btnOverdueInventory.Text = "Overdue Inventory";
            btnOverdueInventory.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(156, 232);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(574, 349);
            listBox1.TabIndex = 5;
            // 
            // searchItem
            // 
            searchItem.Location = new Point(156, 192);
            searchItem.Name = "searchItem";
            searchItem.Size = new Size(574, 23);
            searchItem.TabIndex = 6;
            searchItem.Text = "Search Item";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(769, 43);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(89, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 606);
            Controls.Add(btnLogout);
            Controls.Add(searchItem);
            Controls.Add(listBox1);
            Controls.Add(btnOverdueInventory);
            Controls.Add(btnAddOrEditInventory);
            Controls.Add(btnAddOrEditPatrons);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DashboardAdmin";
            Text = "DashboardAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddOrEditPatrons;
        private Button btnAddOrEditInventory;
        private Button btnOverdueInventory;
        private ListBox listBox1;
        private TextBox searchItem;
        private Button btnLogout;
    }
}