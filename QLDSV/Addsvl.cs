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
    public partial class Addsvl : Form
    {
        string strcon = ConnectString.GetConnectionString();
        public Addsvl()
        {
            InitializeComponent();
        }

        FormLTC f2;
        private void button1_Click(object sender, EventArgs e)
        {
            //f2 = new formltc();
            //string query = "exec addlop @ltc = '" + f2. + "' ,@masv = '" + txtmasv.text + "'";
            //using (sqlconnection cnn = new sqlconnection(strcon))
            //{
            //    cnn.open();
            //    sqlcommand cmd = new sqlcommand(query, cnn);
            //    int i = cmd.executenonquery();
            //    if (i > 0)
            //    {
            //        messagebox.show("thêm thành công");
            //    }
            //    else
            //    {
            //        messagebox.show("thêm thất bại");
            //    }
            //    loadsvv();



            }
        }
    }

