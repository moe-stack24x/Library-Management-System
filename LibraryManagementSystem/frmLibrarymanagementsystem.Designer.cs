namespace LibraryManagementSystem
{
    partial class frmLibrarymanagementsystem
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
            this.tabBorrowReturn = new System.Windows.Forms.TabPage();
            this.tabMembersManagement = new System.Windows.Forms.TabPage();
            this.tabBooksManagement = new System.Windows.Forms.TabPage();
            this.Main = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBorrowReturn
            // 
            this.tabBorrowReturn.Location = new System.Drawing.Point(4, 35);
            this.tabBorrowReturn.Name = "tabBorrowReturn";
            this.tabBorrowReturn.Size = new System.Drawing.Size(1163, 606);
            this.tabBorrowReturn.TabIndex = 3;
            this.tabBorrowReturn.Text = "Borrow/Return";
            this.tabBorrowReturn.UseVisualStyleBackColor = true;
            // 
            // tabMembersManagement
            // 
            this.tabMembersManagement.AccessibleName = "";
            this.tabMembersManagement.Location = new System.Drawing.Point(4, 35);
            this.tabMembersManagement.Name = "tabMembersManagement";
            this.tabMembersManagement.Size = new System.Drawing.Size(1163, 606);
            this.tabMembersManagement.TabIndex = 2;
            this.tabMembersManagement.Text = "MembersManagement";
            this.tabMembersManagement.UseVisualStyleBackColor = true;
            // 
            // tabBooksManagement
            // 
            this.tabBooksManagement.AccessibleName = "";
            this.tabBooksManagement.Location = new System.Drawing.Point(4, 35);
            this.tabBooksManagement.Name = "tabBooksManagement";
            this.tabBooksManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooksManagement.Size = new System.Drawing.Size(1163, 606);
            this.tabBooksManagement.TabIndex = 1;
            this.tabBooksManagement.Text = "BooksManagement";
            this.tabBooksManagement.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.Main.AccessibleName = "";
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main.Controls.Add(this.pictureBox1);
            this.Main.Controls.Add(this.label1);
            this.Main.ForeColor = System.Drawing.Color.Coral;
            this.Main.Location = new System.Drawing.Point(4, 35);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(1163, 606);
            this.Main.TabIndex = 0;
            this.Main.Text = "Home";
          
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.BookStore_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(416, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(173, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.Main);
            this.tabControl1.Controls.Add(this.tabBooksManagement);
            this.tabControl1.Controls.Add(this.tabMembersManagement);
            this.tabControl1.Controls.Add(this.tabBorrowReturn);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1171, 645);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick_1);
            // 
            // frmLibrarymanagementsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1171, 645);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmLibrarymanagementsystem";
            this.Text = "frmLibrarymanagementsystem";
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabBorrowReturn;
        private System.Windows.Forms.TabPage tabMembersManagement;
        private System.Windows.Forms.TabPage tabBooksManagement;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}