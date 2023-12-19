using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.tool.xml.html;
using Image = System.Drawing.Image;
using iText.IO.Image;
using CRUDA.Forms;
using CRUDA.Classes;
using CRUDA.UCs;
using System.Web.UI.Design.WebControls;
using System.Data.SqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace CRUDA
{
    public partial class DashBoard : Form
    {


        User u = new User();

        bool studentlist;
        int cart_id_buyer = 0;

        public DashBoard()
        {
            InitializeComponent();

        }
        public DashBoard(User u)
        {
            InitializeComponent();
            this.u = u;
        }

      



        //
        private void pParent_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadform(object form)
        {


            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pParent.Controls.Add(f);
            this.pParent.Tag = f;
            f.Show();





        }
        public void loadc(object usercontrol)
        {

            UserControl f = usercontrol as UserControl;
            //f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pParent.Controls.Add(f);
            this.pParent.Tag = f;
            f.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStriplblDate.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
            toolStriplblTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");



        }




        private void load_buyer_cart()
        {


            if (u.UserRole == "Buyer")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Carts(UserID, Date, Ended)   OUTPUT INSERTED.CartID VALUES(@userID, @date_added, @date_ended)", con);
                    cmd.Parameters.AddWithValue("@userID", (u.UserID));
                    cmd.Parameters.AddWithValue("@date_added", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@date_ended", string.Empty);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetInt32(0) != null && reader.GetInt32(0) != 0)
                        {
                            cart_id_buyer = (reader.GetInt32(0));

                        }
                    }

                    cmd.ExecuteNonQuery();



                }
                catch (Exception exp) { }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (u.UserRole == "")// viewer
            {
                loadc(new ViewProductViewer(u));
            }
            else if (u.UserRole == "Admin")
            {
                txtSearch.Visible = false;
                picSearch.Visible = false;
                accountlbl.Text = u.UserName;
                op3.Text = "Communication Details";
                op3.Visible = true;
                op2.Text = "Sold Orders";
                op2.Visible = true;
                op1.Text = "View Users";
                op1.Visible = true;

            }
            else if (u.UserRole == "Seller")
            {
                txtSearch.Visible = false;
                picSearch.Visible = false;
                accountlbl.Text = u.UserName;
                op5.Text = "Received Messages";
                op5.Visible = true;
                op4.Text = "Send Messages";
                op4.Visible = true;
                op3.Text = "Sold Orders";
                op3.Visible = true;
                op2.Text = "View Product Reviews";
                op2.Visible = true;
                op1.Text = "Add Product";
                op1.Visible = true;

            }
            else if (u.UserRole == "Buyer")
            {
                load_buyer_cart();
                txtSearch.Visible=true;
                picSearch.Visible = true;
                accountlbl.Text = u.UserName;
                op5.Text = "Received Messages";
                op5.Visible = true;
                op4.Text = "Send Messages";
                op4.Visible = true;
                op3.Text = "Billing";
                op3.Visible = true;
                op2.Text = "View Cart";
                op2.Visible = true;
                op1.Text = "All Products";
                op1.Visible = true;
                loadc(new ViewProductViewer(u,cart_id_buyer));
            }
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pParent.Controls.Clear();
            //loadc(new StudentListControl());
        }

        private void rubricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pParent.Controls.Clear();
            //loadc(new RubricLevelC());
        }

        // public void openSL() { loadform(new StudentListForm()); }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }// In Form1



        private void label1_Click_1(object sender, EventArgs e)
        {
            this.pParent.Controls.Clear();
            //loadc(new StudentRC());
        }


        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rubericLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.pParent.Controls.Clear();
            //loadc(new AssessCompC());

        }

        private void assessmentComponentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.pParent.Controls.Clear();
            //loadc(new ViewAttendanceC());
        }



        private void toolStriplblAllRight_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void op2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void account_Click(object sender, EventArgs e)
        {

            if (u.UserRole == "")// viewer
            {
                LoginForm x = new LoginForm();
                x.Show();
                this.Close();
            }
        }

        private void accountimg_Click(object sender, EventArgs e)
        {

            if (u.UserRole == "")// viewer
            {
                LoginForm x = new LoginForm();
                x.Show();
                this.Close();
            }
        }

        private void GoToAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void op1_Click_1(object sender, EventArgs e)
        {
            if (u.UserRole == "")// viewer
            {

            }
            else if (u.UserRole == "Admin")
            {
                this.pParent.Controls.Clear();
                loadc(new ViewUsersUC());
            }
            else if (u.UserRole == "Seller")
            {
                this.pParent.Controls.Clear();
                loadc(new AddProduct_UC(u, false));
            }
            else {
                picSearch.Visible = true;
                txtSearch.Visible = true;
                this.pParent.Controls.Clear();
                loadc(new ViewProductViewer(u,cart_id_buyer));

            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.pParent.Controls.Clear();

            loadc(new ViewProductViewer(u, cart_id_buyer, txtSearch.Text, true));

        }

        private void op4_Click(object sender, EventArgs e)
        {
            if (u.UserRole == "")// viewer
            {

            }
            else if (u.UserRole == "Admin")
            {

            }
            else if (u.UserRole == "Seller")
            {
                this.pParent.Controls.Clear();

                loadc(new MessagesUC(u.UserID,u,false));
            }
            else
            {
                txtSearch.Visible = false;
                picSearch.Visible = false;
                this.pParent.Controls.Clear();

                loadc(new MessagesUC(u.UserID,u,false));

            }
        }

        private void op2_Click_1(object sender, EventArgs e)
        {

            if (u.UserRole == "")// viewer
            {

            }
            else if (u.UserRole == "Admin")
            {
                this.pParent.Controls.Clear();

                loadc(new NotificationsSaledProductsUC(u));
            }
            else if (u.UserRole == "Seller")
            {
                this.pParent.Controls.Clear();

                loadc(new ViewReviewsUC(u));
            }
            else
            {
                txtSearch.Visible = false;
                picSearch.Visible = false;
                this.pParent.Controls.Clear();

                loadc(new ViewCartUC(cart_id_buyer,u.UserID));

            }

        }

        private void op3_Click(object sender, EventArgs e)
        {
            if (u.UserRole == "")// viewer
            {

            }
            else if (u.UserRole == "Admin")
            {
                this.pParent.Controls.Clear();

                loadc(new MessagesUC("Admin"));
            }
            else if (u.UserRole == "Seller")
            {
                this.pParent.Controls.Clear();

                loadc(new NotificationsSaledProductsUC(u));
            }
            else
            {
                txtSearch.Visible = false;
                picSearch.Visible = false;
                this.pParent.Controls.Clear();

                loadc(new BillingUC(cart_id_buyer, u));

            }
        }

        private void op5_Click(object sender, EventArgs e)
        { if (u.UserRole == "")// viewer
                {

                }
                else if (u.UserRole == "Admin")
                {

                }
                else if (u.UserRole == "Seller")
                {
                    this.pParent.Controls.Clear();

                    loadc(new MessagesUC(u.UserID, u,true));
                }
                else
                {
                   txtSearch.Visible = false;
                         picSearch.Visible = false;
                         this.pParent.Controls.Clear();

                    loadc(new MessagesUC(u.UserID, u,true));

                }
            
        }
    }
}
