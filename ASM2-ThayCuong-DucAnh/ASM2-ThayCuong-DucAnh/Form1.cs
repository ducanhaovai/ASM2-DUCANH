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
    public partial class fLogin : Form
    {
        //ket noi toi sv SQL
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        

        public fLogin()
        {
            InitializeComponent();
            // dung de ket noi sql server
            con = new SqlConnection("server=AGEN1-KHABANH;database=ASM2-LIBRARY-DucAnh;uid=sa;pwd=123456;MultipleActiveResultSets=true");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //khoi tao ham
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(tbUsernameLG.Text=="admin" && tbPasswordLG.Text=="admin123")
            {
                fProgram fp = new fProgram();
                this.Hide();
                fp.Show();
                MessageBox.Show("Login Success !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (tbUsernameLG.Text == "" && tbPasswordLG.Text == "")
                {
                    MessageBox.Show("Can't leave username or password blank");
                }
                else
                {
                    try
                    {
                        //tao sql command de thuc thi lenh sql
                        cmd = new SqlCommand();
                        con.Open();
                        cmd.Connection = con;
                        //thuc thi cau lenh trong sql
                        cmd.CommandText = ("SELECT * FROM Login where Username='" + tbUsernameLG.Text + "' and Password ='" + tbPasswordLG.Text + "'");
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login Success !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RestPass p = new RestPass();
                            this.Hide();
                            p.Show();
                            con.Close();

                        }
                        else
                        {
                            MessageBox.Show("Login Failed. Check User or Password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            con.Close();
                        }
                    }
                    catch
                    {
                        //   MessageBox.Show("Loi");
                    }
                    finally
                    {
                        con.Close();
                    }





                }
            }
            
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We will move you to Register!", "Register!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            fRegister R = new fRegister();
            this.Hide();
            R.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We will move you to change password!", "Change!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RestPass p = new RestPass();
            this.Hide();
            p.Show();
        }
    }
}
