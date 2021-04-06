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
using System.Text.RegularExpressions;

namespace QLDSV
{
    public partial class FormSV : Form
    {
        string strcon = ConnectString.GetConnectionString();
        public FormSV()
        {
            InitializeComponent();
        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            Load_datasv();
            Load_dataLHC();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        void Load_datasv()
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT *FROM tblSinhVien", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable();
                    ada.Fill(tb);
                    {
                        DSSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        DSSV.DataSource = tb;
                        DSSV.Columns[0].HeaderText = "Mã Sinh Viên";
                        DSSV.Columns[1].HeaderText = "Họ Tên";
                        DSSV.Columns[2].HeaderText = "Ngày Sinh (mm/dd/yy)";
                        DSSV.Columns[3].HeaderText = "Giới Tính";
                        DSSV.Columns[4].HeaderText = "Địa Chỉ";
                        DSSV.Columns[5].HeaderText = "Số ĐT";
                        DSSV.Columns[6].HeaderText = "Email";
                        DSSV.Columns[7].HeaderText = "Lớp Hành Chính";
                        DSSV.ReadOnly = true;
                    }

                }
            }
        } //Load Data sinh viên trong bảng sinh viên
        void Load_dataLHC()
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT *FROM tblLopHanhChinh", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable();
                    ada.Fill(tb);
                    {
                        cbbLHC.DataSource = tb;
                        cbbLHC.DisplayMember = "MaLopHC";
                        cbbLHC.ValueMember = "MaLopHC";

                    }

                }
            }

        } // load dữ liệu lớp vào combobox
      
        private bool kemtradulieu()
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtname.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNgaysinh.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtemail.Text.Trim() == "")
            {
                MessageBox.Show("Email sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            try
            {
                ulong sodt = Convert.ToUInt64(txtSDT.Text);
            }
            catch (Exception)
            {
              
                MessageBox.Show("Số điện thoại chỉ gồm các chữ số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Giới tính không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string email = txtemail.Text.Trim();
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                MessageBox.Show("Địa chỉ Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                string ns = txtNgaysinh.Text.Trim();
                string[] arr = ns.Split('/');
                string[] arrTemp = arr[2].Split(' ');
                arr[2] = arrTemp[0];
                new DateTime(Convert.ToInt32(arr[2]), Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]));
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh của sinh viên không hợp lệ!(mm/dd/yyyy)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (kemtradulieu() == false)
                return;
            using (SqlConnection con = new SqlConnection(strcon))
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand("select *from tblSinhVien", con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "sv");
                    DataTable dt = ds.Tables["sv"];
                    DataRow row = dt.NewRow();
                    row["MaSV"] = txtMaSV.Text.Trim();
                    row["NameSV"] = txtname.Text.Trim();
                    row["NgaySinhSV"] = txtNgaysinh.Text.Trim();
                    if (radioButton1.Checked)
                        row["GioiTinhSV"] = "Nam";
                    else
                        row["GioiTinhSV"] = "Nữ";
                    row["DiaChiSV"] = txtDiachi.Text.Trim();
                    row["SodienthoaiSV"] = txtSDT.Text.Trim();
                    row["EmailSV"] = txtemail.Text.Trim();
                    row["MaLopHch"] = cbbLHC.SelectedValue;

                    dt.Rows.Add(row);
                    da.Update(ds, "sv");
                    Load_datasv();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Thêm thất bại, lỗi là:" + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void DSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = DSSV.CurrentRow.Cells["MaSV"].Value.ToString().Trim();
            txtname.Text = DSSV.CurrentRow.Cells["NameSV"].Value.ToString().Trim();
            txtNgaysinh.Text = DSSV.CurrentRow.Cells["NgaySinhSV"].Value.ToString(); txtNgaysinh.ForeColor = Color.Black;
            txtDiachi.Text = DSSV.CurrentRow.Cells["DiaChiSV"].Value.ToString().Trim();
            txtSDT.Text = DSSV.CurrentRow.Cells["SodienthoaiSV"].Value.ToString().Trim();
            txtemail.Text = DSSV.CurrentRow.Cells["EmailSV"].Value.ToString().Trim();
            cbbLHC.SelectedValue = DSSV.CurrentRow.Cells["MaLopHch"].Value.ToString();
            if (DSSV.CurrentRow.Cells["GioiTinhSV"].Value.ToString().Trim().Equals("Nam", StringComparison.InvariantCultureIgnoreCase))
                radioButton1.Checked = true;
            else radioButton2.Checked = true;
            btnAdd.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //refresh();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (kemtradulieu() == false)
               return;

            string query = "select * from tblSinhVien";
            using (SqlConnection cnn = new SqlConnection(strcon))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand(query, cnn);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "sv");
                    DataTable dt = ds.Tables["sv"];
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["MaSV"].ToString().Trim() == txtMaSV.Text.Trim())
                        {
                            row["NameSV"] = txtname.Text.Trim();
                            row["NgaySinhSV"] = txtNgaysinh.Text.Trim();
                            if (radioButton1.Checked)
                                row["GioiTinhSV"] = "Nam";
                            else
                                row["GioiTinhSV"] = "Nữ";
                            row["DiaChiSV"] = txtDiachi.Text.Trim();
                            row["SodienthoaiSV"] = txtSDT.Text.Trim();
                            row["EmailSV"] = txtemail.Text.Trim();
                            row["MaLopHch"] = cbbLHC.SelectedValue;
                            break;
                        }
                    }
                    da.Update(ds, "sv");
                    Load_datasv();
                    MessageBox.Show("Sửa thành Công");
                   
                }
                catch (Exception err)
                {
                    MessageBox.Show(" lỗi là:" + err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {   
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            // search theo mã sinh viên còn lại để trống
            if (txtsearchMaSV.Text.Trim() != "" &&  txtsearchName.Text.Trim() == "" && txtsearchLopHC.Text.Trim() == "")
            {

                string tim_sql = @"select MaSV,NameSV,NgaySinhSV,GioiTinhSV,DiachiSV,SodienthoaiSV,EmailSV,MaLopHCh
                                    from tblSinhVien
                                    where MaSV like'" + txtsearchMaSV.Text + "%' ";
                using (SqlConnection cnn = new SqlConnection(strcon))
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = new SqlCommand(tim_sql, cnn);
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    if (tb.Rows.Count >= 1)
                    {
                        DSSV.DataSource = tb;

                    }
                    else
                    {
                        MessageBox.Show("Không có kết quả trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }


            }
            //search theo mã + tên 
            else if (txtsearchMaSV.Text.Trim() != "" && txtsearchName.Text.Trim() != "" && txtsearchLopHC.Text.Trim() == "")
            {
                string tim_sql = @"select MaSV,NameSV,NgaySinhSV,GioiTinhSV,DiachiSV,SodienthoaiSV,EmailSV,MaLopHCh
                                    from tblSinhVien 
                                    where NameSV like N'" + txtsearchName.Text + "%' and MaSV like'" + txtsearchMaSV.Text + "%' ";
                using (SqlConnection cnn = new SqlConnection(strcon))
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = new SqlCommand(tim_sql, cnn);
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    if (tb.Rows.Count >= 1)
                    {
                        DSSV.DataSource = tb;

                    }
                    else
                    {
                        MessageBox.Show("Không có kết quả trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }


            }
            // search theo mã + lớp 
            else if (txtsearchMaSV.Text.Trim() != "" && txtsearchLopHC.Text.Trim() != "" && txtsearchName.Text.Trim() == "")
            {

                string tim_sql = @"select MaSV,NameSV,NgaySinhSV,GioiTinhSV,DiachiSV,SodienthoaiSV,EmailSV,MaLopHCh
                                    from tblSinhVien 
                                    where MaSV like'" + txtsearchMaSV.Text + "%' and MaLopHCh like '" + txtsearchLopHC + "%'";
                using (SqlConnection cnn = new SqlConnection(strcon))
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = new SqlCommand(tim_sql, cnn);
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    if (tb.Rows.Count >= 1)
                    {
                        DSSV.DataSource = tb;

                    }
                    else
                    {
                        MessageBox.Show("Không có kết quả trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }

            }
            // searh theo mã + tên + lớp 
            else if (txtsearchMaSV.Text.Trim() != "" && txtsearchLopHC.Text.Trim() != "" && txtsearchName.Text.Trim() != "")
            {

                string tim_sql = @"select MaSV,NameSV,NgaySinhSV,GioiTinhSV,DiachiSV,SodienthoaiSV,EmailSV,MaLopHCh
                                    from tblSinhVien 
                                    where NameSV like N'" + txtsearchName.Text + "%' and MaSV like'" + txtsearchMaSV.Text + "%' and MaLopHCh like '" + txtsearchLopHC + "%'";
                using (SqlConnection cnn = new SqlConnection(strcon))
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = new SqlCommand(tim_sql, cnn);
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    if (tb.Rows.Count >= 1)
                    {
                        DSSV.DataSource = tb;

                    }
                    else
                    {
                        MessageBox.Show("Không có kết quả trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }

            }

            // search theo tên nếu còn lại để trống 
            else if (  txtsearchMaSV.Text.Trim() == "" && txtsearchLopHC.Text.Trim() == "" && txtsearchName.Text.Trim() != "")
            {

                string tim_sql = @"select MaSV,NameSV,NgaySinhSV,GioiTinhSV,DiachiSV,SodienthoaiSV,EmailSV,MaLopHCh
                                    from tblSinhVien
                                    where NameSV like N'"+txtsearchName.Text+"%' ";
                using (SqlConnection cnn = new SqlConnection(strcon))
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = new SqlCommand(tim_sql, cnn);
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    if (tb.Rows.Count >= 1)
                    {
                        DSSV.DataSource = tb;

                    }
                    else
                    {
                        MessageBox.Show("Không có kết quả trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }
            // search theo tên + mã 
            else if (txtsearchMaSV.Text.Trim() != "" && txtsearchLopHC.Text.Trim() == "" && txtsearchName.Text.Trim() != "")
            {

                string tim_sql = @"select MaSV,NameSV,NgaySinhSV,GioiTinhSV,DiachiSV,SodienthoaiSV,EmailSV,MaLopHCh
                                    from tblSinhVien
                                    where NameSV like N'" + txtsearchName.Text + "%' and MaSV like N'" + txtsearchMaSV.Text + "%' ";
                using (SqlConnection cnn = new SqlConnection(strcon))
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = new SqlCommand(tim_sql, cnn);
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    if (tb.Rows.Count >= 1)
                    {
                        DSSV.DataSource = tb;

                    }
                    else
                    {
                        MessageBox.Show("Không có kết quả trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }
            // search theo tên + lớp
            else if (txtsearchMaSV.Text.Trim() == "" && txtsearchLopHC.Text.Trim() != "" && txtsearchName.Text.Trim() != "")
            {

                string tim_sql = @"select MaSV,NameSV,NgaySinhSV,GioiTinhSV,DiachiSV,SodienthoaiSV,EmailSV,MaLopHCh
                                    from tblSinhVien
                                    where MaLopHch like N'" + txtsearchLopHC.Text + "%' and NameSV like N'" + txtsearchName.Text + "%' ";
                using (SqlConnection cnn = new SqlConnection(strcon))
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = new SqlCommand(tim_sql, cnn);
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    if (tb.Rows.Count >= 1)
                    {
                        DSSV.DataSource = tb;

                    }
                    else
                    {
                        MessageBox.Show("Không có kết quả trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }

            //tim theo lop hanh chinh
            else if(txtsearchMaSV.Text.Trim() == "" && txtsearchName.Text.Trim() == "" && txtsearchLopHC.Text.Trim()!="")
            {
                string tim_sql = @"select MaSV,NameSV,NgaySinhSV,GioiTinhSV,DiachiSV,SodienthoaiSV,EmailSV,MaLopHCh
                                    from tblSinhVien
                                    where MaLopHch like N'" + txtsearchLopHC.Text + "%' ";
                using (SqlConnection cnn = new SqlConnection(strcon))
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = new SqlCommand(tim_sql, cnn);
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    if (tb.Rows.Count >= 1)
                    {
                        DSSV.DataSource = tb;

                    }
                    else
                    {
                        MessageBox.Show("Không có kết quả trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }

            else if (txtsearchMaSV.Text.Trim() == ""  && txtsearchName.Text.Trim() == "")
            {
                MessageBox.Show("Không được để tên hoặc mã trống");
            }
         


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsearchMaSV.Text = string.Empty;
            txtsearchName.Text = string.Empty;
            txtsearchLopHC.Text = string.Empty;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = string.Empty;
            txtname.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtNgaysinh.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            btnAdd.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Load_datasv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thong bao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {

                using (SqlConnection cnn = new SqlConnection(strcon))
                {
                    string query = @"delete from tblSinhVien where MaSV=N'" + txtMaSV.Text.Trim() + "'";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        Load_datasv();
                        txtMaSV.Text = string.Empty;
                        txtname.Text = string.Empty;
                        txtemail.Text = string.Empty;
                        txtDiachi.Text = string.Empty;
                        txtSDT.Text = string.Empty;
                        txtNgaysinh.Text = string.Empty;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;

                    }
                }
            }
        }
    }
}
