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
using CRUDA.Classes;
using CRUDA.Forms;
namespace CRUDA.UCs
{
    public partial class ViewProducts : UserControl
    {
        ProductViewSeller u;
        User user;
        int availablitycheck=0;
        int cart_id=0;
        int sellerid=0;
        public ViewProducts(ProductViewSeller u, User user, int cart_id)
        {
            InitializeComponent();
            this.u = u;
            this.user = user;
            this.cart_id = cart_id;
            ProductName_lbl.Text = u.Name;
            likes_lbl.Text = u.LikesCount.ToString();
            review_lbl.Text = u.ReviewsCount.ToString();
            description_lbl.Text = u.Description;

            availablitycheck = u.Available;
            if (availablitycheck == 1)
            {
                avalaibilityImg.Image = CRUDA.Properties.Resources.icons8_checked_20;
            }
            else
            {
                avalaibilityImg.Image = CRUDA.Properties.Resources.icons8_no_20;

            }

            sellerName_lbl.Text = u.Seller;
            category_lbl.Text = u.ProductCategory;
            price_lbl.Text = u.Price.ToString() + " PKR";


        }
        public ViewProducts(ProductViewSeller u, User user )
        {
            InitializeComponent();
            this.u = u;
            this.user = user;   
            this.cart_id = cart_id;     
            ProductName_lbl.Text = u.Name;
            likes_lbl.Text = u.LikesCount.ToString();
            review_lbl.Text = u.ReviewsCount.ToString();
            description_lbl.Text = u.Description;

            availablitycheck = u.Available;
            if (availablitycheck == 1)
            {
                avalaibilityImg.Image = CRUDA.Properties.Resources.icons8_checked_20;
            }
            else {
                avalaibilityImg.Image = CRUDA.Properties.Resources.icons8_no_20;

            }

            sellerName_lbl.Text = u.Seller;
            category_lbl.Text = u.ProductCategory;
            price_lbl.Text = u.Price.ToString()+" PKR";


        }

        private void pictureProduct_Click(object sender, EventArgs e)
        {

        }

        private void Cart_Btn_Click(object sender, EventArgs e)
        {
            if (user.UserRole == "") {
                MessageBox.Show("Login In First To Do the Action");

            }
            if (user.UserRole == "Buyer" && cart_id!=0)
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();

                    SqlCommand cmd = new SqlCommand("INSERT INTO CartItems(CartID,ProductID )  VALUES (@CID,@PID )", con);
                    cmd.Parameters.AddWithValue("@CID", cart_id);
                    cmd.Parameters.AddWithValue("@PID", u.ProductID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(u.Name+" added to Cart" ); 

                }
                catch (Exception exp) { }

            }
        }

        private void cart_btn2_Click(object sender, EventArgs e)
        {
            if (user.UserRole == "")
            {
                MessageBox.Show("Login In First To Do the Action");

            } else if (user.UserRole == "Buyer") {

                Form f = new NotificationForm(u,user);
                f.ShowDialog();
            }


        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            ProductName_lbl.Text = u.Name;
            likes_lbl.Text = u.LikesCount.ToString();
            review_lbl.Text = u.ReviewsCount.ToString();
            description_lbl.Text = u.Description;

            availablitycheck = u.Available;
            if (availablitycheck == 1)
            {
                avalaibilityImg.Image = CRUDA.Properties.Resources.icons8_checked_20;
            }
            else
            {
                avalaibilityImg.Image = CRUDA.Properties.Resources.icons8_no_20;

            }

            sellerName_lbl.Text = u.Seller;
            category_lbl.Text = u.ProductCategory;
            price_lbl.Text = u.Price.ToString() + " PKR";


            check_seller();


            var con2 = Configuration.getInstance().getConnection();

            SqlCommand cmd2 = new SqlCommand($" select Product_Img  from ProductsImg where ProductID = @ProductID", con2);
            cmd2.Parameters.AddWithValue("@ProductID",u.ProductID);

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string z = (reader.GetString(0));
                pictureProduct.ImageLocation = z;
            }
            reader.Close();
            cmd2.ExecuteNonQuery();

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductName_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sellerName_lbl_Click(object sender, EventArgs e)
        {

        }

        private void category_lbl_Click(object sender, EventArgs e)
        {

        }

        private void price_lbl_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void review_lbl_Click(object sender, EventArgs e)
        {

        }

        private void likes_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void description_lbl_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void avalaibilityImg_Click(object sender, EventArgs e)
        {

        }


        private void check_seller() {
            var con8 = Configuration.getInstance().getConnection();

            SqlCommand cmd8 = new SqlCommand($" select AddedByUserID from Products where ProductID={u.ProductID}", con8);
       

            SqlDataReader reader = cmd8.ExecuteReader();
            while (reader.Read())
            {
                 sellerid = (reader.GetInt32(0));
               
            }
            reader.Close();
            cmd8.ExecuteNonQuery();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form x = new MessageForm( user.UserID, sellerid);
            x.ShowDialog();
        }
    }
}
