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
    public partial class SignupUC : UserControl
    {
        string first, last, registeration, email, contact;
        int id, status;
        Validation v = new Validation();



        bool f = false;
        bool l = false;
        bool u = false;
        bool p = false; bool c = true; bool ee = true;

        private void txtbxusername_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxusername.Text == string.Empty)
            {// check is empty
                lblusernameSignal.Text = "Enter the name";
                u = false;
            }
            else if (int.TryParse(txtbxusername.Text, out i))
            {//Check isnumberic
                lblusernameSignal.Text = "Allowed characters: a-z, A-Z";
                u = false;
            }
            else if (txtbxusername.Text.Any(ch => !char.IsLetter(ch)))
            {//check isSpecialCharactor
                lblusernameSignal.Text = "Allowed characters: a-z, A-Z";
                u = false;
            }
            else
            {//ready for storage or action
                lblusernameSignal.Text = " ";
                u = true;
            }
        }

        private void txtbxContactNumber_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxContactNumber.Text == string.Empty)
            {// check is empty
                lblContactNumberSignal.Text = "Enter the name";
                c = false;
            }
            if (txtbxContactNumber.Text.Any(ch => !char.IsDigit(ch)))
            {//check isSpecialCharactor
                lblContactNumberSignal.Text = "Allowed characters: 1-9";
                c = false;
            }

            else

            {//ready for storage or action
                lblContactNumberSignal.Text = " ";
                c = false;
            }
            if (v.IsValidPhoneNumber(txtbxContactNumber.Text))
            {
                lblContactNumberSignal.Text = ("Phone number is valid.");

                c = true;
            }
            
        }

        private void txtLASTName_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtLASTName.Text == string.Empty)
            {// check is empty
                lbllastNameSignal.Text = "Enter the name";
                l = false;
            }
            else if (int.TryParse(txtLASTName.Text, out i))
            {//Check isnumberic
                lbllastNameSignal.Text = "Allowed characters: a-z, A-Z";
                l = false;
            }
            else if (txtLASTName.Text.Any(ch => !char.IsLetter(ch)))
            {//check isSpecialCharactor
                lbllastNameSignal.Text = "Allowed characters: a-z, A-Z";
                l = false;
            }
            else
            {//ready for storage or action
                lbllastNameSignal.Text = " ";
                l = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Firsttxtbx.Text = string.Empty;
            txtLASTName.Text = string.Empty;
            txtbxusername.Text = string.Empty;
            txtbxEmailAddress.Text = string.Empty;
            txtbxContactNumber.Text = string.Empty;
            cmbxGender.Text = string.Empty;
            cmbxRole.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Firsttxtbx_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (Firsttxtbx.Text == string.Empty)
            {// check is empty
                lblFirstNameSingal.Text = "Enter the name";
                f = false;
            }

            else if (Firsttxtbx.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lblFirstNameSingal.Text = "Allowed characters: a-z, A-Z";
                f = false;
            }
            else
            {//ready for storage or action
                lblFirstNameSingal.Text = " ";
                f = true;
            }
        }

        bool update = false;

        public SignupUC()
        {
            InitializeComponent();
        }
        private int check()
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand($"  select count(*) FROM users WHERE email = '{txtbxEmailAddress.Text}' ", con);
            int X = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                X = (reader.GetInt32(0));
            }
            reader.Close();

            // X=cmd.ExecuteReader().GetString(0);
            cmd.ExecuteNonQuery();
            return X;


        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (f && l && u && ee)
            {







                int y = check();
                if (/*check_c && check_e && check_f && check_l && check_r*/0 < 1)
                {


                    if (update == false && y != 1)
                    {
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("Insert into Users values (@UserName,@Password,@FirstName,@LastName,@Email,@Gender,@Contact,@UserRoles)", con);
                        cmd.Parameters.AddWithValue("@FirstName", (Firsttxtbx.Text));
                        cmd.Parameters.AddWithValue("@LastName", txtLASTName.Text);
                        cmd.Parameters.AddWithValue("@UserName", txtbxusername.Text);
                        cmd.Parameters.AddWithValue("@Email", txtbxEmailAddress.Text);
                        cmd.Parameters.AddWithValue("@Contact", txtbxContactNumber.Text);
                        cmd.Parameters.AddWithValue("@Gender", cmbxGender.Text);
                        cmd.Parameters.AddWithValue("@UserRoles", cmbxRole.Text);
                        cmd.Parameters.AddWithValue("@Password", textPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Successfully Added");
                    }

                    if (y == 1) { MessageBox.Show("Already exist"); }
                }
                else
                {
                    if (y == 1) { MessageBox.Show("Already exist"); }

                    MessageBox.Show("Fill the correct data first");
                }
            }
            else {
                MessageBox.Show("Enter the Correct Data First");
            
            }
        }
    }
}
