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
    public partial class CustomerEdit : Form
    {
        public CustomerEdit()
        {
            InitializeComponent();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            CommonFunctions db = new CommonFunctions();
            db.EditCustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNumber.Text, custID.Text);
            MessageBox.Show("Customer Updated");
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonFunctions db = new CommonFunctions();
            db.DeleteCustomer(custID.Text);
            MessageBox.Show("Customer Deleted");
            Dispose();
        }
    }
}
