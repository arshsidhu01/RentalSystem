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
    public partial class RegularCustomer : Form
    {
        SQLQueries objContext = new SQLQueries();
        public RegularCustomer()
        {
            InitializeComponent();
        }

        private void RegularCustomer_Load(object sender, EventArgs e)
        {
            RegularCustomerFill();
        }
        private void RegularCustomerFill()
        {
            DataTable regular_dt = new DataTable();
            regular_dt = objContext.regularCustomerList();

            gridRegularCustomer.DataSource = regular_dt;
        }
    }
}
