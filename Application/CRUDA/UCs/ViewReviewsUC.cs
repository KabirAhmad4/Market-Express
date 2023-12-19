using CRUDA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDA.UCs
{
    public partial class ViewReviewsUC : UserControl
    {
        User u= new User(); 
        public ViewReviewsUC(User u)
        {
            InitializeComponent();
            this.u = u; 
        }
        private void view()
        {
            dataGridView1.DataSource = null;
            var con2 = Configuration.getInstance().getConnection();
             SqlCommand cmd2 = new SqlCommand($"  select p.Name, p.ProductCategory,ReviewByUserID,ReviewDescription,DateOfReview from ProductReviews as r join Products as p on p.ProductID=r.ProductID where P.AddedByUserID=@ID", con2);
             cmd2.Parameters.AddWithValue("@ID", u.UserID);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
             DataTable dt = new DataTable();
             da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
         


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refresh()
        {
            dataGridView1.Controls.Clear();
            dataGridView1.Columns.Clear();


        }
        private void ViewReviewsUC_Load(object sender, EventArgs e)
        {
            refresh();
            view();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblRecordSignal_Click(object sender, EventArgs e)
        {

        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbx_Enter(object sender, EventArgs e)
        {

        }
    }
}
