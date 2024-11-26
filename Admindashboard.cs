using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Admindashboard : Form
    {
        public Admindashboard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btnAddItem = new Button();
            btnEditUser = new Button();
            btnViewOverdue = new Button();
            dgvLibraryItems = new DataGridView();
            label1 = new Label();
            txtOutput = new TextBox();
            ((ISupportInitialize)dgvLibraryItems).BeginInit();
            SuspendLayout();
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(30, 30);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(150, 50);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "Add/Edit Items";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(30, 100);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(150, 50);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Add/Edit Users";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnViewOverdue
            // 
            btnViewOverdue.Location = new Point(30, 170);
            btnViewOverdue.Name = "btnViewOverdue";
            btnViewOverdue.Size = new Size(150, 50);
            btnViewOverdue.TabIndex = 2;
            btnViewOverdue.Text = "View Overdue Items";
            btnViewOverdue.UseVisualStyleBackColor = true;
            btnViewOverdue.Click += btnViewOverdue_Click;
            // 
            // dgvLibraryItems
            // 
            dgvLibraryItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibraryItems.Location = new Point(200, 30);
            dgvLibraryItems.Name = "dgvLibraryItems";
            dgvLibraryItems.Size = new Size(500, 300);
            dgvLibraryItems.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 293);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(200, 350);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(500, 50);
            txtOutput.TabIndex = 5;
            // 
            // Admindashboard
            // 
            ClientSize = new Size(871, 547);
            Controls.Add(txtOutput);
            Controls.Add(label1);
            Controls.Add(dgvLibraryItems);
            Controls.Add(btnViewOverdue);
            Controls.Add(btnEditUser);
            Controls.Add(btnAddItem);
            Name = "Admindashboard";
            Text = "View Overdue Items";
            ((ISupportInitialize)dgvLibraryItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
