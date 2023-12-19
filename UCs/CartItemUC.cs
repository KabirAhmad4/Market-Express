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
    public partial class CartItemUC : UserControl
    {
        User user= new User();
        int cart_id;
        Product product;
        public CartItemUC(int cartID,Product product)
        {
            InitializeComponent();
                this.cart_id = cartID;
            this.product = product;

            Name_lbl.Text = product.Name;

            descriptiontxt.Text = product.Description;

            Category_lbl.Text = product.ProductCategory;
            price_lbl.Text = product.Price.ToString() + " PKR";
        }

        private void CartItemUC_Load(object sender, EventArgs e)
        {

            Name_lbl.Text = product.Name;

            descriptiontxt.Text = product.Description;

            Category_lbl.Text = product.ProductCategory;
            price_lbl.Text = product.Price.ToString() + " PKR";





            var con2 = Configuration.getInstance().getConnection();

            SqlCommand cmd2 = new SqlCommand($" select Product_Img  from ProductsImg where ProductID = @ProductID", con2);
            cmd2.Parameters.AddWithValue("@ProductID", product.ProductID);

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string z = (reader.GetString(0));
                pictureBox1.ImageLocation = z;
            }
            reader.Close();
            cmd2.ExecuteNonQuery();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var con2 = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand($" delete from CartItems where ProductID = {product.ProductID}", con2);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Item Removed Successfully Reload to check updated Cart");
            
           
        }
    }
}
