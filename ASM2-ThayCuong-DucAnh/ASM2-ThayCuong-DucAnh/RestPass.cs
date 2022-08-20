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
    public partial class RestPass : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter adapt;
        public RestPass()
        {
            InitializeComponent();
            con = new SqlConnection("server=AGEN1-KHABANH;database=ASM2-LIBRARY-DucAnh;uid=sa;pwd=123456;MultipleActiveResultSets=true");
            
            
        }
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We will move you to Login!", "Login!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            fLogin l = new fLogin();
            this.Hide();
            l.Show();

        }
        
        
        private void DisplayDataBorrow()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Student_Card", con);

            adapt.Fill(dt);
            dgvBorrow_Card.DataSource = dt;
            con.Close();
        }
        private void DisplayDataBorrowCard()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Borrow_Book", con);

            adapt.Fill(dt);
            dgvBorrow_Card.DataSource = dt;
            con.Close();
        }
        



        private void btAddBC_Click(object sender, EventArgs e)
        {
            try
            {


                // tao sql command de thuc thi lenh sql
                SqlCommand cmd6 = con.CreateCommand();
                SqlCommand cmd7 = con.CreateCommand();
                // thiet lap thong so cau lenh insert
                cmd7.CommandText = "insert into Borrow_Book values (@CID,@BID) ";
                cmd6.CommandText = "insert into Student_Card values (@CID,@CName,@BorrowDate,@ReturnDate,@StudentID) ";
                con.Open();



                // truyen tham so cho cau lenh insert
                cmd7.Parameters.Add("@CID", SqlDbType.Int).Value = tbCardID.Text;
                cmd6.Parameters.Add("@CID", SqlDbType.Int).Value = tbCardID.Text;

                cmd6.Parameters.Add("@Cname", SqlDbType.NVarChar, 50).Value = tbCardName.Text;
                cmd6.Parameters.Add("@BorrowDate", SqlDbType.Date).Value = dtpBorrow.Value;
                cmd6.Parameters.Add("@ReturnDate", SqlDbType.Date).Value = dtpReturn.Value;
                cmd6.Parameters.Add("@StudentID", SqlDbType.VarChar, 10).Value = tbStudentIDBC.Text;
                cmd7.Parameters.Add("@BID", SqlDbType.Int).Value = tbBookIDBC.Text;



                // thuc thi truy van
                cmd6.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("Add Successfull");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btUpdateBC_Click(object sender, EventArgs e)
        {
            DisplayDataBorrow();
            if (tbCardID.Text != "" && tbCardName.Text != "" && tbStudentIDBC.Text != "" && tbBookIDBC.Text != "")
            {
                SqlCommand cmd12;
                SqlCommand cmd13;
                cmd12 = new SqlCommand("update Student_Card set CID=@cid,Cname=@cname,BorrowDate=@borrowDate,ReturnDate=@returndate,StudentID=@studentID where CID=@cid", con);
                cmd13 = new SqlCommand("update Borrow_Book set CID=@cid,BID=@bid where CID=@cid", con);
                con.Open();

                cmd12.Parameters.AddWithValue("@cid", tbCardID.Text);
                cmd13.Parameters.AddWithValue("@cid", tbCardID.Text);
                cmd12.Parameters.AddWithValue("@cname", tbCardName.Text);



                cmd12.Parameters.AddWithValue("@borrowDate", dtpBorrow.Value);
                cmd12.Parameters.AddWithValue("@returndate", dtpReturn.Value);
                cmd12.Parameters.AddWithValue("@studentID", tbStudentIDBC.Text);
                

                cmd13.Parameters.AddWithValue("@bid", tbBookIDBC.Text);


                cmd12.ExecuteNonQuery();
                cmd13.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();

                


            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }


        }

        private void btUpdateBRC_Click(object sender, EventArgs e)
        {
           DisplayDataBorrowCard();
        }

        private void tbSearchBC_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from Student_Card where CName like '" + tbSearchBC.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvBorrow_Card.DataSource = dt;
            con.Close();
        }
        private void dgvBorrow_Card_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbCardID.Text = dgvBorrow_Card.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbCardName.Text = dgvBorrow_Card.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbStudentIDBC.Text = dgvBorrow_Card.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbBookIDBC.Text = dgvBorrow_Card.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void btSearchBC_Click(object sender, EventArgs e)
        {

        }
    }
}
            
