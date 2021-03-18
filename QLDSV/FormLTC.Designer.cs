
namespace QLDSV
{
    partial class FormLTC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DSM = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMAM = new System.Windows.Forms.TextBox();
            this.txtMSL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.DSMM = new System.Windows.Forms.DataGridView();
            this.cbbGV = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMASV = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnaddlop = new System.Windows.Forms.Button();
            this.cbbtenmon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtkihoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNamhoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DSM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSMM)).BeginInit();
            this.SuspendLayout();
            // 
            // DSM
            // 
            this.DSM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSM.Location = new System.Drawing.Point(526, 244);
            this.DSM.Name = "DSM";
            this.DSM.RowHeadersWidth = 51;
            this.DSM.RowTemplate.Height = 24;
            this.DSM.Size = new System.Drawing.Size(662, 473);
            this.DSM.TabIndex = 0;
            this.DSM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSM_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Lớp và Môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông Tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Lớp Tín chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giảng Viên ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Sinh Viên";
            // 
            // txtMAM
            // 
            this.txtMAM.Location = new System.Drawing.Point(129, 97);
            this.txtMAM.Name = "txtMAM";
            this.txtMAM.Size = new System.Drawing.Size(136, 22);
            this.txtMAM.TabIndex = 6;
            // 
            // txtMSL
            // 
            this.txtMSL.Location = new System.Drawing.Point(129, 174);
            this.txtMSL.Name = "txtMSL";
            this.txtMSL.Size = new System.Drawing.Size(72, 22);
            this.txtMSL.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên Môn";
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(580, 93);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(132, 22);
            this.txtMname.TabIndex = 11;
            // 
            // DSMM
            // 
            this.DSMM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSMM.Location = new System.Drawing.Point(12, 244);
            this.DSMM.Name = "DSMM";
            this.DSMM.RowHeadersWidth = 51;
            this.DSMM.RowTemplate.Height = 24;
            this.DSMM.Size = new System.Drawing.Size(508, 479);
            this.DSMM.TabIndex = 13;
            this.DSMM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSMM_CellClick);
            // 
            // cbbGV
            // 
            this.cbbGV.FormattingEnabled = true;
            this.cbbGV.Location = new System.Drawing.Point(129, 136);
            this.cbbGV.Name = "cbbGV";
            this.cbbGV.Size = new System.Drawing.Size(170, 24);
            this.cbbGV.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 27);
            this.button3.TabIndex = 15;
            this.button3.Text = "Thêm sinh viên vào lớp ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã Sinh Viên";
            // 
            // txtMASV
            // 
            this.txtMASV.Location = new System.Drawing.Point(635, 204);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(167, 22);
            this.txtMASV.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(808, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnaddlop
            // 
            this.btnaddlop.Location = new System.Drawing.Point(25, 205);
            this.btnaddlop.Name = "btnaddlop";
            this.btnaddlop.Size = new System.Drawing.Size(75, 23);
            this.btnaddlop.TabIndex = 21;
            this.btnaddlop.Text = "Thêm";
            this.btnaddlop.UseVisualStyleBackColor = true;
            this.btnaddlop.Click += new System.EventHandler(this.btnaddlop_Click);
            // 
            // cbbtenmon
            // 
            this.cbbtenmon.FormattingEnabled = true;
            this.cbbtenmon.Location = new System.Drawing.Point(388, 95);
            this.cbbtenmon.Name = "cbbtenmon";
            this.cbbtenmon.Size = new System.Drawing.Size(159, 24);
            this.cbbtenmon.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Kì học";
            // 
            // txtkihoc
            // 
            this.txtkihoc.Location = new System.Drawing.Point(384, 131);
            this.txtkihoc.Name = "txtkihoc";
            this.txtkihoc.Size = new System.Drawing.Size(123, 22);
            this.txtkihoc.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Năm Học";
            // 
            // txtNamhoc
            // 
            this.txtNamhoc.Location = new System.Drawing.Point(384, 165);
            this.txtNamhoc.Name = "txtNamhoc";
            this.txtNamhoc.Size = new System.Drawing.Size(123, 22);
            this.txtNamhoc.TabIndex = 26;
            // 
            // FormLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 777);
            this.Controls.Add(this.txtNamhoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtkihoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbtenmon);
            this.Controls.Add(this.btnaddlop);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMASV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbbGV);
            this.Controls.Add(this.DSMM);
            this.Controls.Add(this.txtMname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMSL);
            this.Controls.Add(this.txtMAM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DSM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLTC";
            this.Text = "FormLTC";
            ((System.ComponentModel.ISupportInitialize)(this.DSM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSMM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DSM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMAM;
        private System.Windows.Forms.TextBox txtMSL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.DataGridView DSMM;
        private System.Windows.Forms.ComboBox cbbGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMASV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnaddlop;
        private System.Windows.Forms.ComboBox cbbtenmon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtkihoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNamhoc;
    }
}