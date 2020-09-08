using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalSystem
{
    public class SQLQueries
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbName"].ConnectionString);
        public void ReturnedMovie(int id)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update RentedMovies set DateReturned=@DateReturned where RentedMovieId=@RentedMovieId", con))
                {
                    cmd.Parameters.AddWithValue("@RentedMovieId", id);
                    cmd.Parameters.AddWithValue("@DateReturned", DateTime.Now);

                    cmd.ExecuteNonQuery();

                }
                con.Close();

            }
            catch
            {

            }
        }
        public DataTable SelectRentedOutMoviesView()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from ViewRentedMovies where DateReturned is Null", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public void DeleteVideo(int video_id)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("delete from Movie where MovieId=@MovieId", con))
                {
                    cmd.Parameters.AddWithValue("@MovieId", video_id);

                    cmd.ExecuteNonQuery();

                }
                con.Close();

            }
            catch
            {

            }
        }
       
        public void EditVideo(string title, DateTime release_date, decimal cost, string genre, string plot, int movieId)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update Movie set Title=@Title,ReleaseDate=@ReleaseDate,RentalCost=@RentalCost,Genre=@Genre,Plot=@Plot where MovieId=@MovieId", con))
                {
                    cmd.Parameters.AddWithValue("@MovieId", movieId);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@ReleaseDate", release_date);
                    cmd.Parameters.AddWithValue("@RentalCost", cost);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@Plot", plot);


                    cmd.ExecuteNonQuery();

                }
                con.Close();

            }
            catch
            {

            }
        }
        public DataTable getAvailableVideo()
        {
            DataTable dt_availble = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from Movie where Available='Yes'", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt_availble);
                    }
                }
                return dt_availble;
            }
            catch
            {
                return dt_availble;
            }
        }
        public void Delete_Customer(int cust_Id)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("delete from Customer where CustId=@CustId", con))
                {
                    cmd.Parameters.AddWithValue("@CustId", cust_Id);

                    cmd.ExecuteNonQuery();

                }
                con.Close();

            }
            catch
            {

            }
        }
        public void ChangedStatus(int video_id, string status)
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand("update Movie set Available=@Available where MovieId=@MovieId", con))
            {
                cmd.Parameters.AddWithValue("@MovieId", video_id);
                cmd.Parameters.AddWithValue("@Available", status);

                cmd.ExecuteNonQuery();

            }
            con.Close();

        }
        public DataTable getCustomer()
        {
            DataTable dt_cust = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("spGetAllCustomer", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {


                        da.Fill(dt_cust);
                    }
                }
                return dt_cust;
            }
            catch
            {
                return dt_cust;
            }
        }
        public bool AlreadyReturn(int video_id)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from Movie where Available='No' and MovieId=" + video_id + "", con))
                {
                    SqlDataReader rdr;
                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

            }
            catch
            {
                return true;
            }
        }
       
        public void InsertNewCustomer(string name1, string name2, string addres, string phone)
        {

            
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into Customer(FirstName,LastName,Address,Phone)values(@FirstName,@LastName,@Address,@Phone)", con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", name1);
                    cmd.Parameters.AddWithValue("@LastName", name2);
                    cmd.Parameters.AddWithValue("@Address", addres);
                    cmd.Parameters.AddWithValue("@Phone", phone);

                    cmd.ExecuteNonQuery();

                }
                con.Close();
               
        }
        public DataTable GetVideos()
        {
            DataTable video_dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from Movie", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(video_dt);
                    }
                }
                return video_dt;
            }
            catch
            {
                return video_dt;
            }
        }
        public void CustomerEdit(string name1, string name2, string addres, string phone, int cust_Id)
        {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update Customer set FirstName=@FirstName,LastName=@LastName,Address=@Address,Phone=@Phone  where CustId=@CustId", con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", name1);
                    cmd.Parameters.AddWithValue("@LastName", name2);
                    cmd.Parameters.AddWithValue("@Address", addres);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@CustId", cust_Id);

                    cmd.ExecuteNonQuery();

                }
                con.Close();
                
        }
       

        
       
        public void Video_insert(string title, DateTime release_date, decimal cost, string genre, string plot)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into Movie(Title,ReleaseDate,RentalCost,Genre,Plot,Available)values(@Title,@ReleaseDate,@RentalCost,@Genre,@Plot,@Available)", con))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@ReleaseDate", release_date);
                    cmd.Parameters.AddWithValue("@RentalCost", cost);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@Plot", plot);
                    cmd.Parameters.AddWithValue("@Available", "Yes");
                    cmd.ExecuteNonQuery();

                }
                con.Close();
               
            }
            catch
            {
                
            }
        }
        public void VideoOnRental(int video_id, int cust_Id, DateTime rented_date)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into RentedMovies(MovieId,CustId,DateRented)values(@MovieId,@CustId,@DateRented)", con))
                {
                    cmd.Parameters.AddWithValue("@MovieId", video_id);
                    cmd.Parameters.AddWithValue("@CustId", cust_Id);
                    cmd.Parameters.AddWithValue("@DateRented", rented_date);

                    cmd.ExecuteNonQuery();

                }
                con.Close();

            }
            catch
            {

            }
        }
        public DataTable regularCustomerList()
        {
            DataTable dt_regular = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select CustId,FirstName,LastName,Address,Phone,Count(*) as 'Total Borrows' from ViewRentedMovies group by CustId,FirstName,LastName,Address,Phone order by 'Total Borrows' desc", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt_regular);
                    }
                }
                return dt_regular;
            }
            catch
            {
                return dt_regular;
            }
        }
       
     
       
       
        public DataTable SelectRentedMoviesView()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from ViewRentedMovies", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
     
      
        
       
        public DataTable MostPopularVideo()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select MovieId,Title,ReleaseDate,RentalCost,Genre,Count(*) as 'Total Rented' from ViewRentedMovies group by MovieId,Title,ReleaseDate,RentalCost,Genre order by 'Total Rented' desc", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
       
    }
}
