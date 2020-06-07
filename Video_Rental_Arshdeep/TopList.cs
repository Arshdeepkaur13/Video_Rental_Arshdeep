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
    public partial class TopList : Form
    {
        public TopList()
        {
            InitializeComponent();
        }

        private void TopList_Load(object sender, EventArgs e)
        {
            dataGridViewCustomer.DataSource = new CommonFunctions().FindBestCustomers();
            dataGridViewMovies.DataSource = new CommonFunctions().GetBestSellingMovies();
        }
    }
}
