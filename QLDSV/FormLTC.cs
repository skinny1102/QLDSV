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

namespace QLDSV
{
    public partial class FormLTC : Form
    {
        string strcon = ConnectString.GetConnectionString();

        public FormLTC()
        {
            InitializeComponent();
            loaddsmon();
            loadgv();
            //button2.Enabled = false;
            txtMASV.Enabled = false;
            btnAdd.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            
            loadmon();
        }
        private void loaddsmon()
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT *FROM danhsachlopTC", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable();
                    ada.Fill(tb);
                    {
                        DSMM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        DSMM.DataSource = tb;
                        DSMM.Columns[0].HeaderText = "Mã Lớp ";
                        DSMM.Columns[1].HeaderText = "Tên Môn";
                        DSMM.Columns[2].HeaderText = "Số Lượng";
                        DSMM.Columns[3].HeaderText = "GV Phụ trách";
                        DSMM.Columns[4].HeaderText = "Kì Học";
                        DSMM.Columns[5].HeaderText = "Năm Học";
                        DSMM.ReadOnly = true;
                    }

                }
            }
        }
        void loadmon()
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT *FROM tblMon", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable();
                    ada.Fill(tb);
                    {
                        cbbtenmon.DataSource = tb;
                        cbbtenmon.DisplayMember = "TenMon";
                        cbbtenmon.ValueMember = "TenMon";

                    }

                }
            }


        }
        void loadgv()
        {

            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT *FROM tblGiangVien", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable();
                    ada.Fill(tb);
                    {
                        cbbGV.DataSource = tb;
                        cbbGV.DisplayMember = "NameGV";
                        cbbGV.ValueMember = "NameGV";

                    }

                }
            }

        }

        private void DSM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DSMM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMAM.Text = DSMM.CurrentRow.Cells["MaLopTC"].Value.ToString().Trim();
            cbbGV.Text = DSMM.CurrentRow.Cells["NameGV"].Value.ToString().Trim();
            txtMname.Text = DSMM.CurrentRow.Cells["TenMon"].Value.ToString();
            txtMSL.Text = DSMM.CurrentRow.Cells["soluongsv"].Value.ToString().Trim();
            txtkihoc.Text = DSMM.CurrentRow.Cells["Name"].Value.ToString().Trim();
            txtNamhoc.Text = DSMM.CurrentRow.Cells["namhoc"].Value.ToString().Trim();
            txtMAM.Enabled = false;
            txtMname.Enabled = false;
            txtMSL.Enabled = false;
            cbbtenmon.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;

            //button2.Enabled = true;
           btnaddlop.Enabled = false;
            loadsvv();
    
    }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    loadsvv();
        //}

        void loadsvv()
        {


            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("exec dssvlopm @maloptc='" + txtMAM.Text + "'", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable();
                    ada.Fill(tb);
                    {
                        DSM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        DSM.DataSource = tb;
                        DSM.Columns[0].HeaderText = "Mã SV ";
                        DSM.Columns[1].HeaderText = "Tên SV";
                        DSM.Columns[2].HeaderText = "Lớp Hành chính";
                        DSM.Columns[3].HeaderText = "Giới tính";
                        DSM.Columns[4].HeaderText = "Ngày sinh";

                        DSMM.ReadOnly = true;
                    }

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "update tblLopTinChi set tblLopTinChi.MaGV = (select tblGiangVien.MaGV from tblGiangVien where tblGiangVien.NameGV = N'"+ cbbGV.SelectedValue+"' ) where tblLopTinChi.MaLopTC = '"+txtMAM.Text +"'";
            using (SqlConnection cnn = new SqlConnection(strcon))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Sửa Thành Công");
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
                loaddsmon();



            }
        }
        Addsvl f1;
        private void button3_Click(object sender, EventArgs e)
        {
            //f1 = new Addsvl();
            //f1.Show();
            txtMASV.Enabled = true;
            btnAdd.Enabled = true;

        }
        bool kiemtradl()
        {
            if(txtMASV.Text.Trim()=="")
            {
                MessageBox.Show("mã sinh viên không được để trống");
                return false;

            }   
            return true;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (kiemtradl() == false)
            {
                return;
            }
            string query = "exec addlop @ltc = '"+ txtMAM.Text+"' ,@masv = '"+txtMASV.Text+"'";
                using (SqlConnection cnn = new SqlConnection(strcon))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
               
                try
                { 
                    int i = cmd.ExecuteNonQuery();
                    MessageBox.Show("thêm thành công");
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại");
                }
            
                loadsvv();



            }
        }

        private void btnaddlop_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strcon))
                 
            using ( SqlCommand cmd = new SqlCommand())
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType= System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "themmon";
                cmd.Parameters.AddWithValue("@malop", txtMAM.Text);
                cmd.Parameters.AddWithValue("@tenmon", cbbtenmon.SelectedValue);
                cmd.Parameters.AddWithValue("@tengiangvien", cbbGV.SelectedValue);
                cmd.Parameters.AddWithValue("@tenki", txtkihoc.Text);
                cmd.Parameters.AddWithValue("@namho", txtNamhoc.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0) Console.WriteLine("Da them duoc");
                else Console.WriteLine("Chua them duoc");

            }    
        }
    }
}
