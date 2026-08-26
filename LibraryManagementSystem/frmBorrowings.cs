using LibraryManagementSystem.Business;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmBorrowings : Form
    {
        public frmBorrowings()
        {
            InitializeComponent();
        }

        private void _RefreshBorrowingList()
        {
            dgvBorrowings.DataSource = clsBorrowing.GetAllBorrowings();
        }

        private void frmBorrowings_Load(object sender, EventArgs e)
        {
            _RefreshBorrowingList();

            cmbBook.DataSource = clsBook.GetAllBooks();
            cmbBook.DisplayMember = "Title";
            cmbBook.ValueMember = "BookID";

            cmbMember.DataSource = clsMember.GetAllMembers();
            cmbMember.DisplayMember = "FirstName";
            cmbMember.ValueMember = "MemberID";
        }


        // Borrow Book
        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsBook Book =
                clsBook.GetBookByID((int)cmbBook.SelectedValue);

            if (Book == null)
            {
                MessageBox.Show(
                    "Book not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Check if there are available copies
            if (Book.AvailableCopies <= 0)
            {
                MessageBox.Show(
                    "No copies of this book are available.",
                    "Book Not Available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            clsBorrowing BorrowingRecord = new clsBorrowing();

            BorrowingRecord.BookID = (int)cmbBook.SelectedValue;
            BorrowingRecord.MemberID = (int)cmbMember.SelectedValue;
            BorrowingRecord.BorrowDate = dtpBorrowDate.Value;
            BorrowingRecord.Status = "Borrowed";


            if (BorrowingRecord.Save())
            {
                // Decrease available copies
                Book.AvailableCopies--;
                Book.Save();
                

                MessageBox.Show(
                    "Book borrowed successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _RefreshBorrowingList();

                cmbBook.SelectedIndex = 0;
                cmbMember.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(
                    "Failed to borrow Book.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // Return Book
        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            if (dgvBorrowings.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a borrowing record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            clsBorrowing BorrowingRecord =
                clsBorrowing.GetBorrowingByID(
                    Convert.ToInt32(
                        dgvBorrowings.CurrentRow.Cells[0].Value));


            if (BorrowingRecord == null)
            {
                return;
            }


            if (BorrowingRecord.Status == "Returned")
            {
                MessageBox.Show(
                    "This book has already been returned.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            BorrowingRecord.ReturnDate = DateTime.Now;
            BorrowingRecord.Status = "Returned";


            if (BorrowingRecord.Save())
            {
                clsBook Book =
                    clsBook.GetBookByID(BorrowingRecord.BookID);


                if (Book != null)
                {
                    // Increase available copies
                    if (Book.AvailableCopies < Book.TotalCopies)
                    {
                        Book.AvailableCopies++;
                        Book.Save();
                    }
                }


                MessageBox.Show(
                    "Book returned successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _RefreshBorrowingList();
            }
            else
            {
                MessageBox.Show(
                    "Failed to return Book.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}