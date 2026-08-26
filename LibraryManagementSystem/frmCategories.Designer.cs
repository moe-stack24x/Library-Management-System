namespace LibraryManagementSystem
{
    partial class frmCategories
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
            this.btnDeletecategory = new System.Windows.Forms.Button();
            this.btnUpdatecategory = new System.Windows.Forms.Button();
            this.lblcategoriesTitle = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dgvCategoryies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletecategory
            // 
            this.btnDeletecategory.BackColor = System.Drawing.Color.Maroon;
            this.btnDeletecategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletecategory.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletecategory.ForeColor = System.Drawing.Color.White;
            this.btnDeletecategory.Location = new System.Drawing.Point(605, 298);
            this.btnDeletecategory.Name = "btnDeletecategory";
            this.btnDeletecategory.Size = new System.Drawing.Size(101, 35);
            this.btnDeletecategory.TabIndex = 11;
            this.btnDeletecategory.Text = "Delete";
            this.btnDeletecategory.UseVisualStyleBackColor = false;
            this.btnDeletecategory.Click += new System.EventHandler(this.btnDeletecategory_Click);
            // 
            // btnUpdatecategory
            // 
            this.btnUpdatecategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdatecategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatecategory.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatecategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdatecategory.Location = new System.Drawing.Point(487, 298);
            this.btnUpdatecategory.Name = "btnUpdatecategory";
            this.btnUpdatecategory.Size = new System.Drawing.Size(101, 35);
            this.btnUpdatecategory.TabIndex = 10;
            this.btnUpdatecategory.Text = "Update";
            this.btnUpdatecategory.UseVisualStyleBackColor = false;
            this.btnUpdatecategory.Click += new System.EventHandler(this.btnUpdatecategory_Click);
            // 
            // lblcategoriesTitle
            // 
            this.lblcategoriesTitle.AutoSize = true;
            this.lblcategoriesTitle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoriesTitle.ForeColor = System.Drawing.Color.Olive;
            this.lblcategoriesTitle.Location = new System.Drawing.Point(325, 9);
            this.lblcategoriesTitle.Name = "lblcategoriesTitle";
            this.lblcategoriesTitle.Size = new System.Drawing.Size(237, 60);
            this.lblcategoriesTitle.TabIndex = 9;
            this.lblcategoriesTitle.Text = "Categories";
            this.lblcategoriesTitle.Click += new System.EventHandler(this.lblcategoriesTitle_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(193, 108);
            this.txtCategoryName.Multiline = true;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(254, 30);
            this.txtCategoryName.TabIndex = 8;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(565, 189);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(101, 35);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click_1);
            // 
            // dgvCategoryies
            // 
            this.dgvCategoryies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryies.Location = new System.Drawing.Point(26, 172);
            this.dgvCategoryies.Name = "dgvCategoryies";
            this.dgvCategoryies.RowHeadersWidth = 51;
            this.dgvCategoryies.RowTemplate.Height = 24;
            this.dgvCategoryies.Size = new System.Drawing.Size(334, 266);
            this.dgvCategoryies.TabIndex = 6;
            this.dgvCategoryies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryies_CellContentClick);
            this.dgvCategoryies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryies_CellDoubleClick);
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletecategory);
            this.Controls.Add(this.btnUpdatecategory);
            this.Controls.Add(this.lblcategoriesTitle);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dgvCategoryies);
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletecategory;
        private System.Windows.Forms.Button btnUpdatecategory;
        private System.Windows.Forms.Label lblcategoriesTitle;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dgvCategoryies;
    }
}