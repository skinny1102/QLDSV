
namespace QLDSV
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.out_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.out_button);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.PassWord);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 194);
            this.panel1.TabIndex = 0;
            // 
            // out_button
            // 
            this.out_button.Location = new System.Drawing.Point(206, 150);
            this.out_button.Name = "out_button";
            this.out_button.Size = new System.Drawing.Size(113, 33);
            this.out_button.TabIndex = 5;
            this.out_button.Text = "Thoát";
            this.out_button.UseVisualStyleBackColor = true;
            this.out_button.Click += new System.EventHandler(this.out_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(206, 111);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(113, 33);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Đăng Nhập";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // PassWord
            // 
            this.PassWord.Location = new System.Drawing.Point(161, 83);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(202, 22);
            this.PassWord.TabIndex = 3;
            this.PassWord.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(161, 38);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(202, 22);
            this.Username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 211);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button out_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

