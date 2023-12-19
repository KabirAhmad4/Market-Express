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

namespace CRUDA.Forms
{
    public partial class NotificationForm : Form
    {
        ProductViewSeller p= new ProductViewSeller();
        User u = new User();
        
        public NotificationForm(ProductViewSeller p, User u)
        {
            InitializeComponent();
            this.p = p;
            this.u = u;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
           ProductRview_lbl.Text = "You are Writing the review of : "+this.p.Name;
           


        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                
                SqlCommand cmd = new SqlCommand("Insert into ProductReviews (ProductID,ReviewByUserID,ReviewDescription,DateOfReview) values (@ProductID,@ReviewByUserID,@ReviewDescription,@DateOfReview)", con);
                cmd.Parameters.AddWithValue("@ProductID", (p.ProductID));
                cmd.Parameters.AddWithValue("@ReviewByUserID", (u.UserID));
                cmd.Parameters.AddWithValue("@ReviewDescription", (review_txt.Text));
                cmd.Parameters.AddWithValue("@DateOfReview", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Review Successfully Added");
                
               
            }
            catch (Exception exp) { }
            
            this.Close();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductRview_lbl_Click(object sender, EventArgs e)
        {

        }

        private void review_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
