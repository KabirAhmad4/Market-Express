using CRUDA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDA.Classes;
using System.Data.SqlClient;

namespace CRUDA.UCs
{
    public partial class ViewProductViewer : UserControl
    {
        List<ProductViewSeller> u = new List<ProductViewSeller>();// for admin to view all users login in at that time 
        User user;
        int cart_id = 0;
        bool check = false;
        string searchProduct = "";
        
        
        public ViewProductViewer(User user,int cart_id)
        {
            InitializeComponent();
            this.user = user; 
            this.cart_id = cart_id;
            check = false;
        }
        public ViewProductViewer(User user, int cart_id, string searchProduct,bool check )
        {
            InitializeComponent();
            this.user = user;
            this.cart_id = cart_id;
            this.searchProduct = searchProduct;
            this.check = check;
        }
        public ViewProductViewer(User user)
        {
            InitializeComponent();
            this.user = user;
           
        }
        private void PopulateItemsViewer(int x)
        {


            ViewProducts[] listitems = new ViewProducts[x];
            for (int i = 0; i < x; i++)
            {
                
                    listitems[i] = new ViewProducts(u[i], user);
                
              
                
                //if (flowLayoutPanel1.Controls.Count > 0) {
                //    flowLayoutPanel1.Controls.Clear();

                //}

                flowLayoutPanel1.Controls.Add(listitems[i]);

            }


        }
        private void PopulateItemsViewer2(int x)
        {


            ViewProducts[] listitems = new ViewProducts[x];
            for (int i = 0; i < x; i++)
            {
              
                   
                
                
                    listitems[i] = new ViewProducts(u[i], user, cart_id);
                

                //if (flowLayoutPanel1.Controls.Count > 0) {
                //    flowLayoutPanel1.Controls.Clear();

                //}

                flowLayoutPanel1.Controls.Add(listitems[i]);

            }


        }
        private void getProductsViewer()
        {
            try
            {
                SqlConnection con2 = Configuration.getInstance().getConnection();

                SqlCommand cmd2 = new SqlCommand($" select p.ProductID, u.UserName, p.Name,p.Description,p.ProductCategory,p.Price,p.Quantity,p.LikesCount,p.ReviewsCount,p.Available  from Users as U join Products as p on p.AddedByUserID=u.UserID ", con2);


                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetBoolean(reader.GetOrdinal("Available")))
                    {
                        ProductViewSeller z = new ProductViewSeller(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), 1);
                        u.Add(z);
                    }
                    else
                    {
                        ProductViewSeller z = new ProductViewSeller(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), 0);
                        u.Add(z);
                    }

                }
                reader.Close();
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex) { }
           
    

        }
        private int countProductsViewer()
        {
            int x = 0;
            try
            {
                SqlConnection con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand($"  select count(*)  from Users as U join Products as p on p.AddedByUserID=u.UserID", con);


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    x = (reader.GetInt32(0));
                }
                reader.Close();
                cmd.ExecuteNonQuery();

            }
            catch (Exception exp) { }


            return x;
        }




        private void getProductsViewer2()
        {
            try
            {
                SqlConnection con4 = Configuration.getInstance().getConnection();

                SqlCommand cmd4 = new SqlCommand($" select p.ProductID, u.UserName, p.Name,p.Description,p.ProductCategory,p.Price,p.Quantity,p.LikesCount,p.ReviewsCount,p.Available  from Users as U join Products as p on p.AddedByUserID=u.UserID ", con4);


                SqlDataReader reader = cmd4.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetBoolean(reader.GetOrdinal("Available")))
                    {
                        ProductViewSeller z = new ProductViewSeller(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), 1);
                        u.Add(z);
                    }
                    else
                    {
                        ProductViewSeller z = new ProductViewSeller(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), 0);
                        u.Add(z);
                    }

                }
                reader.Close();
                cmd4.ExecuteNonQuery();
            }
            catch (Exception ex) { }



        }
        private int countProductsViewer2()
        {
            int x = 0;
            try
            {
                SqlConnection con5 = Configuration.getInstance().getConnection();

                SqlCommand cmd5 = new SqlCommand($"  select count(*)  from Users as U join Products as p on p.AddedByUserID=u.UserID", con5);


                SqlDataReader reader = cmd5.ExecuteReader();
                while (reader.Read())
                {
                    x = (reader.GetInt32(0));
                }
                reader.Close();
                cmd5.ExecuteNonQuery();

            }
            catch (Exception exp) { }


            return x;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PopulateItemsViewer3(int x)
        {


            ViewProducts[] listitems = new ViewProducts[x];
            for (int i = 0; i < x; i++)
            {




                listitems[i] = new ViewProducts(u[i], user, cart_id);


                //if (flowLayoutPanel1.Controls.Count > 0) {
                //    flowLayoutPanel1.Controls.Clear();

                //}

                flowLayoutPanel1.Controls.Add(listitems[i]);

            }


        }

        private void getProductsViewer3()
        {
            try
            {
                SqlConnection con8 = Configuration.getInstance().getConnection();

                SqlCommand cmd8 = new SqlCommand($" select p.ProductID, u.UserName, p.Name,p.Description,p.ProductCategory,p.Price,p.Quantity,p.LikesCount,p.ReviewsCount,p.Available  from Users as U join Products as p on p.AddedByUserID=u.UserID     where p.Name='{searchProduct}'", con8);


                SqlDataReader reader = cmd8.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetBoolean(reader.GetOrdinal("Available")))
                    {
                        ProductViewSeller z = new ProductViewSeller(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), 1);
                        u.Add(z);
                    }
                    else
                    {
                        ProductViewSeller z = new ProductViewSeller(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), 0);
                        u.Add(z);
                    }

                }
                reader.Close();
                cmd8.ExecuteNonQuery();
            }
            catch (Exception ex) { }



        }
        private int countProductsViewer3()
        {
            int x = 0;
            try
            {
                SqlConnection con9 = Configuration.getInstance().getConnection();

                SqlCommand cmd9 = new SqlCommand($"  select count(*)  from Users as U join Products as p on p.AddedByUserID=u.UserID where p.Name='{searchProduct}'" , con9);


                SqlDataReader reader = cmd9.ExecuteReader();
                while (reader.Read())
                {
                    x = (reader.GetInt32(0));
                }
                reader.Close();
                cmd9.ExecuteNonQuery();

            }
            catch (Exception exp) { }


            return x;
        }







        private void ViewProductViewer_Load(object sender, EventArgs e)
        {
            try
            {
               

                    if (user.UserRole == "")
                {
                    if (!check)
                    {
                        int x = countProductsViewer();
                        getProductsViewer();
                        PopulateItemsViewer(x);
                    }
                    else
                    {
                        int x = countProductsViewer3();
                        getProductsViewer3();
                        PopulateItemsViewer3(x);


                    }

                    }
                    else
                    {
                      if (!check)
                      {
                            int x = countProductsViewer2();
                            getProductsViewer2();
                            PopulateItemsViewer2(x);
                      }
                      else {
                        int x = countProductsViewer3();
                        getProductsViewer3();
                        PopulateItemsViewer3(x);


                       }
                }
                


            }
            catch (Exception ex) { }
        }
    }
}
