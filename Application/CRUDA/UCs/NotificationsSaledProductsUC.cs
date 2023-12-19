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
namespace CRUDA.UCs
{
    public partial class NotificationsSaledProductsUC : UserControl
    {
        User user;

        public NotificationsSaledProductsUC(User user)
        {
            InitializeComponent();
            this.user = user;   
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void view()
        {
            dataGridView1.DataSource = null;
            var con2 = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand($"SELECT \r\n    Carts.cartID,\r\n    Orders.OrderID,\r\n    Billing.BillingID,\r\n    Billing.TotalPrice AS BillingPrice,\r\n    Billing.[AmountRecived],\r\n    Billing.[AmountReturned],\r\n    Billing.DateOfBilling\r\nFROM\r\n    Billing\r\nJOIN Orders ON Billing.OrdersID = Orders.OrderID\r\nJOIN Carts ON Orders.CartID = Carts.cartID\r\njoin CartItems on cartitems.CartID=Carts.CartID\r\njoin Products on CartItems.ProductID=Products.ProductID", con2);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;



        }
        private void view2()// seller
        {
            dataGridView1.DataSource = null;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand($"SELECT\r\n    Carts.cartID,\r\n    Orders.OrderID,\r\n    Billing.BillingID,\r\n    Billing.TotalPrice AS BillingPrice,\r\n    Billing.[AmountRecived],\r\n    Billing.[AmountReturned],\r\n    Billing.DateOfBilling\r\nFROM\r\n    Billing\r\nJOIN Orders ON Billing.OrdersID = Orders.OrderID\r\nJOIN Carts ON Orders.CartID = Carts.cartID\r\njoin CartItems on cartitems.CartID=Carts.CartID\r\njoin Products on CartItems.ProductID=Products.ProductID\r\nWHERE\r\n     Products.AddedByUserID = {user.UserID}", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;



        }
        private void refresh()
        {
            dataGridView1.Controls.Clear();
            dataGridView1.Columns.Clear();


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NotificationsSaledProductsUC_Load(object sender, EventArgs e)
        {
            if (user.UserRole == "Admin")
            {
                refresh();
                view();
            }
            else {
                refresh();
                view2();
            }
            
        }
    }
}
