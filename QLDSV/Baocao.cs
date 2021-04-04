﻿using System;
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
    public partial class Baocao : Form
    {
        public Baocao()
        {
            InitializeComponent();
        }
        string strcon = ConnectString.GetConnectionString();
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtLopHC.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DataTable tb = new DataTable();

                using (SqlConnection cnn = new SqlConnection(strcon))
                {
                    using (SqlCommand cmd = new SqlCommand("dsSVlopHC", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@malop", txtLopHC.Text.Trim());
                        using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                        {

                            ad.Fill(tb);

                        }
                    }
                }
                DSbaocaolopHC ds = new DSbaocaolopHC();
                ds.SetDataSource(tb);
                Inbaocao bc = new Inbaocao();
                bc.CrystalReportViewer1.ReportSource = ds;//để có thể truy cập biến CrystalReportViewer1 trong InBaoCao.cs thì phải vào InBaoCao.Designer.cs 
                                                          //và thêm phương thức get/set của CrystalReportViewer1
                bc.ShowDialog();

            }    
        }

        private void btndiemtc_Click(object sender, EventArgs e)
        {

        }
    }
}
