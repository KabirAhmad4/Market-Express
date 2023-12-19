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
namespace CRUDA.Forms
{
    public partial class MessageForm : Form
    {
        int seller = 0;
        int buyer =0;
        public MessageForm(int seller, int buyer)
        {
            InitializeComponent();
            this.seller = seller;
            this.buyer = buyer;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            ProductRview_lbl.Text = "You are Messaging Reciever of ID= "+ buyer+ " right now";
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand($"Insert into Communications values ({seller},{buyer},@Message_txt,@DateOfReview)", con);


                cmd.Parameters.AddWithValue("@Message_txt", review_txt.Text);
                cmd.Parameters.AddWithValue("@DateOfReview", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Message Successfully Send ");


            }
            catch (Exception exp) { }

            this.Close();
        }
    }
}
