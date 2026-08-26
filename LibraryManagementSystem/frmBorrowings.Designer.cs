namespace LibraryManagementSystem
{
    partial class frmBorrowings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBorrowings = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblBorrowingsTitle = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBorrowings
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBorrowings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBorrowings.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvBorrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrowings.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBorrowings.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBorrowings.Location = new System.Drawing.Point(443, 233);
            this.dgvBorrowings.Name = "dgvBorrowings";
            this.dgvBorrowings.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvBorrowings.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBorrowings.RowTemplate.Height = 24;
            this.dgvBorrowings.Size = new System.Drawing.Size(797, 346);
            this.dgvBorrowings.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(53, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Member:";
            // 
            // cmbMember
            // 
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(147, 313);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(103, 24);
            this.cmbMember.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(35, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "BorrowDate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(53, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Book:";
            // 
            // cmbBook
            // 
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(147, 229);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(103, 24);
            this.cmbBook.TabIndex = 37;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SlateGray;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(248, 536);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(151, 43);
            this.btnReturn.TabIndex = 33;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // lblBorrowingsTitle
            // 
            this.lblBorrowingsTitle.AutoSize = true;
            this.lblBorrowingsTitle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowingsTitle.ForeColor = System.Drawing.Color.Olive;
            this.lblBorrowingsTitle.Location = new System.Drawing.Point(571, 34);
            this.lblBorrowingsTitle.Name = "lblBorrowingsTitle";
            this.lblBorrowingsTitle.Size = new System.Drawing.Size(552, 81);
            this.lblBorrowingsTitle.TabIndex = 32;
            this.lblBorrowingsTitle.Text = "Borrowing Records";
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.SlateGray;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.Black;
            this.btnBorrow.Location = new System.Drawing.Point(44, 536);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(151, 43);
            this.btnBorrow.TabIndex = 30;
            this.btnBorrow.Text = "Borrow Book";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(158, 396);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBorrowDate.TabIndex = 48;
            // 
            // frmBorrowings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1289, 662);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.dgvBorrowings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblBorrowingsTitle);
            this.Controls.Add(this.btnBorrow);
            this.Name = "frmBorrowings";
            this.Text = "frmBorrowings";
            this.Load += new System.EventHandler(this.frmBorrowings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBorrowings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblBorrowingsTitle;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
    }
}