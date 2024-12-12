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
            listBox1 = new ListBox();
            btnAddOrEditPatrons = new Button();
            btnAddOrEditInventory = new Button();
            btnOverdueInventory = new Button();
            btnLogout = new Button();
            txtBoxSearch = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(234, 206, 167);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(139, 50, 44);
            label1.Location = new Point(259, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(146, 189);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(422, 289);
            listBox1.TabIndex = 1;
            // 
            // btnAddOrEditPatrons
            // 
            btnAddOrEditPatrons.BackColor = Color.FromArgb(139, 50, 44);
            btnAddOrEditPatrons.ForeColor = SystemColors.ControlLightLight;
            btnAddOrEditPatrons.Location = new Point(159, 78);
            btnAddOrEditPatrons.Name = "btnAddOrEditPatrons";
            btnAddOrEditPatrons.Size = new Size(128, 47);
            btnAddOrEditPatrons.TabIndex = 2;
            btnAddOrEditPatrons.Text = "Add/Edit Patrons";
            btnAddOrEditPatrons.UseVisualStyleBackColor = false;
            // 
            // btnAddOrEditInventory
            // 
            btnAddOrEditInventory.BackColor = Color.FromArgb(139, 50, 44);
            btnAddOrEditInventory.ForeColor = SystemColors.ControlLightLight;
            btnAddOrEditInventory.Location = new Point(293, 78);
            btnAddOrEditInventory.Name = "btnAddOrEditInventory";
            btnAddOrEditInventory.Size = new Size(128, 47);
            btnAddOrEditInventory.TabIndex = 3;
            btnAddOrEditInventory.Text = "Add/Edit Inventory";
            btnAddOrEditInventory.UseVisualStyleBackColor = false;
            // 
            // btnOverdueInventory
            // 
            btnOverdueInventory.BackColor = Color.FromArgb(139, 50, 44);
            btnOverdueInventory.ForeColor = SystemColors.ControlLightLight;
            btnOverdueInventory.Location = new Point(427, 78);
            btnOverdueInventory.Name = "btnOverdueInventory";
            btnOverdueInventory.Size = new Size(128, 47);
            btnOverdueInventory.TabIndex = 4;
            btnOverdueInventory.Text = "Overdue Inventory";
            btnOverdueInventory.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(139, 50, 44);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(619, 27);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(89, 30);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(146, 146);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(422, 23);
            txtBoxSearch.TabIndex = 6;
            txtBoxSearch.Text = "Search Item...";
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 206, 167);
            ClientSize = new Size(753, 511);
            Controls.Add(txtBoxSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnOverdueInventory);
            Controls.Add(btnAddOrEditInventory);
            Controls.Add(btnAddOrEditPatrons);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "DashboardAdmin";
            Text = "DashboardAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button btnAddOrEditPatrons;
        private Button btnAddOrEditInventory;
        private Button btnOverdueInventory;
        private Button btnLogout;
        private TextBox txtBoxSearch;
    }
}