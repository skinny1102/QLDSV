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
using System.Data;

namespace QLDSV
{
    public partial class FormDiem : Form
    {
        string strcon = ConnectString.GetConnectionString();
        public FormDiem()
        {
            InitializeComponent();
            Load_dataLHC();
           
        }

        void Load_dataLHC()
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT *FROM tblLopTinChi", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable();
                    ada.Fill(tb);
                    {
                        cbbLHC.DataSource = tb;
                        cbbLHC.DisplayMember = "MaLopTC";
                        cbbLHC.ValueMember = "MaLopTC";

                    }

                }
            }

        }

        private void btnsearchD_Click(object sender, EventArgs e)
        {

            string tim_sql = @"select *from diemloptc where MaLopTC='" + cbbLHC.Text +"' ";
            using (SqlConnection cnn = new SqlConnection(strcon))
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand(tim_sql, cnn);
                DataTable tb = new DataTable();
                sda.Fill(tb);
                DSD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DSD.DataSource = tb;

                
              

            }
        }

        private void cbbLHC_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string ltc = cbbLHC.Text;
            using (SqlCommand cmd = new SqlCommand("select *from  tenloptheoma where MaLopTC='" + ltc + " ' ", con))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label4.Text = dr["TenMon"].ToString();


                }

            }
        }

        private void DSD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDmaSV.Text = DSD.CurrentRow.Cells["MaSV"].Value.ToString().Trim();
            txtDname.Text = DSD.CurrentRow.Cells["NameSV"].Value.ToString().Trim();
            txtDlophc.Text = DSD.CurrentRow.Cells["MaLopHC"].Value.ToString();
            txtDCH.Text = DSD.CurrentRow.Cells["DiemChuyencan"].Value.ToString().Trim();
            txtDGK.Text = DSD.CurrentRow.Cells["Diemgiuaky"].Value.ToString().Trim();
            txtDT.Text = DSD.CurrentRow.Cells["Diemthi"].Value.ToString().Trim();
            txtloptc.Text= DSD.CurrentRow.Cells["MaLopTC"].Value.ToString().Trim();
            txtDTB.Text = "";
            try
            {
                double dch = Convert.ToDouble(txtDCH.Text);
                double dgk = Convert.ToDouble(txtDGK.Text);
                double dt = Convert.ToDouble(txtDT.Text);
                double dtb;
                dtb = (dch * 0.1) + (dgk * 0.2) + (dt * 0.7);
                txtDTB.Text = dtb.ToString();
            }
            catch (Exception)
            {


            }


        }
        private bool kiemtradl()
        {
            if (txtDCH.Text.Trim() == "" || txtDGK.Text.Trim()==""||txtDT.Text.Trim()=="")
            {
                MessageBox.Show("Sửa thì điểm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                double dch = Convert.ToDouble(txtDCH.Text);
                double dgk = Convert.ToDouble(txtDGK.Text);
                double dt = Convert.ToDouble(txtDT.Text);
                if (dch < 0 || dgk < 0 || dt < 0)
                {
                    MessageBox.Show(" Điểm Không được âm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }


            }
            catch (Exception)
            {
                MessageBox.Show(" Điểm phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }    
        void loaddiem()
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("select *from diemloptc where MaLopTC='" + cbbLHC.Text + "' ", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable();
                    ada.Fill(tb);
                    {
                        DSD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        DSD.DataSource = tb;
                        DSD.Columns[0].HeaderText = "Mã Lớp Tín Chỉ";
                        DSD.Columns[1].HeaderText = "Mã SV";
                        DSD.Columns[2].HeaderText = "Họ Tên";
                        DSD.Columns[3].HeaderText = "Lớp HC";
                        DSD.Columns[4].HeaderText = " Điểm chuyên cần";
                        DSD.Columns[5].HeaderText = "Điểm giữa kì";
                        DSD.Columns[6].HeaderText = "Điểm thi";
                        DSD.ReadOnly = true;
                    }

                }
            }
        }

        void loaddiem1()
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("select *from diemloptc where MaLopTC ='" + txtloptc.Text + "' and MaSV = '" + txtDmaSV.Text + "' ", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable();
                    ada.Fill(tb);
                    {
                        DSD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        DSD.DataSource = tb;
                        DSD.Columns[0].HeaderText = "Mã Lớp Tín Chỉ";
                        DSD.Columns[1].HeaderText = "Mã SV";
                        DSD.Columns[2].HeaderText = "Họ Tên";
                        DSD.Columns[3].HeaderText = "Lớp HC";
                        DSD.Columns[4].HeaderText = " Điểm chuyên cần";
                        DSD.Columns[5].HeaderText = "Điểm giữa kì";
                        DSD.Columns[6].HeaderText = "Điểm thi";
                        DSD.ReadOnly = true;
                    }

                }
            }
        }








        private void btnDsua_Click(object sender, EventArgs e)
        {
            if (kiemtradl() == false)
                return;
            else
            {
                string query = "update diemloptc set DiemChuyencan =" + txtDCH.Text + " , Diemgiuaky ="+ txtDGK.Text+ " , Diemthi =" + txtDGK.Text + " where MaLopTC ='" + txtloptc.Text+ "' and MaSV = '" + txtDmaSV.Text + "'";
                using (SqlConnection cnn = new SqlConnection(strcon))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);
                   int i  = cmd.ExecuteNonQuery();
                    if(i>0)
                    {
                        MessageBox.Show("Sửa Thành Công");
                        loaddiem1();
                       
                    }   
                    else
                    {
                        MessageBox.Show("Sửa Thất Bại");
                    }    
                    
                }
            }

        }
        private void reset()
        {
            txtDmaSV.Text = string.Empty;
            txtDname.Text = string.Empty;
            txtDCH.Text = string.Empty;
            txtDGK.Text = string.Empty;
            txtDT.Text = string.Empty;
            txtDTB.Text = string.Empty;
            txtDlophc.Text = string.Empty;
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnHTT_Click(object sender, EventArgs e)
        {

            string tim_sql = @"select *from diemloptc";
            using (SqlConnection cnn = new SqlConnection(strcon))
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand(tim_sql, cnn);
                DataTable tb = new DataTable();
                sda.Fill(tb);
                DSD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DSD.DataSource = tb;




            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {   
            string tim_sql = @"select *from diemloptc where MaSV like '"+txtmasvtensv.Text+"%' ";
            using (SqlConnection cnn = new SqlConnection(strcon))
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand(tim_sql, cnn);
                DataTable tb = new DataTable();
                sda.Fill(tb);
                if (tb.Rows.Count >= 1)
                {     
                DSD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DSD.DataSource = tb;
                }
                // tìm theo tên sinh viên
                //else if (tb.Rows.Count < 1)
                //{
                //    string tim = @"select *from diemloptc where NameSV like N'%"+txtmasvtensv.Text +"%'";
                //    sda.SelectCommand = new SqlCommand(tim, cnn);
                //    DataTable t = new DataTable();
                //    sda.Fill(t);
                //    if (t.Rows.Count >= 1)
                //    {
                //        DSD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //        DSD.DataSource = t;
                //    }
                //    else if (t.Rows.Count<1)
                //    {
                //        MessageBox.Show("Không có sinh viên trùng khớp");
                //    }    

                //}    




            }
        }
    }
}
