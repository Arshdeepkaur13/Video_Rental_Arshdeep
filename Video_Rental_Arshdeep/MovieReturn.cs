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
    public partial class MovieReturn : Form
    {
        public MovieReturn()
        {
            InitializeComponent();
            dataGridViewReturn.DataSource = new CommonFunctions().GetPendingRentals();

        }

        private void retBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to return this rental?", "Return Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CommonFunctions database = new CommonFunctions();
                //string rmid = dataGridViewReturn.SelectedRows[0].Cells[0].Value.ToString();
                string rmid = this.dataGridViewReturn.CurrentRow.Cells[0].Value.ToString();
                database.UpdateReturnRecord(Convert.ToDateTime(DateTime.Now.ToString()), rmid);
                MessageBox.Show("Movie Returned");
                dataGridViewReturn.DataSource = new CommonFunctions().GetPendingRentals();
            }
        }
    }
}
