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

namespace CRUDA.UCs
{
    public partial class UserDataUC : UserControl
    {
        public User u;
        public UserDataUC(User u)
        {
            InitializeComponent();
            this.u = u;
            ID_lbl.Text = u.UserID.ToString();
            Username_lbl.Text = u.UserName;
            Pass_lbl.Text = u.Password;
            FirstName_lbl.Text = u.FirstName;
            LastName_lbl.Text = u.LastName;
            EMAIL_lbl.Text = u.Email;
            Gender_lbl.Text = u.Gender;
            Role_lbl.Text = u.UserRole;
            Contact_lbl.Text = u.Contact;
        }
      
        



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UserDataUC_Load(object sender, EventArgs e)
        {
            ID_lbl.Text = u.UserID.ToString();
            Username_lbl.Text = u.UserName;
            Pass_lbl.Text = u.Password;
            FirstName_lbl.Text = u.FirstName;
            LastName_lbl.Text = u.LastName;
            EMAIL_lbl.Text = u.Email;
            Gender_lbl.Text = u.Gender;
            Role_lbl.Text = u.UserRole;
            Contact_lbl.Text = u.Contact;

            ID_lbl.Visible = true;
            Username_lbl.Visible = true;
            Pass_lbl.Visible = true;
            FirstName_lbl.Visible = true;
            LastName_lbl.Visible = true;
            EMAIL_lbl.Visible = true;
            Gender_lbl.Visible = true;
            Role_lbl.Visible = true;
            Contact_lbl.Visible = true;


        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
