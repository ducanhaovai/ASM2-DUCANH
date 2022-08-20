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
    public partial class fProgram : Form
    {
        SqlConnection con = new SqlConnection("server=AGEN1-KHABANH;database=ASM2-LIBRARY-DucAnh;uid=sa;pwd=123456;MultipleActiveResultSets=true");

        int ID = 0;
        //ket noi toi sv SQL
        
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter adapt;
        

        public fProgram()
        {
            InitializeComponent();
            DisplayDataBook();
            
            


        }
        private void DisplayDataBook()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Book", con);
            adapt.Fill(dt);
            dgvBook.DataSource = dt;
            con.Close();
        }
        private void DisplayDataStudent()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Student", con);
            adapt.Fill(dt);
            dgvStudent.DataSource = dt;
            con.Close();
        }
       
        
        private void DisplayDataAuthor()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Author", con);

            adapt.Fill(dt);
            dgvAuthor.DataSource = dt;
            con.Close();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {

                // tao sql command de thuc thi lenh sql
                SqlCommand cmd1 = con.CreateCommand();
                // thiet lap thong so cau lenh insert

                cmd1.CommandText = "insert into Book values (@BID,@BName,@BLanguage,@Publisher,@LID,@AuID) ";
                con.Open();


                // truyen tham so cho cau lenh insert
                cmd1.Parameters.Add("@BID", SqlDbType.Int).Value = tbBookId.Text;
                cmd1.Parameters.Add("@BName", SqlDbType.NVarChar, 50).Value = tbBookName.Text;
                cmd1.Parameters.Add("@BLanguage", SqlDbType.NVarChar, 50).Value = tbBookL.Text;
                cmd1.Parameters.Add("@Publisher", SqlDbType.NVarChar, 50).Value = tbPublisher.Text;
                cmd1.Parameters.Add("@LID", SqlDbType.Int).Value = tbLID.Text;
                cmd1.Parameters.Add("@AuID", SqlDbType.Int).Value = tbAuId.Text;



                // thuc thi truy van
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Add Successfull");
                ClearDataBook();
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
        private void button4_Click(object sender, EventArgs e)
        {
            DisplayDataBook();
            if (tbBookId.Text != "" && tbBookName.Text != "" && tbBookL.Text != "" && tbPublisher.Text != "" && tbAuId.Text != "" && tbLID.Text != "")
            {
                cmd = new SqlCommand("update Book set BName=@bname,BLanguage=@blanguage,Publisher=@publisher,LID=@lid,AuID=@auid where BID=@bid", con);
                con.Open();

                cmd.Parameters.AddWithValue("@bid", tbBookId.Text);
                cmd.Parameters.AddWithValue("@bname", tbBookName.Text);
                cmd.Parameters.AddWithValue("@blanguage", tbBookL.Text);
                cmd.Parameters.AddWithValue("@publisher", tbPublisher.Text);
                cmd.Parameters.AddWithValue("@lid", tbLID.Text);
                cmd.Parameters.AddWithValue("@auid", tbAuId.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayDataBook();
                ClearDataBook();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }

            
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedRows.Count == 1)
            {
                SqlCommand cmd2;
                cmd2 = new SqlCommand("delete Book where BID = @bid", con);
                con.Open();
                cmd2.Parameters.AddWithValue("@bid", tbBookId.Text);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayDataBook();
                ClearDataBook();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            
            con.Open();
            adapt = new SqlDataAdapter("select * from Book where BName like '" + tbIDSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvBook.DataSource = dt;
            con.Close();
        }

        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void ClearDataBook()
        {
            tbBookId.Text = "";
            tbBookName.Text = "";
            tbBookL.Text = "";
            tbPublisher.Text = "";
            tbAuId.Text = "";
            tbLID.Text = "";
            
        }
        private void ClearDataStudent()
        {
            tbStudentID.Text = "";
            tbStudentName.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            tbUsername.Text = "";
            tbGender.Text = "";
            
        }
        
        private void ClearDataAuthor()
        {
            tbAuthorID.Text = "";
            tbAuName.Text = "";
            tbAuEmail.Text = "";
            

        }





        private void tbBookL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tbAuId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btUpS_Click(object sender, EventArgs e)
        {

            DisplayDataStudent();
            if (tbUsername.Text != "" && tbStudentID.Text != "" && tbStudentName.Text != "" && tbPhone.Text != "" && tbEmail.Text != "" && tbGender.Text != "" )
            {
                cmd = new SqlCommand("update Student set SID=@sid,SName=@sname,SPhone=@sphone,SEmail=@semail,Username=@username,DoB=@dob,Gender=@gender where SID=@sid", con);
                con.Open();

                cmd.Parameters.AddWithValue("@sid", tbStudentID.Text);
                cmd.Parameters.AddWithValue("@sname", tbStudentName.Text);
                
                
                
                cmd.Parameters.AddWithValue("@sphone", tbPhone.Text);
                cmd.Parameters.AddWithValue("@semail", tbEmail.Text);
                cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@gender", tbGender.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayDataBook();
                ClearDataStudent();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
            
        }

        private void btAddS_Click(object sender, EventArgs e)
        {


            try
            {
                // tao sql command de thuc thi lenh sql
                SqlCommand cmd4 = con.CreateCommand();
                // thiet lap thong so cau lenh insert

                cmd4.CommandText = "insert into Student values (@SID,@SName,@SPhone,@SEmail,@Username,@DoB,@Gender) ";
                con.Open();


                // truyen tham so cho cau lenh insert
                cmd4.Parameters.Add("@SID", SqlDbType.NVarChar, 10).Value = tbStudentID.Text;
                cmd4.Parameters.Add("@SName", SqlDbType.NVarChar, 50).Value = tbStudentName.Text;
                cmd4.Parameters.Add("@SPhone", SqlDbType.Int).Value = tbPhone.Text;
                cmd4.Parameters.Add("@SEmail", SqlDbType.VarChar, 50).Value = tbEmail.Text;
                cmd4.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = tbUsername.Text;
                cmd4.Parameters.Add("@DoB", SqlDbType.DateTime).Value = dtpDOB.Value;
                cmd4.Parameters.Add("@Gender", SqlDbType.NVarChar, 10).Value = tbGender.Text;



                // thuc thi truy van
                cmd4.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Add Successfull");
                ClearDataStudent();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
                
           
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            tbBookId.Text = dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbBookName.Text = dgvBook.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbBookL.Text = dgvBook.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbPublisher.Text = dgvBook.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbAuId.Text = dgvBook.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbLID.Text = dgvBook.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void dgvStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbStudentID.Text = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbStudentName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbPhone.Text = dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbEmail.Text = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbUsername.Text = dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
            
            
            
            
            
            tbGender.Text = dgvStudent.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void tabBook_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void fProgram_Load(object sender, EventArgs e)
        {
            
            con.Open();
            adapt = new SqlDataAdapter("select * from Book", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvBook.DataSource = dt;
            con.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        

        private void dgvBorrow_Card_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            
            con.Open();
            adapt = new SqlDataAdapter("select * from Book", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvBook.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from Student where SName like '" + tbSearchS.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvStudent.DataSource = dt;
            con.Close();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btSearchS_Click(object sender, EventArgs e)
        {
            

            con.Open();
            adapt = new SqlDataAdapter("select * from Student where SName like '" + tbSearchS + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvBook.DataSource = dt;
            con.Close();
        }

        private void btDelS_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 1)
            {
                SqlCommand cmd6;
                cmd6 = new SqlCommand("delete Student where SID = @sid", con);
                con.Open();
                cmd6.Parameters.AddWithValue("@sid", tbStudentID.Text);
                cmd6.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayDataStudent();
                ClearDataStudent();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

       

       

        

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayDataAuthor();
            if (tbAuthorID.Text != "" && tbAuName.Text != "" && tbAuEmail.Text != "" )
            {
                cmd = new SqlCommand("update Author set AuID=@auid,AuName=@auname,AuEmail=@auemail where AuID=@auid", con);
                con.Open();

                cmd.Parameters.AddWithValue("@auid", tbAuthorID.Text);
                cmd.Parameters.AddWithValue("@auname", tbAuName.Text);
                cmd.Parameters.AddWithValue("@auemail", tbAuEmail.Text);
                


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                ClearDataAuthor();
                con.Close();
                
                
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        
        private void tbSearchAu_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from Author where AuName like '" + tbSearchAu.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvAuthor.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                // tao sql command de thuc thi lenh sql
                SqlCommand cmd15 = con.CreateCommand();
                // thiet lap thong so cau lenh insert

                cmd15.CommandText = "insert into Author values (@AuID,@AuName,@AuEmail) ";
                con.Open();


                // truyen tham so cho cau lenh insert
                cmd15.Parameters.Add("@AuID", SqlDbType.Int).Value = tbAuthorID.Text;
                cmd15.Parameters.Add("@AuName", SqlDbType.NVarChar, 50).Value = tbAuName.Text;
                cmd15.Parameters.Add("@AuEmail", SqlDbType.NVarChar, 50).Value = tbAuEmail.Text;
               



                // thuc thi truy van
                cmd15.ExecuteNonQuery();
                con.Close();
                ClearDataAuthor();
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

        private void dgvAuthor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbAuthorID.Text = dgvAuthor.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbAuName.Text = dgvAuthor.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbAuEmail.Text = dgvAuthor.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void btDelAu_Click(object sender, EventArgs e)
        {
            if (dgvAuthor.SelectedRows.Count == 1)
            {
                SqlCommand cmd20;
                cmd20 = new SqlCommand("delete Author where AuID = @auid", con);
                con.Open();
                cmd20.Parameters.AddWithValue("@auid", tbAuthorID.Text);
                cmd20.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayDataAuthor();
                ClearDataAuthor();


            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
    
}


