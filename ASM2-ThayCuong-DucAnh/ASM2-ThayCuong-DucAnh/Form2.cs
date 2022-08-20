using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ASM2_ThayCuong_DucAnh
{
    public partial class fRegister : Form

    {
        //ket noi toi sv SQL
        SqlConnection con;
        SqlCommand cmd;
        
        SqlDataReader dr;

        public fRegister()
        {
            InitializeComponent();
          
            // dung de ket noi sql server
            con = new SqlConnection("server=AGEN1-KHABANH;database=ASM2-LIBRARY-DucAnh;uid=sa;pwd=123456; MultipleActiveResultSets=True");
            con.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fLogin L = new fLogin();
            this.Hide();
            L.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btExitR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (tbIDR.Text != string.Empty || tbUsernameR.Text != string.Empty || tbPasswordR.Text != string.Empty || tbRComfim.Text != string.Empty)
            {
                if(tbPasswordR.Text == tbRComfim.Text)
                {
                    
                    cmd = new SqlCommand("select * from Login where Username='" + tbUsernameR.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        //dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();
                        
                        
                    }
                    else
                    {
                        dr.Close();
                        try
                        {
                            SqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandText = "insert into Login values(@Username,@Password,@SID)";


                            cmd1.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = tbUsernameR.Text;
                            cmd1.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = tbPasswordR.Text;
                            cmd1.Parameters.Add("@SID", SqlDbType.Int).Value = tbIDR.Text;


                            cmd1.ExecuteNonQuery();


                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                        catch (SqlException ex)

                        {
                            MessageBox.Show(ex.Message, "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void fRegister_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("server=AGEN1-KHABANH;database=ASM2-LIBRARY-DucAnh;uid=sa;pwd=123456");
            con.Open();
        }
    }
}
