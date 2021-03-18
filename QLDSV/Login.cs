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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void login_button_Click(object sender, EventArgs e)
        {
            if(login() == true)
            {     
            ftableQl f = new ftableQl();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Thông Báo ", "Đăng Nhập Thất Bại");
            }                
        }
         bool login()
        {

            string username = Username.Text;
            string password = PassWord.Text;
            string strcon = ConnectString.GetConnectionString();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "selectAcount";
            cmd.Parameters.AddWithValue("@taikhoan", username);
            cmd.Parameters.AddWithValue("@matkhau", password);
            SqlDataReader re = cmd.ExecuteReader();

            if (re.HasRows==true)
                {
                return true;
            }
            else
            { 
            return false;
            }
        } // kiem tra dang nhap 
        private void out_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Thông báo","Bạn Có thực sự muốn thoát chương trình", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
