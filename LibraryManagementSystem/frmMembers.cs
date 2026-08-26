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
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        private void _RefreshmembersList()
        {
            dgvMembers.DataSource = clsMember.GetAllMembers();
        }
        private void frmMembers_Load(object sender, EventArgs e)
        {
            _RefreshmembersList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           clsMember Member=new clsMember();
          Member.FirstName  = txtFirstName.Text.Trim();
          Member.LastName = txtLastName.Text.Trim();
          Member.Phone = txtPhone.Text.Trim();
            Member.Email = txtEmail.Text.Trim();
            Member.Address = txtAddress.Text.Trim();

            if (Member.Save())
            {
                MessageBox.Show("Member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshmembersList();
              txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                 txtAddress.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add Member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsMember Member = clsMember.GetMemberByID(Convert.ToInt32(dgvMembers.CurrentRow.Cells[0].Value));
            if (Member != null)
            {
                Member.FirstName = txtFirstName.Text.Trim();
                Member.LastName = txtLastName.Text.Trim();
                Member.Phone = txtPhone.Text.Trim();
                Member.Email = txtEmail.Text.Trim();
                Member.Address = txtAddress.Text.Trim();

                if (Member.Save())
                {
                    MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshmembersList();
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhone.Clear();
                    txtEmail.Clear();
                    txtAddress.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Update Member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you shure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsMember Member = clsMember.GetMemberByID(Convert.ToInt32(dgvMembers.CurrentRow.Cells[0].Value));
                if (clsMember.DeleteMember(Member.MemberID))
                {
                    MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshmembersList();

                }
                else
                {
                    MessageBox.Show("Failed to delete Member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirstName.Text = dgvMembers.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvMembers.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgvMembers.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvMembers.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = dgvMembers.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
