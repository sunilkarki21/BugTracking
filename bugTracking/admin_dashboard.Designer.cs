namespace bugTracking
{
    partial class admin_dashboard
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
            this.btn_viewbug = new System.Windows.Forms.Button();
            this.btn_assign = new System.Windows.Forms.Button();
            this.btn_viewuser = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_countuser = new System.Windows.Forms.Label();
            this.btn_versioncontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_viewbug
            // 
            this.btn_viewbug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_viewbug.FlatAppearance.BorderSize = 0;
            this.btn_viewbug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewbug.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_viewbug.ForeColor = System.Drawing.Color.White;
            this.btn_viewbug.Location = new System.Drawing.Point(305, 85);
            this.btn_viewbug.Name = "btn_viewbug";
            this.btn_viewbug.Size = new System.Drawing.Size(195, 70);
            this.btn_viewbug.TabIndex = 0;
            this.btn_viewbug.Text = "View Bugs";
            this.btn_viewbug.UseVisualStyleBackColor = false;
            this.btn_viewbug.Click += new System.EventHandler(this.btn_viewbug_Click);
            // 
            // btn_assign
            // 
            this.btn_assign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_assign.FlatAppearance.BorderSize = 0;
            this.btn_assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_assign.ForeColor = System.Drawing.Color.White;
            this.btn_assign.Location = new System.Drawing.Point(104, 161);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(105, 168);
            this.btn_assign.TabIndex = 0;
            this.btn_assign.Text = "Assign Bug";
            this.btn_assign.UseVisualStyleBackColor = false;
            this.btn_assign.Click += new System.EventHandler(this.btn_assign_Click);
            // 
            // btn_viewuser
            // 
            this.btn_viewuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_viewuser.FlatAppearance.BorderSize = 0;
            this.btn_viewuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_viewuser.ForeColor = System.Drawing.Color.White;
            this.btn_viewuser.Location = new System.Drawing.Point(104, 85);
            this.btn_viewuser.Name = "btn_viewuser";
            this.btn_viewuser.Size = new System.Drawing.Size(195, 70);
            this.btn_viewuser.TabIndex = 0;
            this.btn_viewuser.Text = "View User";
            this.btn_viewuser.UseVisualStyleBackColor = false;
            this.btn_viewuser.Click += new System.EventHandler(this.btn_viewuser_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(215, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(285, 70);
            this.button4.TabIndex = 0;
            this.button4.Text = "View Fixed Bugs";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(363, 237);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(137, 92);
            this.button_logout.TabIndex = 0;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(220, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Dashboard";
            // 
            // lbl_countuser
            // 
            this.lbl_countuser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_countuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lbl_countuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_countuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_countuser.ForeColor = System.Drawing.Color.White;
            this.lbl_countuser.Location = new System.Drawing.Point(199, 120);
            this.lbl_countuser.Name = "lbl_countuser";
            this.lbl_countuser.Size = new System.Drawing.Size(100, 0);
            this.lbl_countuser.TabIndex = 2;
            this.lbl_countuser.Text = "0";
            this.lbl_countuser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_versioncontrol
            // 
            this.btn_versioncontrol.BackColor = System.Drawing.Color.Crimson;
            this.btn_versioncontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_versioncontrol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_versioncontrol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_versioncontrol.Location = new System.Drawing.Point(215, 237);
            this.btn_versioncontrol.Name = "btn_versioncontrol";
            this.btn_versioncontrol.Size = new System.Drawing.Size(142, 92);
            this.btn_versioncontrol.TabIndex = 3;
            this.btn_versioncontrol.Text = "Version Control";
            this.btn_versioncontrol.UseVisualStyleBackColor = false;
            this.btn_versioncontrol.Click += new System.EventHandler(this.btn_versioncontrol_Click);
            // 
            // admin_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 399);
            this.Controls.Add(this.btn_versioncontrol);
            this.Controls.Add(this.lbl_countuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_viewuser);
            this.Controls.Add(this.btn_assign);
            this.Controls.Add(this.btn_viewbug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "admin_dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin dashboard";
            this.Load += new System.EventHandler(this.admin_dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_viewbug;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Button btn_viewuser;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_countuser;
        private System.Windows.Forms.Button btn_versioncontrol;
    }
}