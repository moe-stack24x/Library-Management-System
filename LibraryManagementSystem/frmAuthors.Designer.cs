namespace LibraryManagementSystem
{
    partial class frmAuthors
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
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.lblAuthorTitle = new System.Windows.Forms.Label();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Location = new System.Drawing.Point(25, 207);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.RowHeadersWidth = 51;
            this.dgvAuthors.RowTemplate.Height = 24;
            this.dgvAuthors.Size = new System.Drawing.Size(723, 266);
            this.dgvAuthors.TabIndex = 0;
            this.dgvAuthors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthors_CellDoubleClick);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Location = new System.Drawing.Point(393, 147);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(101, 35);
            this.btnAddAuthor.TabIndex = 1;
            this.btnAddAuthor.Text = "Add";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(65, 147);
            this.txtAuthorName.Multiline = true;
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(254, 30);
            this.txtAuthorName.TabIndex = 2;
            // 
            // lblAuthorTitle
            // 
            this.lblAuthorTitle.AutoSize = true;
            this.lblAuthorTitle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorTitle.ForeColor = System.Drawing.Color.Olive;
            this.lblAuthorTitle.Location = new System.Drawing.Point(336, 9);
            this.lblAuthorTitle.Name = "lblAuthorTitle";
            this.lblAuthorTitle.Size = new System.Drawing.Size(184, 60);
            this.lblAuthorTitle.TabIndex = 3;
            this.lblAuthorTitle.Text = "Authors";
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAuthor.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAuthor.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAuthor.Location = new System.Drawing.Point(510, 147);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(101, 35);
            this.btnUpdateAuthor.TabIndex = 4;
            this.btnUpdateAuthor.Text = "Update";
            this.btnUpdateAuthor.UseVisualStyleBackColor = false;
            this.btnUpdateAuthor.Click += new System.EventHandler(this.btnUpdateAuthor_Click);
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAuthor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(628, 147);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(101, 35);
            this.btnDeleteAuthor.TabIndex = 5;
            this.btnDeleteAuthor.Text = "Delete";
            this.btnDeleteAuthor.UseVisualStyleBackColor = false;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // frmAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(774, 511);
            this.Controls.Add(this.btnDeleteAuthor);
            this.Controls.Add(this.btnUpdateAuthor);
            this.Controls.Add(this.lblAuthorTitle);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.dgvAuthors);
            this.Name = "frmAuthors";
            this.Text = "frmAuthors";
            this.Load += new System.EventHandler(this.frmAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label lblAuthorTitle;
        private System.Windows.Forms.Button btnUpdateAuthor;
        private System.Windows.Forms.Button btnDeleteAuthor;
    }
}