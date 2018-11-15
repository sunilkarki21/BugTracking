namespace bugTracking.user
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_bug_solve = new System.Windows.Forms.Button();
            this.btn_bug_notsolved = new System.Windows.Forms.Button();
            this.btn_add_bug = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn__bug_report = new System.Windows.Forms.Button();
            this.lbl_countbugreport = new System.Windows.Forms.Label();
            this.label_bugsolved = new System.Windows.Forms.Label();
            this.label_bugactive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_bug_solve
            // 
            this.btn_bug_solve.BackColor = System.Drawing.Color.Gray;
            this.btn_bug_solve.Enabled = false;
            this.btn_bug_solve.FlatAppearance.BorderSize = 0;
            this.btn_bug_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bug_solve.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bug_solve.ForeColor = System.Drawing.Color.White;
            this.btn_bug_solve.Location = new System.Drawing.Point(203, 318);
            this.btn_bug_solve.Name = "btn_bug_solve";
            this.btn_bug_solve.Size = new System.Drawing.Size(176, 68);
            this.btn_bug_solve.TabIndex = 3;
            this.btn_bug_solve.Text = "Bug Solved";
            this.btn_bug_solve.UseVisualStyleBackColor = false;
            // 
            // btn_bug_notsolved
            // 
            this.btn_bug_notsolved.BackColor = System.Drawing.Color.Gray;
            this.btn_bug_notsolved.Enabled = false;
            this.btn_bug_notsolved.FlatAppearance.BorderSize = 0;
            this.btn_bug_notsolved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bug_notsolved.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bug_notsolved.ForeColor = System.Drawing.Color.White;
            this.btn_bug_notsolved.Location = new System.Drawing.Point(-5, 318);
            this.btn_bug_notsolved.Name = "btn_bug_notsolved";
            this.btn_bug_notsolved.Size = new System.Drawing.Size(202, 72);
            this.btn_bug_notsolved.TabIndex = 3;
            this.btn_bug_notsolved.Text = "Bug unsolved";
            this.btn_bug_notsolved.UseVisualStyleBackColor = false;
            // 
            // btn_add_bug
            // 
            this.btn_add_bug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_add_bug.FlatAppearance.BorderSize = 0;
            this.btn_add_bug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_bug.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_bug.ForeColor = System.Drawing.Color.White;
            this.btn_add_bug.Location = new System.Drawing.Point(159, 101);
            this.btn_add_bug.Name = "btn_add_bug";
            this.btn_add_bug.Size = new System.Drawing.Size(182, 68);
            this.btn_add_bug.TabIndex = 3;
            this.btn_add_bug.Text = "Add Bug Report";
            this.btn_add_bug.UseVisualStyleBackColor = false;
            this.btn_add_bug.Click += new System.EventHandler(this.btn_add_bug_Click);
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.ForeColor = System.Drawing.Color.White;
            this.btn_help.Location = new System.Drawing.Point(159, 175);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(182, 137);
            this.btn_help.TabIndex = 3;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(347, 101);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(91, 137);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(182, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bug Tracking Application";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lblLoggedInUser.Location = new System.Drawing.Point(62, 9);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(0, 20);
            this.lblLoggedInUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "User:";
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.White;
            this.btn_setting.Location = new System.Drawing.Point(347, 244);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(91, 68);
            this.btn_setting.TabIndex = 3;
            this.btn_setting.Text = "Setting";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn__bug_report
            // 
            this.btn__bug_report.BackColor = System.Drawing.Color.Gray;
            this.btn__bug_report.Enabled = false;
            this.btn__bug_report.FlatAppearance.BorderSize = 0;
            this.btn__bug_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn__bug_report.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__bug_report.ForeColor = System.Drawing.Color.White;
            this.btn__bug_report.Location = new System.Drawing.Point(385, 318);
            this.btn__bug_report.Name = "btn__bug_report";
            this.btn__bug_report.Size = new System.Drawing.Size(187, 68);
            this.btn__bug_report.TabIndex = 3;
            this.btn__bug_report.Text = "Bug Reported";
            this.btn__bug_report.UseVisualStyleBackColor = false;
            this.btn__bug_report.Click += new System.EventHandler(this.btn__bug_report_Click);
            // 
            // lbl_countbugreport
            // 
            this.lbl_countbugreport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_countbugreport.BackColor = System.Drawing.Color.Gray;
            this.lbl_countbugreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_countbugreport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_countbugreport.ForeColor = System.Drawing.Color.White;
            this.lbl_countbugreport.Location = new System.Drawing.Point(497, 318);
            this.lbl_countbugreport.Name = "lbl_countbugreport";
            this.lbl_countbugreport.Size = new System.Drawing.Size(58, 25);
            this.lbl_countbugreport.TabIndex = 6;
            this.lbl_countbugreport.Text = "0";
            this.lbl_countbugreport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_bugsolved
            // 
            this.label_bugsolved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_bugsolved.BackColor = System.Drawing.Color.Gray;
            this.label_bugsolved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_bugsolved.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bugsolved.ForeColor = System.Drawing.Color.White;
            this.label_bugsolved.Location = new System.Drawing.Point(328, 318);
            this.label_bugsolved.Name = "label_bugsolved";
            this.label_bugsolved.Size = new System.Drawing.Size(51, 25);
            this.label_bugsolved.TabIndex = 6;
            this.label_bugsolved.Text = "0";
            this.label_bugsolved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_bugactive
            // 
            this.label_bugactive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_bugactive.BackColor = System.Drawing.Color.Gray;
            this.label_bugactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_bugactive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bugactive.ForeColor = System.Drawing.Color.White;
            this.label_bugactive.Location = new System.Drawing.Point(97, 318);
            this.label_bugactive.Name = "label_bugactive";
            this.label_bugactive.Size = new System.Drawing.Size(100, 25);
            this.label_bugactive.TabIndex = 6;
            this.label_bugactive.Text = "0";
            this.label_bugactive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 386);
            this.Controls.Add(this.label_bugactive);
            this.Controls.Add(this.label_bugsolved);
            this.Controls.Add(this.lbl_countbugreport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_add_bug);
            this.Controls.Add(this.btn_bug_notsolved);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_bug_solve);
            this.Controls.Add(this.btn__bug_report);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard ";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btn_bug_solve;
        private System.Windows.Forms.Button btn_bug_notsolved;
        private System.Windows.Forms.Button btn_add_bug;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn__bug_report;
        private System.Windows.Forms.Label lbl_countbugreport;
        private System.Windows.Forms.Label label_bugsolved;
        private System.Windows.Forms.Label label_bugactive;
    }
}



