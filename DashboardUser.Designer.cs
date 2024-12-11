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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 26);
            label1.Name = "label1";
            label1.Size = new Size(274, 48);
            label1.TabIndex = 0;
            label1.Text = "User Dashboard";
            // 
            // lbLibraryCatalogue
            // 
            lbLibraryCatalogue.FormattingEnabled = true;
            lbLibraryCatalogue.HorizontalScrollbar = true;
            lbLibraryCatalogue.ItemHeight = 25;
            lbLibraryCatalogue.Items.AddRange(new object[] { "Destined for Murder", "Bringers of the Dawn", "You Cannot Die", "Many Mansions" });
            lbLibraryCatalogue.Location = new Point(36, 167);
            lbLibraryCatalogue.Name = "lbLibraryCatalogue";
            lbLibraryCatalogue.Size = new Size(314, 129);
            lbLibraryCatalogue.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(36, 115);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 2;
            label2.Text = "Library catalogue:";
            // 
            // DashboardUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 206, 167);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lbLibraryCatalogue);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(139, 50, 44);
            Name = "DashboardUser";
            Text = "DashboardUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbLibraryCatalogue;
        private Label label2;
    }
}