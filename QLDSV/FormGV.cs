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
    public partial class FormGV : Form
    {
        string strcon = ConnectString.GetConnectionString();
        public FormGV()
        {
            InitializeComponent();
        
        }
    
        void Load_DB_toGridView()
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
                        dsGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dsGV.DataSource = tb;
                        dsGV.Columns[0].HeaderText = "Mã Giảng Viên";
                        dsGV.Columns[1].HeaderText = "Họ Tên";
                        dsGV.Columns[2].HeaderText = "Ngày Sinh (mm/dd/yy)";
                        dsGV.Columns[3].HeaderText = "Giới Tính";
                        dsGV.Columns[4].HeaderText = "Địa Chỉ";
                        dsGV.Columns[5].HeaderText = "Số ĐT";
                        dsGV.Columns[6].HeaderText = "Email";
                        dsGV.Columns[7].HeaderText = "Học vị";
                        dsGV.ReadOnly = true;
                    }

                }
            }
        }

        private void FormGV_Load_1(object sender, EventArgs e)
        {
            Load_DB_toGridView();
        }
    }
        

}

