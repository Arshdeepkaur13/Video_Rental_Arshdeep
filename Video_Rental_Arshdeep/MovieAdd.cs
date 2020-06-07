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
    public partial class MovieAdd : Form
    {
        public MovieAdd()
        {
            InitializeComponent();
        }

        private void btnAddMovies_Click(object sender, EventArgs e)
        {
            int x, y;

            if (rating.Text == "" || title.Text == "" || year.Text == "" || copies.Text == "" || plot.Text == "" || genre.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else if (!int.TryParse(year.Text, out x) || !(int.TryParse(copies.Text, out y)))
            {
                MessageBox.Show("Year and Copies must be a valid integer");
            }
            else
            {
                int rental = 0;
                if ((DateTime.Now.Year - x) > 5)
                {
                    rental = 2;
                }
                else
                {
                    rental = 5;
                }

                CommonFunctions db = new CommonFunctions();
                DateTime date = DateTime.Now;
                db.AddNewMovie(rating.Text, title.Text, year.Text, rental.ToString(), copies.Text, plot.Text, genre.Text, date);

                MessageBox.Show("Movie Added");
            }
        }
    }
}
