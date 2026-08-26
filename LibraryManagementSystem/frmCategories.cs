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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }
        private void _RefreshCategoriesList()
        {
            dgvCategoryies.DataSource = clsCategory.GetAllCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            _RefreshCategoriesList();
        }

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            clsCategory category = new clsCategory();
            category.Name = txtCategoryName.Text.Trim();
            if (category.Save())
            {
                MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshCategoriesList();
                txtCategoryName.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatecategory_Click(object sender, EventArgs e)
        {
            clsCategory category = clsCategory.GetCategoryByID(Convert.ToInt32(dgvCategoryies.CurrentRow.Cells[0].Value));
            if (category != null)
            {
                category.Name = txtCategoryName.Text.Trim();
                if (category.Save())
                {
                    MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshCategoriesList();
                    txtCategoryName.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to update category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCategoryies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryName.Text = dgvCategoryies.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDeletecategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsCategory category = clsCategory.GetCategoryByID(Convert.ToInt32(dgvCategoryies.CurrentRow.Cells[0].Value));
                if (clsCategory.DeleteCategory(category.CategoryID))
                {
                    MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshCategoriesList();

                }
                else
                {
                    MessageBox.Show("Failed to delete category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblcategoriesTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategoryies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
