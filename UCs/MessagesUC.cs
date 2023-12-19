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
using CRUDA.Forms;
namespace CRUDA.UCs
{
    public partial class MessagesUC : UserControl
    {
        User u = new User();
        int sender_M;
        int reciver_M;
        string Role = "";
        bool check_received = false;
        public MessagesUC(int id1, User u, bool check_received)
        {
            InitializeComponent();
            this.sender_M = id1;
            this.u = u;
            this.check_received = check_received;
        }
        public MessagesUC(string Role)
        {
            InitializeComponent();
            this.Role = Role;   
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
        private void view()
        {
            try
            {
                dataGridView1.DataSource = null;
                var con = Configuration.getInstance().getConnection();
                
                SqlCommand cmd = new SqlCommand($"select * from Communications where sender={sender_M}", con);
           
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                
                
                dataGridView1.DefaultCellStyle.ForeColor = Color.White;
                

            }catch (Exception ex) { }

        }
        private void view3()
        {
            try
            {
                dataGridView1.DataSource = null;
                var con4 = Configuration.getInstance().getConnection();

                SqlCommand cmd4 = new SqlCommand($"select * from Communications where Receiver={sender_M}", con4);

                SqlDataAdapter da = new SqlDataAdapter(cmd4);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;



                dataGridView1.DefaultCellStyle.ForeColor = Color.White;


            }
            catch (Exception ex) { }

        }
        private void view2()
        {
            try
            {
                dataGridView1.DataSource = null;
                var con3 = Configuration.getInstance().getConnection();
                
                SqlCommand cmd3 = new SqlCommand($"select * from Communications", con3);

                SqlDataAdapter da = new SqlDataAdapter(cmd3);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd3.ExecuteNonQuery();
               
                dataGridView1.DefaultCellStyle.ForeColor = Color.White;
                
                

            }
            catch (Exception ex) { }

        }
        private void DataBind()
        {
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Message";
            Update.Text = "Message";
            Update.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(Update);


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.ColumnIndex;
            
                if (index == 0)
                {
                    Form x = new MessageForm(sender_M, reciver_M);
                    x.ShowDialog();


                }

            
            
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!check_received)
                {
                    reciver_M = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                else {

                    reciver_M = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

                }

                MessageBox.Show("You have Selected Receiver  of  ID = " + reciver_M.ToString());
            }
            catch (Exception ex) { }
        }

        private void MessagesUC_Load(object sender, EventArgs e)
        {
            if (!check_received)
            {

                if (Role == "Admin")
                {
                    refresh();
                    view2();

                }
                else
                {
                    refresh();
                    view();
                    DataBind();
                }
            }
            else {

                if (Role == "Admin")
                {
                    refresh();
                    view2();

                }
                else
                {
                    refresh();
                    view3();
                    DataBind();

                }

            }
         
        }
    }
}
