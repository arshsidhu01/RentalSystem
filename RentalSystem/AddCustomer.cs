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
    public partial class AddCustomer : Form
    {
        SQLQueries objContext = new SQLQueries();
        public AddCustomer()
        {
            InitializeComponent();
        }
        private void txt_sr_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbName"].ConnectionString);
                //  conn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adp = new SqlDataAdapter();
                DataSet ds1 = new DataSet();
                cmd = new SqlCommand("select * from Customer where FirstName like '" + txt_sr.Text + "%'", conn);
                adp.SelectCommand = cmd;
                ds1.Clear();
                adp.Fill(ds1, "Customer");
                gridCustomer.DataSource = ds1.Tables["Customer"];
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbName"].ConnectionString);
                // conn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adp = new SqlDataAdapter();
                DataSet ds1 = new DataSet();
                cmd = new SqlCommand("select * from Customer where LastName like '" + txt_sr.Text + "%'", conn);
                adp.SelectCommand = cmd;
                ds1.Clear();
                adp.Fill(ds1, "Customer");
                gridCustomer.DataSource = ds1.Tables["Customer"];
            }
            else
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbName"].ConnectionString);
                //conn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adp = new SqlDataAdapter();
                DataSet ds1 = new DataSet();
                cmd = new SqlCommand("select * from Customer where Phone like '" + txt_sr.Text + "%'", conn);
                adp.SelectCommand = cmd;
                ds1.Clear();
                adp.Fill(ds1, "Customer");
                gridCustomer.DataSource = ds1.Tables["Customer"];
            }
        }
        private void gridCustomer_Click(object sender, EventArgs e)
        {
            if (gridCustomer.Rows.Count > 0)
            {
                Id.Text = gridCustomer.CurrentRow.Cells[0].Value.ToString();
                txt_FirstName.Text = gridCustomer.CurrentRow.Cells[1].Value.ToString();
                txt_LastName.Text = gridCustomer.CurrentRow.Cells[2].Value.ToString();
                txt_Address.Text = gridCustomer.CurrentRow.Cells[3].Value.ToString();
                txt_Phone.Text = gridCustomer.CurrentRow.Cells[4].Value.ToString();
                btnSave.Enabled = false;
                btn_edit.Enabled = true;
                btn_del.Enabled = true;
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Empty();
            Id.Text = "";
            //txt_custno.Enabled = true;
            btnSave.Enabled = true;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            getCustomer();
            txt_FirstName.Focus();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {

            objContext.CustomerEdit(txt_FirstName.Text, txt_LastName.Text, txt_Address.Text, txt_Phone.Text, Convert.ToInt32(Id.Text));
                Id.Text = "";
            Empty();
            getCustomer();
            MessageBox.Show("Successfully Update Customer");
            btnSave.Enabled = true;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
           

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool custValid = validateChaek();
            if (custValid == true)
            {
                objContext.InsertNewCustomer(txt_FirstName.Text, txt_LastName.Text, txt_Address.Text, txt_Phone.Text);
                Id.Text = "";
                Empty();
                getCustomer();
                MessageBox.Show("Successfully Add Customer");
                btnSave.Enabled = true;
                btn_edit.Enabled = false;
                btn_del.Enabled = false;
               
            }

        }
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            getCustomer();
            btnSave.Enabled = true;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            comboBox1.SelectedIndex = 0;
        }
        public void getCustomer()
        {
            DataTable dt = new DataTable();

            dt = objContext.getCustomer();

            gridCustomer.DataSource = dt;
        }
        private void Empty()
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
        private void btn_del_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE??", "Customer Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                objContext.Delete_Customer(Convert.ToInt32(Id.Text));
                    Id.Text = "";
                    Empty();
                    getCustomer();
                    MessageBox.Show("Successfully Delete Customer");
                    btnSave.Enabled = true;
                    btn_edit.Enabled = false;
                    btn_del.Enabled = false;
               
               
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        

       

       
        public bool validateChaek()
        {
            if (string.IsNullOrEmpty(txt_FirstName.Text))
            {
                MessageBox.Show("First Name is required");
                return false;
            }
            else if (string.IsNullOrEmpty(txt_LastName.Text))
            {
                MessageBox.Show("Last Name is required");
                return false;
            }
            else if (string.IsNullOrEmpty(txt_Address.Text))
            {
                MessageBox.Show("Address is required");
                return false;
            }
            else if (string.IsNullOrEmpty(txt_Phone.Text))
            {
                MessageBox.Show("Phone No. is required");
                return false;
            }
            return true;
        }
    }
}
