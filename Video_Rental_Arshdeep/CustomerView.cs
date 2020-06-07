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
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            dataGridViewViewCustomer.DataSource = new CommonFunctions().FindAllCustomers();
        }

        private void dataGridViewViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerEdit customerForm = new CustomerEdit();
            customerForm.custID.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[0].Value.ToString();
            customerForm.txtFirstName.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[1].Value.ToString();
            customerForm.txtLastName.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[2].Value.ToString();
            customerForm.txtAddress.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[3].Value.ToString();
            customerForm.txtPhoneNumber.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[4].Value.ToString();
            customerForm.ShowDialog();
            dataGridViewViewCustomer.DataSource = new CommonFunctions().FindAllCustomers();
        }
    }
}
