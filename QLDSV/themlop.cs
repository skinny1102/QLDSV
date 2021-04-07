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

namespace QLDSV
{
    public partial class themlop : Form
    {

        string strcon = ConnectString.GetConnectionString();
        public themlop()
        {


            InitializeComponent();
            loadmon();
            loadgv();
        }
        bool kiemtradulieu()
        {
            if (txtMAM.Text=="")
            {
                MessageBox.Show("Mã Lớp Trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNamhoc.Text == "")
            {
                MessageBox.Show("Năm Học Trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbbkyhoc.Text == "")
            {
                MessageBox.Show("Kỳ Học Trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( kiemtradulieu()== false)
            {
                return;
            } 
            else
            {     
            using (SqlConnection con = new SqlConnection(strcon))

            using (SqlCommand cmd = new SqlCommand())
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "themmon";
                cmd.Parameters.AddWithValue("@malop", txtMAM.Text);
                cmd.Parameters.AddWithValue("@tenmon", cbbtenmon11.SelectedValue);
                cmd.Parameters.AddWithValue("@tengiangvien", cbbGV.SelectedValue);
                cmd.Parameters.AddWithValue("@tenki", cbbkyhoc.Text);
                cmd.Parameters.AddWithValue("@namhoc", txtNamhoc.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    
                    MessageBox.Show("Thông báo", "Thêm Thành Công");
                    FormLTC f = new FormLTC();
                    f.loadmon();
                    this.Close();

                }

                else
                { MessageBox.Show("Thông báo", "Thêm Không Thành Công"); }    
                  

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
                        cbbtenmon11.DataSource = tb;
                        cbbtenmon11.DisplayMember = "TenMon";
                        cbbtenmon11.ValueMember = "TenMon";

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

        private void themlop_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLTC f = new FormLTC();
            f.loadmon();
        }
    }
}
