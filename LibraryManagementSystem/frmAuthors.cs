using LibraryManagementSystem.Business;
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
    public partial class frmAuthors : Form
    {
        public frmAuthors()
        {
            InitializeComponent();
        }

        private void _RefreshAuthorsList()
        {
            dgvAuthors.DataSource = clsAuthor.GetAllAuthors();
        }

        private void frmAuthors_Load(object sender, EventArgs e)
        {
            _RefreshAuthorsList();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            clsAuthor author = new clsAuthor();
            author.Name = txtAuthorName.Text.Trim();
            if (author.Save())
            {
                MessageBox.Show("Author added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshAuthorsList();
                txtAuthorName.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         txtAuthorName.Text = dgvAuthors.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            clsAuthor author = clsAuthor.GetAuthorByID(Convert.ToInt32(dgvAuthors.CurrentRow.Cells[0].Value));
            if (author != null)
            {
                author.Name = txtAuthorName.Text.Trim();
                if (author.Save())
                {
                    MessageBox.Show("Author updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshAuthorsList();
                    txtAuthorName.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to update author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you shure you want to delete this author?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                clsAuthor author = clsAuthor.GetAuthorByID(Convert.ToInt32(dgvAuthors.CurrentRow.Cells[0].Value));
               if( clsAuthor.DeleteAuthor(author.AuthorID))
                {
                    MessageBox.Show("Author deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshAuthorsList();
                   
                }
                else
                {
                    MessageBox.Show("Failed to delete author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
