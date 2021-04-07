using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class ftableQl : Form
    {
        FormSV f1;
        FormGV f2;
        FormDiem f3;
      public  FormLTC f4;
        Baocao f5;
        public ftableQl()
        {
            InitializeComponent();
            f1 = new FormSV();
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
          
            this.pan.Controls.Add(f1);
            f2 = new FormGV();
            f2.TopLevel = false;
            f2.Dock = DockStyle.Fill;
            this.pan.Controls.Add(f2);
            f3 = new FormDiem();
            f3.TopLevel = false;
            f3.Dock = DockStyle.Fill;
            this.pan.Controls.Add(f3);
            f4 = new FormLTC();
            f4.TopLevel = false;
            f4.Dock = DockStyle.Fill;
            this.pan.Controls.Add(f4);
            f5 = new Baocao();
            f5.TopLevel = false;
            f5.Dock = DockStyle.Fill;
            this.pan.Controls.Add(f5);



        }
        private void hideAllFrom()
        {
            f1.Hide();
            f2.Hide();
            f3.Hide();
            f4.Hide();
            f5.Hide();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideAllFrom();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideAllFrom();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideAllFrom();
            f3.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideAllFrom();
            f4.Show();

        }

        private void ftableQl_Load(object sender, EventArgs e)
        {

        }

        private void baToolStripMenuItem_Click(object sender, EventArgs e)
        {

            hideAllFrom();
            f5.Show();
        }
    }
}
