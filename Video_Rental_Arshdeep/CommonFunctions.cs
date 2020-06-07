using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental_Arshdeep
{
    public class CommonFunctions
    {
        private string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["RentedConnectionDB"].ToString();//This is connection string
        private SqlConnection con = null;//Sql connection instance this object is used for creating a connection with database
        private SqlCommand cmd;//sql command variable it is used for choose the command which you want to perfrom on database
        private SqlDataAdapter adp;//sql adapter it is used for communication between the dataset and database
        public CommonFunctions()
        {
            con = new SqlConnection(ConString);//here we create the instance of sqlconnection class.
        }
        public bool CheckConnection()//this function is used for checking the connection
        {
            bool natija = false;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            natija = true;
            con.Close();
            return natija;
        }

        public void AddCustomer(string FName, string LName, string Address, string Phoneno)//this is add customer method
        {
            string Query = "INSERT INTO [CustomerTable] VALUES (@FirstName, @LastName, @Address, @Phone)";//this is query for adding the data into database
            cmd = new SqlCommand(Query, con);//this is instance of sqlcommand here we pass the connection and query variables.
            //pass the variables through parameters
            cmd.Parameters.AddWithValue("@FirstName", FName);
            cmd.Parameters.AddWithValue("@LastName", LName);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phoneno);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EditCustomer(string FName, string LName, string Address, string Phoneno, string CustomerID)//This is for editing the customers
        {
            string Query = "UPDATE [CustomerTable] SET [FirstName] = @FirstName, [LastName] = @LastName,[Address] = @Address, [Phone] = @Phone WHERE [ID] = @ID";//this is query for updating the data into database
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@FirstName", FName);
            cmd.Parameters.AddWithValue("@LastName", LName);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phoneno);
            cmd.Parameters.AddWithValue("@ID", CustomerID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteCustomer(string Customerid)//Delete customer method
        {
            string Query = "DELETE FROM [CustomerTable] WHERE [ID] = @ID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@ID", Customerid);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable FindAllCustomers()//find all customer method
        {
            string Query = "SELECT * FROM [CustomerTable]";
            cmd = new SqlCommand(Query, con);
            DataTable table = new DataTable();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(table);
            return table;
        }

        public DataTable FindCustomerByID(string CustomerID)//find by customer's id method
        {
            string Query = "SELECT * FROM [CustomerTable] WHERE [ID] = @CustID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@CustID", CustomerID);
            DataTable table = new DataTable();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(table);
            return table;
        }

        public DataTable FindBestCustomers()//find best customers method
        {
            string Query = "SELECT *, ISNULL((SELECT COUNT(RMID) FROM RentedMoviesTable WHERE CustIDFK = ID), 0) AS RentedMovies FROM CustomerTable ORDER BY RentedMovies DESC";
            cmd = new SqlCommand(Query, con);
            DataTable table = new DataTable();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(table);
            return table;
        }

        public void AddNewMovie(string Rating, string Title, string Year, string Rentalcost, string Copies, string Plot, string Genre, Nullable<System.DateTime> releaseDate)//this method for adding new movie
        {
            string Query = "INSERT INTO [MoviesTable] VALUES (@Rating, @Title, @Year, @Rental_Cost, @Copies, @Plot, @Genre, @ReleaseDate)";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@Rating", Rating);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Year", Year);
            cmd.Parameters.AddWithValue("@Rental_Cost", Rentalcost);
            cmd.Parameters.AddWithValue("@Copies", Copies);
            cmd.Parameters.AddWithValue("@Plot", Plot);
            cmd.Parameters.AddWithValue("@Genre", Genre);
            cmd.Parameters.AddWithValue("@ReleaseDate", releaseDate);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EditMovie(string Rating, string Title, string Year, string Rentalcost, string Copies, string Plot, string Genre, Nullable<System.DateTime> releaseDate, string MovieID)//this method for updating new movie
        {
            string Query = "UPDATE [MoviesTable] SET [Rating] = @Rating, [Title] = @Title, [Year] = @Year, [Rental_Cost] = @Rental_Cost, [Copies] = @Copies, [Plot] =  @Plot, [Genre] = @Genre, [ReleaseDate] =@ReleaseDate WHERE [ID] = @MovieID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@Rating", Rating);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Year", Year);
            cmd.Parameters.AddWithValue("@Rental_Cost", Rentalcost);
            cmd.Parameters.AddWithValue("@Copies", Copies);
            cmd.Parameters.AddWithValue("@Plot", Plot);
            cmd.Parameters.AddWithValue("@Genre", Genre);
            cmd.Parameters.AddWithValue("@ReleaseDate", releaseDate);
            cmd.Parameters.AddWithValue("@MovieID", MovieID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteMovie(string MovieID)//delete movie method
        {
            string Query = "DELETE FROM [MoviesTable] WHERE [ID] = @MovieID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@MovieID", MovieID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable FindAllMovies()//find all movies method
        {
            string Query = "SELECT * FROM [MoviesTable]";
            cmd = new SqlCommand(Query, con);
            DataTable table = new DataTable();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(table);
            return table;
        }

        public DataTable FindMovieByID(string MovieID)//find movie by id method
        {
            string Query = "SELECT * FROM [MoviesTable] WHERE [ID] = @MovieID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@MovieID", MovieID);
            DataTable table = new DataTable();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(table);
            return table;
        }

        public DataTable GetBestSellingMovies()//get best selling movies method
        {
            string Query = "SELECT *, ISNULL((SELECT COUNT (RMID) FROM RentedMoviesTable WHERE MoviesIDFK = ID), 0) AS TimesRented FROM MoviesTable ORDER BY TimesRented DESC";
            cmd = new SqlCommand(Query, con);
            DataTable table = new DataTable();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(table);
            return table;
        }

        public void AddRentalRecord(int MovieID, int CustID, Nullable<System.DateTime> RentalDate)//Add rental record method
        {
            string Query = "INSERT INTO [RentedMoviesTable] (MoviesIDFK, CustIDFK, DateRented) VALUES (@MovieIDFK, @CustIDFK, @DateRented)";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@MovieIDFK", MovieID);
            cmd.Parameters.AddWithValue("@CustIDFK", CustID);
            cmd.Parameters.AddWithValue("@DateRented", RentalDate);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateReturnRecord(Nullable<System.DateTime> ReturnDate, string RMID)//this is for return movie method
        {
            string Query = "UPDATE [RentedMoviesTable] SET [DateReturned] = @DateReturned WHERE [RMID] = @RMID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@DateReturned", ReturnDate);
            cmd.Parameters.AddWithValue("@RMID", RMID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int GetAvailableCopies(int MovieID)//this is for how many copies are available
        {
            string Query = "SELECT (SELECT Copies FROM MoviesTable WHERE ID = @MovieID) - (SELECT ISNULL(COUNT(MovieIDFK), 0) FROM RentedMovieTable WHERE MovieIDFK = @MovieID AND DateReturned IS NULL)";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@MovieID", MovieID);
            DataTable table = new DataTable();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(table);
            return Convert.ToInt32(table.Rows[0][0]);
        }

        public DataTable GetPendingRentals()//this is for get panding data
        {
            string Query = "SELECT RMID, CustomerTable.FirstName, CustomerTable.[Address], MoviesTable.Title, MoviesTable.Rental_Cost, RentedMoviesTable.DateRented, RentedMoviesTable.DateReturned FROM RentedMoviesTable INNER JOIN MoviesTable ON RentedMoviesTable.MoviesIDFK = MoviesTable.ID INNER JOIN CustomerTable ON RentedMoviesTable.CustIDFK = CustomerTable.ID WHERE RentedMoviesTable.DateReturned IS NULL";
            cmd = new SqlCommand(Query, con);
            DataTable table = new DataTable();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(table);
            return table;
        }
    }
}
