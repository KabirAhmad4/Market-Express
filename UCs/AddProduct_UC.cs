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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using CRUDA.Classes; 
namespace CRUDA.UCs
{
    public partial class AddProduct_UC : UserControl
    {
        User U;
        bool checkUpdate;
        Product p = new Product();
        string imglocation= string.Empty;
        bool checkimg=false;
        bool addproduct = false;
        bool check_n = false;
        bool check_c = false;
        bool check_products_img_count = false;
        bool check_price = false;

        public AddProduct_UC(User u, bool checkUpdate)
        {
            InitializeComponent();
            U = u;
            checkUpdate = checkUpdate;
        }
        private void clear()
        {
            txtbxName.Text = string.Empty;

            txtCategory.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            descriptiontxt.Text = string.Empty;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clear();

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
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
         
                if (checkUpdate == false)
                {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Products values (@AddedByUserID,@Name,@Description,@ProductCategory,@Price,@Quantity,@LikesCount,@ReviewsCount,@Available)", con);
                    cmd.Parameters.AddWithValue("@AddedByUserID", (U.UserID));
                    cmd.Parameters.AddWithValue("@Name", txtbxName.Text);
                    cmd.Parameters.AddWithValue("@Description", descriptiontxt.Text);
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@ProductCategory", txtCategory.Text);
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@LikesCount", 0);
                    cmd.Parameters.AddWithValue("@ReviewsCount", 0);
                    cmd.Parameters.AddWithValue("@Available", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Added");
                    con.Close();
                    checkUpdate = false;
                    checkimg = false;
                    imglocation = string.Empty;
                }
                catch (Exception exp) { }
            }
            
            else
            {
                try
                {
                    var con2 = Configuration.getInstance().getConnection();
                    con2.Open();
                    SqlCommand cmd2 = new SqlCommand("Update Products Set AddedByUserID=@AddedByUserID,Name=@Name,Description=@Description,ProductCategory=@ProductCategory,Price=@Price,Quantity=@Quantity,LikesCount=@LikesCount,ReviewsCount=@ReviewsCount,Available=@Available  WHERE ProductID = @ProductID", con2);

                    cmd2.Parameters.AddWithValue("@AddedByUserID", (p.AddedByUserID));
                    cmd2.Parameters.AddWithValue("@Name", txtbxName.Text);
                    cmd2.Parameters.AddWithValue("@Description", descriptiontxt.Text);
                    cmd2.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cmd2.Parameters.AddWithValue("@ProductCategory", txtCategory.Text);
                    cmd2.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                    cmd2.Parameters.AddWithValue("@LikesCount", p.LikesCount);
                    cmd2.Parameters.AddWithValue("@ReviewsCount", p.ReviewsCount);
                    cmd2.Parameters.AddWithValue("@Available", 1);
                    cmd2.Parameters.AddWithValue("@ProductID", p.ProductID);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully");
                    con2.Close();

                    checkUpdate = false;



                }
                catch (Exception exp) { }
            }
         
            refresh();
            view();
            DataBind();
        }
        private void view()
        {
            var con2 = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("Select * from products where AddedByUserID=@Id", con2);
            cmd2.Parameters.AddWithValue("@ID", U.UserID);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            con2.Close();


        }
        private void DataBind()
        {
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.Text = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(Update);
       

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dataGridView1.CurrentCell.ColumnIndex;
            if (index == 10)
            {

                checkUpdate = true;

                txtbxName.Text = p.Name;
                txtCategory.Text = p.ProductCategory;
                txtPrice.Text = p.Price.ToString();
                txtQuantity.Text = p.Quantity.ToString();
                descriptiontxt.Text = p.Description;

            }



        }

        private void btnview_Click(object sender, EventArgs e)
        {
            refresh();
            view();
            DataBind();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (checkUpdate == true)
            {
                btnAddProduct.Text = "Update";
                pictureBox1.Visible = false;
                productimg.Visible = false;
            }
            else
            {
                btnAddProduct.Text = "Add";
                pictureBox1.Visible = true;
                productimg.Visible = true;
            }

            if (p.ProductID != null ) {

                addproduct = true;
                check();
            }
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                p.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                p.AddedByUserID = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                p.Name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                p.Description = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                p.ProductCategory = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                p.Price = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                p.Quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                p.LikesCount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                p.ReviewsCount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
                if (dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString() == "true")
                {
                    p.Available = 1;
                }
                else { p.Available = 0; }
                
                MessageBox.Show("You have Selected Product of Product ID = " + p.ProductID.ToString());
            }
            catch (Exception ex) { }
        }

