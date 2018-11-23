namespace bugTracking.programmer
{
    partial class ProgrammerPanel
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
            this.button_solution = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_viewreport = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_bughis = new System.Windows.Forms.Button();
            this.btn_bug_notsolved = new System.Windows.Forms.Button();
            this.label_bugactive = new System.Windows.Forms.Label();
            this.btn_bug_solve = new System.Windows.Forms.Button();
            this.label_bugsolved = new System.Windows.Forms.Label();
            this.btn__bug_report = new System.Windows.Forms.Button();
            this.lbl_countbugreport = new System.Windows.Forms.Label();
            this.btn_versioncontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_solution
            // 
            this.button_solution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.button_solution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_solution.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_solution.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_solution.Location = new System.Drawing.Point(49, 124);
            this.button_solution.Name = "button_solution";
            this.button_solution.Size = new System.Drawing.Size(181, 97);
            this.button_solution.TabIndex = 21;
            this.button_solution.Text = "Add Bug Solution";
            this.button_solution.UseVisualStyleBackColor = false;
            this.button_solution.Click += new System.EventHandler(this.button_solution_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "User:";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lblLoggedInUser.Location = new System.Drawing.Point(64, 19);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(0, 20);
            this.lblLoggedInUser.TabIndex = 17;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(334, 227);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(91, 165);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.ForeColor = System.Drawing.Color.White;
            this.btn_help.Location = new System.Drawing.Point(49, 227);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(181, 89);
            this.btn_help.TabIndex = 9;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = false;
            // 
            // btn_viewreport
            // 
            this.btn_viewreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_viewreport.FlatAppearance.BorderSize = 0;
            this.btn_viewreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewreport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewreport.ForeColor = System.Drawing.Color.White;
            this.btn_viewreport.Location = new System.Drawing.Point(236, 124);
            this.btn_viewreport.Name = "btn_viewreport";
            this.btn_viewreport.Size = new System.Drawing.Size(189, 97);
            this.btn_viewreport.TabIndex = 10;
            this.btn_viewreport.Text = "View Assigned bug";
            this.btn_viewreport.UseVisualStyleBackColor = false;
            this.btn_viewreport.Click += new System.EventHandler(this.btn_viewreport_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.White;
            this.btn_setting.Location = new System.Drawing.Point(237, 227);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(91, 89);
            this.btn_setting.TabIndex = 12;
            this.btn_setting.Text = "Setting";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(112, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bug Tracking Application";
            // 
            // button_bughis
            // 
            this.button_bughis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.button_bughis.FlatAppearance.BorderSize = 0;
            this.button_bughis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bughis.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_bughis.ForeColor = System.Drawing.Color.White;
            this.button_bughis.Location = new System.Drawing.Point(49, 322);
            this.button_bughis.Name = "button_bughis";
            this.button_bughis.Size = new System.Drawing.Size(279, 70);
            this.button_bughis.TabIndex = 22;
            this.button_bughis.Text = "Bug History";
            this.button_bughis.UseVisualStyleBackColor = false;
            this.button_bughis.Click += new System.EventHandler(this.button_bughis_Click);
            // 
            // btn_bug_notsolved
            // 
            this.btn_bug_notsolved.BackColor = System.Drawing.Color.Gray;
            this.btn_bug_notsolved.Enabled = false;
            this.btn_bug_notsolved.FlatAppearance.BorderSize = 0;
            this.btn_bug_notsolved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bug_notsolved.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bug_notsolved.ForeColor = System.Drawing.Color.White;
            this.btn_bug_notsolved.Location = new System.Drawing.Point(2, 425);
            this.btn_bug_notsolved.Name = "btn_bug_notsolved";
            this.btn_bug_notsolved.Size = new System.Drawing.Size(202, 72);
            this.btn_bug_notsolved.TabIndex = 23;
            this.btn_bug_notsolved.Text = "Bug unsolved";
            this.btn_bug_notsolved.UseVisualStyleBackColor = false;
            // 
            // label_bugactive
            // 
            this.label_bugactive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_bugactive.BackColor = System.Drawing.Color.Gray;
            this.label_bugactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_bugactive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bugactive.ForeColor = System.Drawing.Color.White;
            this.label_bugactive.Location = new System.Drawing.Point(104, 425);
            this.label_bugactive.Name = "label_bugactive";
            this.label_bugactive.Size = new System.Drawing.Size(100, 25);
            this.label_bugactive.TabIndex = 24;
            this.label_bugactive.Text = "0";
            this.label_bugactive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_bug_solve
            // 
            this.btn_bug_solve.BackColor = System.Drawing.Color.Gray;
            this.btn_bug_solve.Enabled = false;
            this.btn_bug_solve.FlatAppearance.BorderSize = 0;
            this.btn_bug_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bug_solve.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bug_solve.ForeColor = System.Drawing.Color.White;
            this.btn_bug_solve.Location = new System.Drawing.Point(210, 425);
            this.btn_bug_solve.Name = "btn_bug_solve";
            this.btn_bug_solve.Size = new System.Drawing.Size(176, 72);
            this.btn_bug_solve.TabIndex = 25;
            this.btn_bug_solve.Text = "Bug Solved";
            this.btn_bug_solve.UseVisualStyleBackColor = false;
            // 
            // label_bugsolved
            // 
            this.label_bugsolved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_bugsolved.BackColor = System.Drawing.Color.Gray;
            this.label_bugsolved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_bugsolved.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bugsolved.ForeColor = System.Drawing.Color.White;
            this.label_bugsolved.Location = new System.Drawing.Point(335, 429);
            this.label_bugsolved.Name = "label_bugsolved";
            this.label_bugsolved.Size = new System.Drawing.Size(51, 25);
            this.label_bugsolved.TabIndex = 26;
            this.label_bugsolved.Text = "0";
            this.label_bugsolved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn__bug_report
            // 
            this.btn__bug_report.BackColor = System.Drawing.Color.Gray;
            this.btn__bug_report.Enabled = false;
            this.btn__bug_report.FlatAppearance.BorderSize = 0;
            this.btn__bug_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn__bug_report.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__bug_report.ForeColor = System.Drawing.Color.White;
            this.btn__bug_report.Location = new System.Drawing.Point(392, 425);
            this.btn__bug_report.Name = "btn__bug_report";
            this.btn__bug_report.Size = new System.Drawing.Size(187, 70);
            this.btn__bug_report.TabIndex = 27;
            this.btn__bug_report.Text = "Bug Reported";
            this.btn__bug_report.UseVisualStyleBackColor = false;
            // 
            // lbl_countbugreport
            // 
            this.lbl_countbugreport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_countbugreport.BackColor = System.Drawing.Color.Gray;
            this.lbl_countbugreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_countbugreport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_countbugreport.ForeColor = System.Drawing.Color.White;
            this.lbl_countbugreport.Location = new System.Drawing.Point(511, 425);
            this.lbl_countbugreport.Name = "lbl_countbugreport";
            this.lbl_countbugreport.Size = new System.Drawing.Size(58, 25);
            this.lbl_countbugreport.TabIndex = 28;
            this.lbl_countbugreport.Text = "0";
            this.lbl_countbugreport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_versioncontrol
            // 
            this.btn_versioncontrol.BackColor = System.Drawing.Color.Crimson;
            this.btn_versioncontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_versioncontrol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_versioncontrol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_versioncontrol.Location = new System.Drawing.Point(427, 124);
            this.btn_versioncontrol.Name = "btn_versioncontrol";
            this.btn_versioncontrol.Size = new System.Drawing.Size(142, 268);
            this.btn_versioncontrol.TabIndex = 29;
            this.btn_versioncontrol.Text = "Version Control";
            this.btn_versioncontrol.UseVisualStyleBackColor = false;
            this.btn_versioncontrol.Click += new System.EventHandler(this.btn_versioncontrol_Click);
            // 
            // ProgrammerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(581, 509);
            this.Controls.Add(this.btn_versioncontrol);
            this.Controls.Add(this.lbl_countbugreport);
            this.Controls.Add(this.btn__bug_report);
            this.Controls.Add(this.label_bugsolved);
            this.Controls.Add(this.btn_bug_solve);
            this.Controls.Add(this.label_bugactive);
            this.Controls.Add(this.btn_bug_notsolved);
            this.Controls.Add(this.button_bughis);
            this.Controls.Add(this.button_solution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_viewreport);
            this.Controls.Add(this.btn_setting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProgrammerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgrammerPanel";
            this.Load += new System.EventHandler(this.ProgrammerPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_solution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_viewreport;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_bughis;
        private System.Windows.Forms.Button btn_bug_notsolved;
        private System.Windows.Forms.Label label_bugactive;
        private System.Windows.Forms.Button btn_bug_solve;
        private System.Windows.Forms.Label label_bugsolved;
        private System.Windows.Forms.Button btn__bug_report;
        private System.Windows.Forms.Label lbl_countbugreport;
        private System.Windows.Forms.Button btn_versioncontrol;
    }
}