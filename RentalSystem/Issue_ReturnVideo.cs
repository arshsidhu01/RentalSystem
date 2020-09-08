using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalSystem
{
    public partial class Issue_ReturnVideo : Form
    {
        SQLQueries objContext = new SQLQueries();
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["DbName"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        public Issue_ReturnVideo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (gridAllRentedMovie.Rows.Count > 0)
            {
                rentalVideoId.Text = gridAllRentedMovie.CurrentRow.Cells["RMID"].Value.ToString();

                videoId.Text = gridAllRentedMovie.CurrentRow.Cells["MovieId"].Value.ToString();
            }
            if (string.IsNullOrEmpty(rentalVideoId.Text))
            {
                MessageBox.Show("Please Select the Rented Movie");
                return;
            }
            sqlcon.Open();
            var alreadyReturned = 0;
            cmd = new SqlCommand("Select * from RentedMovies where RentedMovieId=@RentedMovieId and DateReturned is Not NULL", sqlcon);
            cmd.Parameters.AddWithValue("@RentedMovieId", rentalVideoId.Text);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                alreadyReturned = 1;
            }
            else
            {
                alreadyReturned = 0;
            }
            rdr.Close();
            sqlcon.Close();
            if (alreadyReturned == 1)
            {
                MessageBox.Show("This Video already returned");
                return;
            }


            objContext.ReturnedMovie(Convert.ToInt32(rentalVideoId.Text));
            
                objContext.ChangedStatus(Convert.ToInt32(videoId.Text), "Yes");
                MessageBox.Show("Video Returned successfully");
                videoId.Text = "";
                rentalVideoId.Text = "";
                if (rbAllRental.Checked == true)
                {
                    RentedmovieGridData();
                }
                else
                {
                    RentedOutGridData();
                }
                getCustomer();
                getAvailableVideo();
            
            
        }
        private void Issue_ReturnVideo_Load(object sender, EventArgs e)
        {
            getCustomer();
            getAvailableVideo();
            RentedmovieGridData();
            rbAllRental.Checked = true;
        }
        private void getCustomer()
        {

            DataTable dt = new DataTable();

            dt = objContext.getCustomer();
           
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select Customer";
            dt.Rows.InsertAt(row, 0);
            ddlCustomer.DataSource = dt;
            ddlCustomer.ValueMember = "CustId";
            ddlCustomer.DisplayMember = "FirstName";

         
        }
        private void rbRentedOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllRental.Checked == true)
            {
                RentedmovieGridData();
            }
            else
            {
                RentedOutGridData();
            }
        }
        private void rbAllRental_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllRental.Checked == true)
            {
                RentedmovieGridData();
            }
            else
            {
                RentedOutGridData();
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRentalVideo_Click(object sender, EventArgs e)
        {
            bool checkValid = validationCheck();
            if (checkValid == true)
            {
                objContext.VideoOnRental(Convert.ToInt32(ddlVideo.SelectedValue.ToString()), Convert.ToInt32(ddlCustomer.SelectedValue.ToString()), RentedDate.Value.Date);

                 objContext.ChangedStatus(Convert.ToInt32(ddlVideo.SelectedValue.ToString()), "No");
                    MessageBox.Show("Video Rented successfully");
                    getCustomer();
                    getAvailableVideo();
                    if (rbAllRental.Checked == true)
                    {
                        RentedmovieGridData();
                    }
                    else
                    {
                        RentedOutGridData();
                    }

                
            }

        }
        private void getAvailableVideo()
        {

            DataTable dt = new DataTable();

            dt = objContext.getAvailableVideo();
           
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select Video";
            dt.Rows.InsertAt(row, 0);
            ddlVideo.DataSource = dt;
            ddlVideo.ValueMember = "MovieId";
            ddlVideo.DisplayMember = "Title";

        }

       
        private void RentedmovieGridData()
        {
            DataTable dt = new DataTable();

            dt = objContext.SelectRentedMoviesView();

            gridAllRentedMovie.DataSource = dt;
        }

        

        

       
        private void RentedOutGridData()
        {
            DataTable dt = new DataTable();

            dt = objContext.SelectRentedOutMoviesView();
            gridAllRentedMovie.DataSource = dt;
        }

      
        public bool validationCheck()
        {
            if (ddlCustomer.SelectedValue == null || ddlVideo.SelectedValue == null)
            {
                MessageBox.Show("Please Select the Customer and Video");
                return false;
            }
            if (ddlCustomer.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Customer");
                return false;
            }
            if (ddlVideo.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Video");
                return false;
            }
            if (string.IsNullOrEmpty(ddlCustomer.SelectedValue.ToString()) || string.IsNullOrEmpty(ddlVideo.SelectedValue.ToString()))
            {
                MessageBox.Show("Please Select the Customer and Movie for rental");
                return false;
            }
            return true;
        }
    }
}
