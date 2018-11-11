namespace bugTracking.user
{
    partial class Register
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
            this.btn_register = new System.Windows.Forms.Button();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_conPwd = new System.Windows.Forms.TextBox();
            this.comboBox_usertype = new System.Windows.Forms.ComboBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_confirmPwd = new System.Windows.Forms.Label();
            this.lbl_utype = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(70, 363);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(263, 34);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // textBox_user
            // 
            this.textBox_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(70, 161);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(263, 27);
            this.textBox_user.TabIndex = 3;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pwd.Location = new System.Drawing.Point(70, 217);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(263, 27);
            this.textBox_pwd.TabIndex = 4;
            // 
            // textBox_conPwd
            // 
            this.textBox_conPwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_conPwd.Location = new System.Drawing.Point(70, 273);
            this.textBox_conPwd.Name = "textBox_conPwd";
            this.textBox_conPwd.Size = new System.Drawing.Size(263, 27);
            this.textBox_conPwd.TabIndex = 5;
            // 
            // comboBox_usertype
            // 
            this.comboBox_usertype.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_usertype.FormattingEnabled = true;
            this.comboBox_usertype.Items.AddRange(new object[] {
            "User",
            "Debugger"});
            this.comboBox_usertype.Location = new System.Drawing.Point(70, 329);
            this.comboBox_usertype.Name = "comboBox_usertype";
            this.comboBox_usertype.Size = new System.Drawing.Size(263, 29);
            this.comboBox_usertype.TabIndex = 6;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lbl_username.Location = new System.Drawing.Point(66, 137);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(87, 19);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lbl_password.Location = new System.Drawing.Point(66, 193);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(80, 19);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password";
            // 
            // lbl_confirmPwd
            // 
            this.lbl_confirmPwd.AutoSize = true;
            this.lbl_confirmPwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_confirmPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lbl_confirmPwd.Location = new System.Drawing.Point(66, 249);
            this.lbl_confirmPwd.Name = "lbl_confirmPwd";
            this.lbl_confirmPwd.Size = new System.Drawing.Size(145, 19);
            this.lbl_confirmPwd.TabIndex = 9;
            this.lbl_confirmPwd.Text = "Confirm Password";
            // 
            // lbl_utype
            // 
            this.lbl_utype.AutoSize = true;
            this.lbl_utype.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_utype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lbl_utype.Location = new System.Drawing.Point(66, 305);
            this.lbl_utype.Name = "lbl_utype";
            this.lbl_utype.Size = new System.Drawing.Size(74, 19);
            this.lbl_utype.TabIndex = 10;
            this.lbl_utype.Text = "Usertype";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Register New Account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2_close);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 100);
            this.panel1.TabIndex = 11;
            // 
            // label2_close
            // 
            this.label2_close.AutoSize = true;
            this.label2_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.label2_close.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2_close.ForeColor = System.Drawing.Color.Brown;
            this.label2_close.Location = new System.Drawing.Point(370, 12);
            this.label2_close.Name = "label2_close";
            this.label2_close.Size = new System.Drawing.Size(20, 19);
            this.label2_close.TabIndex = 7;
            this.label2_close.Text = "X";
            this.label2_close.Click += new System.EventHandler(this.label2_close_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_utype);
            this.Controls.Add(this.lbl_confirmPwd);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.comboBox_usertype);
            this.Controls.Add(this.textBox_conPwd);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.btn_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_conPwd;
        private System.Windows.Forms.ComboBox comboBox_usertype;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_confirmPwd;
        private System.Windows.Forms.Label lbl_utype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2_close;
    }
}