using CRUDA.UCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDA.Forms
{
    public partial class LoginForm : Form
    {
        bool checkgo = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DashBoard x= new DashBoard();
            x.Show();
            this.Close();
        }

        private void pParent_Paint(object sender, PaintEventArgs e)
        {

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
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.pParent.Controls.Clear();
            loadc(new loginUC());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.pParent.Controls.Clear();
            loadc(new loginUC());
        }

        private void op3_Click(object sender, EventArgs e)
        {
            this.pParent.Controls.Clear();
            loadc(new SignupUC());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStriplblDate.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
            toolStriplblTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");


            if (checkgo = true) { 
            
            }

        }

        private void account_Click(object sender, EventArgs e)
        {
            checkgo = true;
        }

        private void GoToAccount_Click(object sender, EventArgs e)
        {
            checkgo = true;
        }
    }
}
