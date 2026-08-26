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
    public partial class frmLibrarymanagementsystem : Form
    {
        public frmLibrarymanagementsystem()
        {
            InitializeComponent();
            OpenFormInTab(new frmBooks(), tabBooksManagement);
            OpenFormInTab(new frmMembers(), tabMembersManagement);
            OpenFormInTab(new frmBorrowings(), tabBorrowReturn);
        }

      
        private void OpenFormInTab(Form form, TabPage tab)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            tab.Controls.Clear();
            tab.Controls.Add(form);

            form.Show();
        }

      

        private void tabControl1_MouseClick_1(object sender, MouseEventArgs e)
        {
            OpenFormInTab(new frmBooks(), tabBooksManagement);
            OpenFormInTab(new frmMembers(), tabMembersManagement);
            OpenFormInTab(new frmBorrowings(), tabBorrowReturn);
        }
    }
}
