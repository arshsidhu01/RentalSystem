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
    public partial class PopularVideo : Form
    {
        SQLQueries objContext = new SQLQueries();
        public PopularVideo()
        {
            InitializeComponent();
        }

        private void PopularVideo_Load(object sender, EventArgs e)
        {
            MostPopularVideo();
        }
        private void MostPopularVideo()
        {
            DataTable dt = new DataTable();
            dt = objContext.MostPopularVideo();

            gridPopularVideo.DataSource = dt;
        }
    }
}
