using LibraryManagementSystem.Business;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
          
        }

        public void _RefreshBooksList()
        {
            dgvBooks.DataSource = clsBook.GetAllBooks();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            cmbAuthor.DataSource = clsAuthor.GetAllAuthors();
            cmbAuthor.DisplayMember = "Name";
            cmbAuthor.ValueMember = "AuthorID";

            cmbCategory.DataSource = clsCategory.GetAllCategories();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryID";

            _RefreshBooksList();
        }


        // Add Book
        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsBook Book = new clsBook();

            Book.Title = txtTitle.Text.Trim();
            Book.ISBN = txtISBN.Text.Trim();
            Book.PublishYear = Convert.ToInt32(txtPublishYear.Text.Trim());

            Book.AuthorID = (int)cmbAuthor.SelectedValue;
            Book.CategoryID = (int)cmbCategory.SelectedValue;

            // Number of copies
            Book.TotalCopies = Convert.ToInt32(txtTotalCopies.Text.Trim());

            // When adding a new book, all copies are available
            Book.AvailableCopies = Book.TotalCopies;


            if (Book.Save())
            {
                MessageBox.Show(
                    "Book added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _RefreshBooksList();

                txtTitle.Clear();
                txtISBN.Clear();
                txtPublishYear.Clear();
                txtTotalCopies.Clear();

                cmbAuthor.SelectedIndex = 0;
                cmbCategory.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(
                    "Failed to add Book.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void dgvBooks_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }


        // Select Book
        private void dgvBooks_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            txtTitle.Text =
                dgvBooks.CurrentRow.Cells[1].Value.ToString();

            txtISBN.Text =
                dgvBooks.CurrentRow.Cells[4].Value.ToString();

            txtPublishYear.Text =
                dgvBooks.CurrentRow.Cells[5].Value.ToString();

            txtTotalCopies.Text =
                dgvBooks.CurrentRow.Cells[6].Value.ToString();

         

            cmbAuthor.SelectedValue =
                dgvBooks.CurrentRow.Cells[2].Value;

            cmbCategory.SelectedValue =
                dgvBooks.CurrentRow.Cells[3].Value;
        }


        // Update Book
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsBook Book =
                clsBook.GetBookByID(
                    Convert.ToInt32(
                        dgvBooks.CurrentRow.Cells[0].Value));

            if (Book != null)
            {
                Book.Title = txtTitle.Text.Trim();
                Book.ISBN = txtISBN.Text.Trim();

                Book.PublishYear =
                    Convert.ToInt32(txtPublishYear.Text.Trim());

                Book.AuthorID =
                    (int)cmbAuthor.SelectedValue;

                Book.CategoryID =
                    (int)cmbCategory.SelectedValue;

                // Update total copies
                Book.TotalCopies =
                    Convert.ToInt32(txtTotalCopies.Text.Trim());

                // Make sure available copies don't exceed total copies
                if (Book.AvailableCopies > Book.TotalCopies)
                {
                    Book.AvailableCopies = Book.TotalCopies;
                }


                if (Book.Save())
                {
                    MessageBox.Show(
                        "Book updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    _RefreshBooksList();

                    txtTitle.Clear();
                    txtISBN.Clear();
                    txtPublishYear.Clear();
                    txtTotalCopies.Clear();
                  

                    cmbAuthor.SelectedIndex = 0;
                    cmbCategory.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(
                        "Failed to update Book.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


        // Delete Book
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to delete this book?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsBook Book =
                    clsBook.GetBookByID(
                        Convert.ToInt32(
                            dgvBooks.CurrentRow.Cells[0].Value));

                if (Book != null &&
                    clsBook.DeleteBook(Book.BookID))
                {
                    MessageBox.Show(
                        "Book deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    _RefreshBooksList();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to delete Book.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAuthors();
            frm.ShowDialog();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form frm = new frmCategories();
            frm.ShowDialog();
        }

    }
}