        private void AddProduct_UC_Load(object sender, EventArgs e)
        {

        }

        private void check() {

            try
            {
                var con4 = Configuration.getInstance().getConnection();
                SqlCommand cmd4 = new SqlCommand($"  select count(*) FROM ProductsImg WHERE ProductID = '{p.ProductID}' ", con4);
                int X = 0;
                SqlDataReader reader = cmd4.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) != null && reader.GetInt32(0) !=0) {
                        X = (reader.GetInt32(0));

                    }
                }
                reader.Close();
                if (X == 1)
                {

                    check_products_img_count = true;
                }
                else {

                    check_products_img_count = false;
                }

                // X=cmd.ExecuteReader().GetString(0);
                cmd4.ExecuteNonQuery();
                
            }
            catch (Exception exp) { }


        }


        private void productimg_Click(object sender, EventArgs e)
        {
            check();
            MessageBox.Show("To Add Image first add the product and then select the product from the list and then upload the image of the product");
            if (addproduct && !check_products_img_count)
            {
                MessageBox.Show("You have Selected Product of Product ID = "+p.ProductID.ToString());
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        imglocation = dialog.FileName.ToString();
                        pictureBox1.ImageLocation = imglocation;
                    }
                }
                catch (Exception ex) { }

                if (imglocation != string.Empty)
                {
                    checkimg = true;
                }
                if (checkimg) {

                    try
                    {
                        var con3 = Configuration.getInstance().getConnection();
                        con3.Open();
                        SqlCommand cmd3 = new SqlCommand("Insert into ProductsImg values (@Product_Img,@ProductID)", con3);
                        cmd3.Parameters.AddWithValue("@ProductID", p.ProductID);
                        cmd3.Parameters.AddWithValue("@Product_Img", imglocation);
                        cmd3.ExecuteNonQuery();
                        con3.Close();
                            
                        MessageBox.Show("Product Img  Successfully Added");
                        

                    }
                    catch (Exception exp) { }

                }


            }
            else {

                MessageBox.Show("First Add the Product and then Select the product To upload / insert the image");

            }


        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxName.Text == string.Empty)
            {// check is empty
                lblNameSingal.Text = "Enter the name";
                check_n = false;
            }
            //else if (int.TryParse(Firsttxtbx.Text, out i))
            //{//Check isnumberic
            //    lblFirstNameSingal.Text = "Allowed characters: a-z, A-Z";
            //    check_f = false;
            //}
            else if (txtbxName.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lblNameSingal.Text = "Allowed characters: a-z, A-Z";
                check_n = false;
            }
            else
            {//ready for storage or action
                lblNameSingal.Text = " ";
                check_n = true;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
                int price;
                if (txtPrice.Text == string.Empty)
                {
                    lblPriceSignal.Text = "Enter the price";
                    check_price = false;
                }
                else if (!int.TryParse(txtPrice.Text, out price) || price >= 1000000)
                {
                    lblPriceSignal.Text = "Enter a valid price (less than 1000000)";
                    check_price = false;
                }
                else
                {
                    lblPriceSignal.Text = " ";
                    check_price = true;
                }
            

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtCategory.Text == string.Empty)
            {// check is empty
                lbllCategorySignal.Text = "Enter the data";
                check_c = false;
            }
            //else if (int.TryParse(Firsttxtbx.Text, out i))
            //{//Check isnumberic
            //    lblFirstNameSingal.Text = "Allowed characters: a-z, A-Z";
            //    check_f = false;
            //}
            else if (txtCategory.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lbllCategorySignal.Text = "Allowed characters: a-z, A-Z";
                check_c = false;
            }
            else
            {//ready for storage or action
                lbllCategorySignal.Text = " ";
                check_c = true;
            }
        }
    }
}
