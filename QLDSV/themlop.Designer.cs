
namespace QLDSV
{
    partial class themlop
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
            this.txtNamhoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbGV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMAM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbtenmon11 = new System.Windows.Forms.ComboBox();
            this.cbbkyhoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNamhoc
            // 
            this.txtNamhoc.Location = new System.Drawing.Point(216, 211);
            this.txtNamhoc.Name = "txtNamhoc";
            this.txtNamhoc.Size = new System.Drawing.Size(123, 22);
            this.txtNamhoc.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Năm Học";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Kì học";
            // 
            // cbbGV
            // 
            this.cbbGV.FormattingEnabled = true;
            this.cbbGV.Location = new System.Drawing.Point(216, 168);
            this.cbbGV.Name = "cbbGV";
            this.cbbGV.Size = new System.Drawing.Size(170, 24);
            this.cbbGV.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tên Môn";
            // 
            // txtMAM
            // 
            this.txtMAM.Location = new System.Drawing.Point(216, 54);
            this.txtMAM.Name = "txtMAM";
            this.txtMAM.Size = new System.Drawing.Size(136, 22);
            this.txtMAM.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Giảng Viên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã Lớp Tín chỉ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 38);
            this.button1.TabIndex = 39;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thêm Lớp Tín Chỉ";
            // 
            // cbbtenmon11
            // 
            this.cbbtenmon11.FormattingEnabled = true;
            this.cbbtenmon11.Location = new System.Drawing.Point(216, 83);
            this.cbbtenmon11.Name = "cbbtenmon11";
            this.cbbtenmon11.Size = new System.Drawing.Size(181, 24);
            this.cbbtenmon11.TabIndex = 41;
            // 
            // cbbkyhoc
            // 
            this.cbbkyhoc.FormattingEnabled = true;
            this.cbbkyhoc.Items.AddRange(new object[] {
            "Kỳ 1",
            "Kỳ 2"});
            this.cbbkyhoc.Location = new System.Drawing.Point(218, 130);
            this.cbbkyhoc.Name = "cbbkyhoc";
            this.cbbkyhoc.Size = new System.Drawing.Size(121, 24);
            this.cbbkyhoc.TabIndex = 42;
            // 
            // themlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 357);
            this.Controls.Add(this.cbbkyhoc);
            this.Controls.Add(this.cbbtenmon11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNamhoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMAM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "themlop";
            this.Text = "Thêm Lớp Tín Chỉ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.themlop_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNamhoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbtenmon11;
        private System.Windows.Forms.ComboBox cbbkyhoc;
    }
}