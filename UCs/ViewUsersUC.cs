using CRUDA.Classes;
using iText.Signatures;
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
    public partial class ViewUsersUC : UserControl
    {
        List<User> u = new List<User>();// for admin to view all users login in at that time 

        public ViewUsersUC()
        {
            InitializeComponent();
        }
        private void PopulateItems(int x) {


            UserDataUC[] listitems= new UserDataUC[x];
            for (int i = 0; i < x; i++) {

                listitems[i] = new UserDataUC(u[i]);
                //if (flowLayoutPanel1.Controls.Count > 0) {
                //    flowLayoutPanel1.Controls.Clear();

                //}

                flowLayoutPanel1.Controls.Add(listitems[i]);
               
            }

        
        }

        private void getUser() {

            var con2 = Configuration.getInstance().getConnection();
          
            SqlCommand cmd2 = new SqlCommand($"select * from Users", con2);

            
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
              User  z =new User (reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
              u.Add(z);
            }
            reader.Close();
            cmd2.ExecuteNonQuery();


        }
        private int countUsers() {
            int x=0;
            var con = Configuration.getInstance().getConnection();
           
            SqlCommand cmd = new SqlCommand($"SELECT Count(*) FROM USERS ", con);

         
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                x = (reader.GetInt32(0));
            }
            reader.Close();
            cmd.ExecuteNonQuery();
           


            return x;
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewUsersUC_Load(object sender, EventArgs e)
        {
            try
            {
                int x = countUsers();
                getUser();
                PopulateItems(x);
            }catch(Exception ex) { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
         
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbx_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
