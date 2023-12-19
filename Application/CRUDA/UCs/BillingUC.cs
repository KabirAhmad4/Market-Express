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
using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using iTextSharp.tool.xml.html;
using Image = System.Drawing.Image;
using iText.IO.Image;
using System.IO;


namespace CRUDA.UCs
{
    public partial class BillingUC : UserControl
    {
        int cart_id = 0;
        User u= new User();
        Decimal price=0;
        int orderID=0;
        Decimal price_recived = 0;
        Decimal price_returned = 0;
        string filePath = "";
        string passsName="";
        int count = 0;

        public BillingUC(int cart_id, User u)
        {
            InitializeComponent();
            this.cart_id = cart_id;
            this.u = u;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void getCount()
        {
            try
            {
                var con7 = Configuration.getInstance().getConnection();

                SqlCommand cmd7 = new SqlCommand($"\r\n   SELECT count(Products.Price) \r\nFROM Orders\r\nJOIN Carts ON Orders.cartID = Carts.cartID\r\nJOIN CartItems ON Carts.cartID = CartItems.CartID\r\nJOIN Products ON CartItems.ProductID = Products.ProductID\r\nWHERE Orders.cartID = {cart_id}", con7);


                SqlDataReader reader = cmd7.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) != null && reader.GetInt32(0) != 0)
                    {
                        count = reader.GetInt32(0);

                    }


                }
                reader.Close();
                cmd7.ExecuteNonQuery();
            }
            catch (Exception exp) { }

        }

        private void getPrice()
        {
            try
            {
                var con2 = Configuration.getInstance().getConnection();

                SqlCommand cmd2 = new SqlCommand($"\r\n  SELECT SUM(Products.Price) AS TotalPrice\r\nFROM Orders\r\nJOIN Carts ON Orders.cartID = Carts.cartID\r\nJOIN CartItems ON Carts.cartID = CartItems.CartID\r\nJOIN Products ON CartItems.ProductID = Products.ProductID\r\nWHERE Orders.cartID = {cart_id}", con2);


                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetDecimal(0) != null )
                    {
                         price = reader.GetDecimal(0);
                  
                    }


                }
                reader.Close();
                cmd2.ExecuteNonQuery();
            }
            catch (Exception exp) { }

        }

        private void getOrderID()
        {

            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand($"\r\n   SELECT max(Orders.OrderID) as order_ID\r\nFROM Orders\r\nJOIN Carts ON Orders.cartID = Carts.cartID\r\nJOIN CartItems ON Carts.cartID = CartItems.CartID\r\nJOIN Products ON CartItems.ProductID = Products.ProductID\r\nWHERE Orders.cartID = {cart_id}", con);


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(0)!= null && reader.GetInt32(0) != 0)
                {
                    orderID = reader.GetInt32(0);
                }

            }
            reader.Close();
            cmd.ExecuteNonQuery();


        }


        private void BillingUC_Load(object sender, EventArgs e)
        {
            try
            {
                getOrderID();
                getPrice();
                getCount();
                Name_lbl.Text = u.UserName;
                Count_Lbl.Text = count.ToString();
                Price_lbl.Text = price.ToString();
                OrderID_lbl.Text = orderID.ToString();
            }
            catch (Exception ex) { }


        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
           
              
            

            try
            {
                price_recived = decimal.Parse(Amount_text.Text);
                price_returned = decimal.Parse(remaining_lbl.Text);
                var con5 = Configuration.getInstance().getConnection();

                SqlCommand cmd5 = new SqlCommand($"INSERT into Billing  VALUES({orderID},{price},{price_recived},{price_returned},@date_added)", con5);

                cmd5.Parameters.AddWithValue("@date_added", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));



                cmd5.ExecuteNonQuery();
                MessageBox.Show(" Payment Done ^-^ \n Thank You For Shopping ^-^ ");
                ExportToPDF();
                ViewBtn.Visible = true;

            }
            catch (Exception exp) { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void ExportToPDF()
        {
            string name = "Market Express";
            passsName = u.UserName;
            string l = "Order No";
          
          
            
            try
            {
                Document document = new Document(PageSize.A4, 20, 20, 20, 20);
                PdfWriter.GetInstance(document, new FileStream(passsName +"("+orderID +")"+ " Reciept.pdf", FileMode.Create));
                // passenger name ()
                filePath = passsName + "(" + orderID + ")" + " Reciept.pdf";
                document.Open();
 



                iTextSharp.text.Font headingFont = FontFactory.GetFont("Times New Roman", 18, iTextSharp.text.Font.BOLD);

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance("C:\\5th Semester\\SE\\Project\\ShopNexus\\Application\\CRUDA\\images\\icons8-cart-40.png");
                image.ScaleToFit(64, 64);
                float pageWidth = document.PageSize.Width;
                float x = (pageWidth - image.ScaledWidth) / 2;
                image.SetAbsolutePosition(x, 800);

                document.Add(image);

                Paragraph heading = new Paragraph(name, headingFont);
                heading.Alignment = Element.ALIGN_CENTER;
                heading.SpacingBefore = 10f;
                heading.SpacingAfter = 10f;

                document.Add(heading);

                LineSeparator line3 = new LineSeparator();
                document.Add(line3);


                iTextSharp.text.Font headingFont2 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading2 = new Paragraph(l + " :                                                                    " + orderID, headingFont2);// raveeha
                heading2.Alignment = Element.ALIGN_LEFT;
                heading2.SpacingBefore = 10f;
                heading2.SpacingAfter = 10f;

                document.Add(heading2);



                iTextSharp.text.Font headingFont3 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading3 = new Paragraph("Buyer Username" + " :                                                                 " + passsName, headingFont3);
                heading3.Alignment = Element.ALIGN_LEFT;
                heading3.SpacingBefore = 10f;
                heading3.SpacingAfter = 10f;

                document.Add(heading3);

                iTextSharp.text.Font headingFont4 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading4 = new Paragraph("Total Price" + " :                                                                 " + price.ToString(), headingFont4);
                heading4.Alignment = Element.ALIGN_LEFT;
                heading4.SpacingBefore = 10f;
                heading4.SpacingAfter = 10f;

                document.Add(heading4);


                iTextSharp.text.Font headingFont5 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading5 = new Paragraph("Price Received" + " :                                                                 " + price_recived.ToString(), headingFont4);
                heading5.Alignment = Element.ALIGN_LEFT;
                heading5.SpacingBefore = 10f;
                heading5.SpacingAfter = 10f;

                document.Add(heading5);

                iTextSharp.text.Font headingFont6 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading6 = new Paragraph("Price Returned" + " :                                                                 " + price_returned.ToString(), headingFont6);
                heading6.Alignment = Element.ALIGN_LEFT;
                heading6.SpacingBefore = 10f;
                heading6.SpacingAfter = 10f;

                document.Add(heading6);




                document.Close();
            }
            catch (Exception exp) { MessageBox.Show("Fill all the columns of table (status) it can not be null"); }
            // Close the document
        }





        private void ViewBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
       


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                
                Price_lbl.Text = price.ToString();
                OrderID_lbl.Text = orderID.ToString();
                price_recived = int.Parse(Amount_text.Text);
                price_returned = -price + price_recived;
                remaining_lbl.Text = price_returned.ToString();

            }
            catch (Exception exp) { }
        }
    }
}
