
namespace QLDSV
{
    partial class FormDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.DSD = new System.Windows.Forms.DataGridView();
            this.btnsearchD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbLHC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDname = new System.Windows.Forms.TextBox();
            this.txtDlophc = new System.Windows.Forms.TextBox();
            this.txtDCH = new System.Windows.Forms.TextBox();
            this.txtDGK = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDsua = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDmaSV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.btnHTT = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtmasvtensv = new System.Windows.Forms.TextBox();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtloptc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DSD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐIỂM";
            // 
            // DSD
            // 
            this.DSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSD.Location = new System.Drawing.Point(319, 68);
            this.DSD.Name = "DSD";
            this.DSD.RowHeadersWidth = 51;
            this.DSD.RowTemplate.Height = 24;
            this.DSD.Size = new System.Drawing.Size(839, 676);
            this.DSD.TabIndex = 2;
            this.DSD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSD_CellClick);
            // 
            // btnsearchD
            // 
            this.btnsearchD.Location = new System.Drawing.Point(186, 130);
            this.btnsearchD.Name = "btnsearchD";
            this.btnsearchD.Size = new System.Drawing.Size(91, 27);
            this.btnsearchD.TabIndex = 3;
            this.btnsearchD.Text = "Tìm";
            this.btnsearchD.UseVisualStyleBackColor = true;
            this.btnsearchD.Click += new System.EventHandler(this.btnsearchD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm";
            // 
            // cbbLHC
            // 
            this.cbbLHC.FormattingEnabled = true;
            this.cbbLHC.Location = new System.Drawing.Point(35, 132);
            this.cbbLHC.Name = "cbbLHC";
            this.cbbLHC.Size = new System.Drawing.Size(145, 24);
            this.cbbLHC.TabIndex = 31;
            this.cbbLHC.SelectedIndexChanged += new System.EventHandler(this.cbbLHC_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Lớp Tín chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tên Môn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Thông tin";
            // 
            // txtDname
            // 
            this.txtDname.Location = new System.Drawing.Point(134, 348);
            this.txtDname.Name = "txtDname";
            this.txtDname.ReadOnly = true;
            this.txtDname.Size = new System.Drawing.Size(170, 22);
            this.txtDname.TabIndex = 37;
            // 
            // txtDlophc
            // 
            this.txtDlophc.Location = new System.Drawing.Point(134, 386);
            this.txtDlophc.Name = "txtDlophc";
            this.txtDlophc.Size = new System.Drawing.Size(170, 22);
            this.txtDlophc.TabIndex = 38;
            // 
            // txtDCH
            // 
            this.txtDCH.Location = new System.Drawing.Point(159, 474);
            this.txtDCH.Name = "txtDCH";
            this.txtDCH.Size = new System.Drawing.Size(145, 22);
            this.txtDCH.TabIndex = 39;
            // 
            // txtDGK
            // 
            this.txtDGK.Location = new System.Drawing.Point(159, 518);
            this.txtDGK.Name = "txtDGK";
            this.txtDGK.Size = new System.Drawing.Size(145, 22);
            this.txtDGK.TabIndex = 40;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(159, 558);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(145, 22);
            this.txtDT.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tên Sinh Viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Điểm chuyên cần";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Điểm giữa kì";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 563);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Điểm thi";
            // 
            // btnDsua
            // 
            this.btnDsua.Location = new System.Drawing.Point(59, 654);
            this.btnDsua.Name = "btnDsua";
            this.btnDsua.Size = new System.Drawing.Size(75, 40);
            this.btnDsua.TabIndex = 48;
            this.btnDsua.Text = "Sửa";
            this.btnDsua.UseVisualStyleBackColor = true;
            this.btnDsua.Click += new System.EventHandler(this.btnDsua_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(159, 654);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 44);
            this.btnclear.TabIndex = 49;
            this.btnclear.Text = "Làm Mới";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "Mã Sinh Viên";
            // 
            // txtDmaSV
            // 
            this.txtDmaSV.Location = new System.Drawing.Point(134, 312);
            this.txtDmaSV.Name = "txtDmaSV";
            this.txtDmaSV.ReadOnly = true;
            this.txtDmaSV.Size = new System.Drawing.Size(170, 22);
            this.txtDmaSV.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 595);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Điểm Trung Bình";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(159, 590);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.ReadOnly = true;
            this.txtDTB.Size = new System.Drawing.Size(145, 22);
            this.txtDTB.TabIndex = 54;
            // 
            // btnHTT
            // 
            this.btnHTT.Location = new System.Drawing.Point(186, 164);
            this.btnHTT.Name = "btnHTT";
            this.btnHTT.Size = new System.Drawing.Size(91, 42);
            this.btnHTT.TabIndex = 55;
            this.btnHTT.Text = "Hiện tất cả";
            this.btnHTT.UseVisualStyleBackColor = true;
            this.btnHTT.Click += new System.EventHandler(this.btnHTT_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 56;
            this.label14.Text = "Mã sinh viên";
            // 
            // txtmasvtensv
            // 
            this.txtmasvtensv.Location = new System.Drawing.Point(38, 230);
            this.txtmasvtensv.Name = "txtmasvtensv";
            this.txtmasvtensv.Size = new System.Drawing.Size(142, 22);
            this.txtmasvtensv.TabIndex = 57;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(186, 229);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(91, 23);
            this.btnAdd2.TabIndex = 58;
            this.btnAdd2.Text = "Tìm";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 420);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 59;
            this.label15.Text = "Lớp Tín chỉ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 447);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 60;
            this.label16.Text = "Tên Môn:";
            // 
            // txtloptc
            // 
            this.txtloptc.Enabled = false;
            this.txtloptc.Location = new System.Drawing.Point(134, 420);
            this.txtloptc.Name = "txtloptc";
            this.txtloptc.Size = new System.Drawing.Size(170, 22);
            this.txtloptc.TabIndex = 61;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 777);
            this.Controls.Add(this.txtloptc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.txtmasvtensv);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnHTT);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDmaSV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnDsua);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtDGK);
            this.Controls.Add(this.txtDCH);
            this.Controls.Add(this.txtDlophc);
            this.Controls.Add(this.txtDname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbLHC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsearchD);
            this.Controls.Add(this.DSD);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiem";
            this.Text = "FormDiem";
            ((System.ComponentModel.ISupportInitialize)(this.DSD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DSD;
        private System.Windows.Forms.Button btnsearchD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLHC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDname;
        private System.Windows.Forms.TextBox txtDlophc;
        private System.Windows.Forms.TextBox txtDCH;
        private System.Windows.Forms.TextBox txtDGK;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDsua;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDmaSV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Button btnHTT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtmasvtensv;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtloptc;
    }
}