﻿
namespace QLDSV
{
    partial class Baocao
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtLopHC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMalopTC = new System.Windows.Forms.TextBox();
            this.btndiemtc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xuất báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLopHC
            // 
            this.txtLopHC.Location = new System.Drawing.Point(164, 107);
            this.txtLopHC.Name = "txtLopHC";
            this.txtLopHC.Size = new System.Drawing.Size(128, 22);
            this.txtLopHC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã lớp hành chính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách sinh viên lớp hành chính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Báo Cáo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Danh sách điểm viên theo lớp tín chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã tín chỉ";
            // 
            // txtMalopTC
            // 
            this.txtMalopTC.Location = new System.Drawing.Point(164, 250);
            this.txtMalopTC.Name = "txtMalopTC";
            this.txtMalopTC.Size = new System.Drawing.Size(128, 22);
            this.txtMalopTC.TabIndex = 7;
            // 
            // btndiemtc
            // 
            this.btndiemtc.Location = new System.Drawing.Point(164, 278);
            this.btndiemtc.Name = "btndiemtc";
            this.btndiemtc.Size = new System.Drawing.Size(128, 38);
            this.btndiemtc.TabIndex = 8;
            this.btndiemtc.Text = "Xuất báo cáo";
            this.btndiemtc.UseVisualStyleBackColor = true;
            this.btndiemtc.Click += new System.EventHandler(this.btndiemtc_Click);
            // 
            // Baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 730);
            this.Controls.Add(this.btndiemtc);
            this.Controls.Add(this.txtMalopTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLopHC);
            this.Controls.Add(this.button1);
            this.Name = "Baocao";
            this.Text = "Baocao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLopHC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMalopTC;
        private System.Windows.Forms.Button btndiemtc;
    }
}