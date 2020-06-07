using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental_Arshdeep
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        void Dialog(Form frm)
        {
            frm.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Dialog(new CustomerAdd() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            Dialog(new CustomerView() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Dialog(new MovieAdd() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void btnViewMovie_Click(object sender, EventArgs e)
        {
            Dialog(new MovieView() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            Dialog(new MovieIssue() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            Dialog(new MovieReturn() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Dialog(new TopList() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
