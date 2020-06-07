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
    public partial class CustomerAdd : Form
    {
        public CustomerAdd()
        {
            InitializeComponent();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                CommonFunctions db = new CommonFunctions();//instance of all functions
                db.AddCustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNumber.Text);//calling add customer method
                MessageBox.Show("Customer Added");
                Dispose();
            }
        }
    }
}
