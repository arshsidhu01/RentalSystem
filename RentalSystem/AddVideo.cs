using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalSystem
{
    public partial class AddVideo : Form
    {
        SQLQueries objContext = new SQLQueries();
        public AddVideo()
        {
            InitializeComponent();
        }

        private void AddVideo_Load(object sender, EventArgs e)
        {
            if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                txt_Cost.Text = "2";
            }
            else
            {
                txt_Cost.Text = "5";
            }
            GetVideos();
            btnSave.Enabled = true;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            
        }
        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void gridVideo_Click(object sender, EventArgs e)
        {
            if (videogrid.Rows.Count > 0)
            {
                Id.Text = videogrid.CurrentRow.Cells[0].Value.ToString();
                txt_Title.Text = videogrid.CurrentRow.Cells[1].Value.ToString();
                dtp_ReleaseDate.Text = videogrid.CurrentRow.Cells[2].Value.ToString();
                txt_Cost.Text = videogrid.CurrentRow.Cells[3].Value.ToString();
                txt_Genre.Text = videogrid.CurrentRow.Cells[4].Value.ToString();
                txt_Plot.Text = videogrid.CurrentRow.Cells[5].Value.ToString();
                btnSave.Enabled = false;
                btn_del.Enabled = true;
                btn_edit.Enabled = true;

            }
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE??", "Record Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                objContext.DeleteVideo(Convert.ToInt32(Id.Text));
                Id.Text = "";
                ClearTextBoxes();
                GetVideos();
                if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                {
                    txt_Cost.Text = "2";
                }
                else
                {
                    txt_Cost.Text = "5";
                }
                MessageBox.Show("Successfully Delete Movie");
                    btnSave.Enabled = true;
                    btn_edit.Enabled = false;
                    btn_del.Enabled = false;
                    
               
                
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        public void GetVideos()
        {
            DataTable dt = new DataTable();

            dt = objContext.GetVideos();

            //custGrid.AutoGenerateColumns = false;
            videogrid.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Title.Text))
            {
                MessageBox.Show("Movie Title is required");
                return;
            }
            else if (string.IsNullOrEmpty(txt_Cost.Text))
            {
                MessageBox.Show("Rental Cost is required");
                return;
            }

            objContext.Video_insert(txt_Title.Text, dtp_ReleaseDate.Value.Date, Convert.ToDecimal(txt_Cost.Text), txt_Genre.Text, txt_Plot.Text);
            
                Id.Text = "";

                ClearTextBoxes();
                GetVideos();
            if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                txt_Cost.Text = "2";
            }
            else
            {
                txt_Cost.Text = "5";
            }
            MessageBox.Show("Successfully Add Movie");
                btnSave.Enabled = true;
                btn_edit.Enabled = false;
                btn_del.Enabled = false;
                
            
        }
        

        private void btn_edit_Click(object sender, EventArgs e)
        {
            objContext.EditVideo(txt_Title.Text, dtp_ReleaseDate.Value.Date, Convert.ToDecimal(txt_Cost.Text), txt_Genre.Text, txt_Plot.Text, Convert.ToInt32(Id.Text));
            
                Id.Text = "";

                ClearTextBoxes();
                GetVideos();

                MessageBox.Show("Successfully Update Movie");
                btnSave.Enabled = true;
                btn_edit.Enabled = false;
                btn_del.Enabled = false;
                if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                {
                    txt_Cost.Text = "2";
                }
                else
                {
                    txt_Cost.Text = "5";
                }
            
            
        }

       

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                txt_Cost.Text = "2";
            }
            else
            {
                txt_Cost.Text = "5";
            }
        }

        

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Id.Text = "";
            btnSave.Enabled = true;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            GetVideos();
            txt_Title.Focus();
            if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                txt_Cost.Text = "2";
            }
            else
            {
                txt_Cost.Text = "5";
            }
        }
    }
}
