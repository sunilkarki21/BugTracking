namespace bugTracking.user
{
    partial class BugSolution
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbBox_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.solvedate = new System.Windows.Forms.DateTimePicker();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.txtBox_bugID = new System.Windows.Forms.TextBox();
            this.lbl_project = new System.Windows.Forms.Label();
            this.lbl_reportDate = new System.Windows.Forms.Label();
            this.lbl_bugDescription = new System.Windows.Forms.Label();
            this.lbl_bugTitle = new System.Windows.Forms.Label();
            this.lbl_addBug = new System.Windows.Forms.Label();
            this.lbl_bugID = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_desc = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txt_bugsol = new System.Windows.Forms.TextBox();
            this.btn_solution = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bugtitle = new System.Windows.Forms.TextBox();
            this.txtboxProject = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // cmbBox_status
            // 
            this.cmbBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_status.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbBox_status.FormattingEnabled = true;
            this.cmbBox_status.Items.AddRange(new object[] {
            "Solved",
            "Unsolved"});
            this.cmbBox_status.Location = new System.Drawing.Point(214, 562);
            this.cmbBox_status.Name = "cmbBox_status";
            this.cmbBox_status.Size = new System.Drawing.Size(309, 25);
            this.cmbBox_status.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(31, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Status";
            // 
            // solvedate
            // 
            this.solvedate.Checked = false;
            this.solvedate.CustomFormat = "yyyy-MM-dd";
            this.solvedate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.solvedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.solvedate.Location = new System.Drawing.Point(214, 532);
            this.solvedate.Name = "solvedate";
            this.solvedate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.solvedate.Size = new System.Drawing.Size(200, 24);
            this.solvedate.TabIndex = 27;
            this.solvedate.Value = new System.DateTime(2018, 11, 9, 0, 0, 0, 0);
            // 
            // txt_method
            // 
            this.txt_method.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_method.Location = new System.Drawing.Point(214, 180);
            this.txt_method.Name = "txt_method";
            this.txt_method.Size = new System.Drawing.Size(309, 27);
            this.txt_method.TabIndex = 26;
            // 
            // txt_class
            // 
            this.txt_class.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_class.Location = new System.Drawing.Point(214, 150);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(309, 24);
            this.txt_class.TabIndex = 25;
            // 
            // txtBox_bugID
            // 
            this.txtBox_bugID.Location = new System.Drawing.Point(214, 56);
            this.txtBox_bugID.Name = "txtBox_bugID";
            this.txtBox_bugID.ReadOnly = true;
            this.txtBox_bugID.Size = new System.Drawing.Size(136, 20);
            this.txtBox_bugID.TabIndex = 24;
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_project.Location = new System.Drawing.Point(31, 86);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(64, 21);
            this.lbl_project.TabIndex = 22;
            this.lbl_project.Text = "Project";
            // 
            // lbl_reportDate
            // 
            this.lbl_reportDate.AutoSize = true;
            this.lbl_reportDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reportDate.Location = new System.Drawing.Point(31, 535);
            this.lbl_reportDate.Name = "lbl_reportDate";
            this.lbl_reportDate.Size = new System.Drawing.Size(94, 21);
            this.lbl_reportDate.TabIndex = 19;
            this.lbl_reportDate.Text = "Solve date";
            // 
            // lbl_bugDescription
            // 
            this.lbl_bugDescription.AutoSize = true;
            this.lbl_bugDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugDescription.Location = new System.Drawing.Point(31, 183);
            this.lbl_bugDescription.Name = "lbl_bugDescription";
            this.lbl_bugDescription.Size = new System.Drawing.Size(73, 21);
            this.lbl_bugDescription.TabIndex = 18;
            this.lbl_bugDescription.Text = "Method";
            // 
            // lbl_bugTitle
            // 
            this.lbl_bugTitle.AutoSize = true;
            this.lbl_bugTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugTitle.Location = new System.Drawing.Point(31, 153);
            this.lbl_bugTitle.Name = "lbl_bugTitle";
            this.lbl_bugTitle.Size = new System.Drawing.Size(49, 21);
            this.lbl_bugTitle.TabIndex = 17;
            this.lbl_bugTitle.Text = "Class";
            // 
            // lbl_addBug
            // 
            this.lbl_addBug.AutoSize = true;
            this.lbl_addBug.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_addBug.Location = new System.Drawing.Point(234, 24);
            this.lbl_addBug.Name = "lbl_addBug";
            this.lbl_addBug.Size = new System.Drawing.Size(193, 26);
            this.lbl_addBug.TabIndex = 23;
            this.lbl_addBug.Text = "Add Bug Solution";
            // 
            // lbl_bugID
            // 
            this.lbl_bugID.AutoSize = true;
            this.lbl_bugID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugID.Location = new System.Drawing.Point(31, 56);
            this.lbl_bugID.Name = "lbl_bugID";
            this.lbl_bugID.Size = new System.Drawing.Size(61, 21);
            this.lbl_bugID.TabIndex = 16;
            this.lbl_bugID.Text = "Bug ID";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(559, 82);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(577, 463);
            this.dgv1.TabIndex = 33;
            this.dgv1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Line no.";
            // 
            // txt_line
            // 
            this.txt_line.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_line.Location = new System.Drawing.Point(214, 213);
            this.txt_line.Name = "txt_line";
            this.txt_line.Size = new System.Drawing.Size(309, 24);
            this.txt_line.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Report Date\r\n";
            // 
            // reportDate
            // 
            this.reportDate.Checked = false;
            this.reportDate.CustomFormat = "yyyy-MM-dd";
            this.reportDate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.reportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportDate.Location = new System.Drawing.Point(214, 502);
            this.reportDate.Name = "reportDate";
            this.reportDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportDate.Size = new System.Drawing.Size(200, 24);
            this.reportDate.TabIndex = 27;
            this.reportDate.Value = new System.DateTime(2018, 11, 9, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(31, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Solved code";
            // 
            // txtbox_desc
            // 
            this.txtbox_desc.AutoSize = true;
            this.txtbox_desc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbox_desc.Location = new System.Drawing.Point(31, 244);
            this.txtbox_desc.Name = "txtbox_desc";
            this.txtbox_desc.Size = new System.Drawing.Size(89, 21);
            this.txtbox_desc.TabIndex = 35;
            this.txtbox_desc.Text = "Error code";
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(214, 243);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.ReadOnly = true;
            this.txtdes.Size = new System.Drawing.Size(309, 126);
            this.txtdes.TabIndex = 36;
            // 
            // txt_bugsol
            // 
            this.txt_bugsol.Location = new System.Drawing.Point(214, 375);
            this.txt_bugsol.Multiline = true;
            this.txt_bugsol.Name = "txt_bugsol";
            this.txt_bugsol.Size = new System.Drawing.Size(309, 121);
            this.txt_bugsol.TabIndex = 37;
            // 
            // btn_solution
            // 
            this.btn_solution.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_solution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_solution.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_solution.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_solution.Location = new System.Drawing.Point(750, 551);
            this.btn_solution.Name = "btn_solution";
            this.btn_solution.Size = new System.Drawing.Size(145, 35);
            this.btn_solution.TabIndex = 38;
            this.btn_solution.Text = "Add Solution";
            this.btn_solution.UseVisualStyleBackColor = false;
            this.btn_solution.Click += new System.EventHandler(this.btn_solution_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(901, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 36);
            this.button2.TabIndex = 39;
            this.button2.Text = "Edit Solution";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(1047, 552);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 35);
            this.button3.TabIndex = 40;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Solved",
            "Not Solved"});
            this.comboBox1.Location = new System.Drawing.Point(692, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(572, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Sort By Status";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(946, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 43;
            this.button4.Text = "Show All";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(31, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "Bug Title";
            // 
            // txt_bugtitle
            // 
            this.txt_bugtitle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_bugtitle.Location = new System.Drawing.Point(214, 119);
            this.txt_bugtitle.Name = "txt_bugtitle";
            this.txt_bugtitle.ReadOnly = true;
            this.txt_bugtitle.Size = new System.Drawing.Size(309, 24);
            this.txt_bugtitle.TabIndex = 45;
            // 
            // txtboxProject
            // 
            this.txtboxProject.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtboxProject.Location = new System.Drawing.Point(214, 82);
            this.txtboxProject.Name = "txtboxProject";
            this.txtboxProject.ReadOnly = true;
            this.txtboxProject.Size = new System.Drawing.Size(309, 24);
            this.txtboxProject.TabIndex = 46;
            // 
            // BugSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1148, 603);
            this.Controls.Add(this.txtboxProject);
            this.Controls.Add(this.txt_bugtitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_solution);
            this.Controls.Add(this.txt_bugsol);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtbox_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cmbBox_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportDate);
            this.Controls.Add(this.solvedate);
            this.Controls.Add(this.txt_method);
            this.Controls.Add(this.txt_line);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.txtBox_bugID);
            this.Controls.Add(this.lbl_project);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_reportDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_bugDescription);
            this.Controls.Add(this.lbl_bugTitle);
            this.Controls.Add(this.lbl_addBug);
            this.Controls.Add(this.lbl_bugID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BugSolution";
            this.Text = "BugSolution";
            this.Load += new System.EventHandler(this.BugSolution_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbBox_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker solvedate;
        private System.Windows.Forms.TextBox txt_method;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.TextBox txtBox_bugID;
        private System.Windows.Forms.Label lbl_project;
        private System.Windows.Forms.Label lbl_reportDate;
        private System.Windows.Forms.Label lbl_bugDescription;
        private System.Windows.Forms.Label lbl_bugTitle;
        private System.Windows.Forms.Label lbl_addBug;
        private System.Windows.Forms.Label lbl_bugID;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_line;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker reportDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtbox_desc;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.TextBox txt_bugsol;
        private System.Windows.Forms.Button btn_solution;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bugtitle;
        private System.Windows.Forms.TextBox txtboxProject;
    }
}