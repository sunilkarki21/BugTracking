namespace bugTracking.user
{
    partial class BugReport
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_bugTitle = new System.Windows.Forms.Label();
            this.lbl_bugDescription = new System.Windows.Forms.Label();
            this.lbl_project = new System.Windows.Forms.Label();
            this.lbl_reportDate = new System.Windows.Forms.Label();
            this.lbl_bugScreenshot = new System.Windows.Forms.Label();
            this.textBox_bugtitle = new System.Windows.Forms.TextBox();
            this.textBox_bugdescription = new System.Windows.Forms.TextBox();
            this.dateTimePicker_reportdate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.pictureBox_bugimg = new System.Windows.Forms.PictureBox();
            this.lbl_img_path = new System.Windows.Forms.Label();
            this.lbl_addBug = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_bug = new System.Windows.Forms.DataGridView();
            this.lbl_searchbug = new System.Windows.Forms.Label();
            this.txt_searchbug = new System.Windows.Forms.TextBox();
            this.btn_updatebug = new System.Windows.Forms.Button();
            this.lbl_bugID = new System.Windows.Forms.Label();
            this.txtBox_bugID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBox_status = new System.Windows.Forms.ComboBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bugimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bug)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenu,
            this.editMenu,
            this.toolsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // homeMenu
            // 
            this.homeMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(37, 20);
            this.homeMenu.Text = "&File";
            this.homeMenu.Click += new System.EventHandler(this.homeMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "&Edit";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(47, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // lbl_bugTitle
            // 
            this.lbl_bugTitle.AutoSize = true;
            this.lbl_bugTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugTitle.Location = new System.Drawing.Point(12, 156);
            this.lbl_bugTitle.Name = "lbl_bugTitle";
            this.lbl_bugTitle.Size = new System.Drawing.Size(75, 21);
            this.lbl_bugTitle.TabIndex = 1;
            this.lbl_bugTitle.Text = "Bug Title";
            // 
            // lbl_bugDescription
            // 
            this.lbl_bugDescription.AutoSize = true;
            this.lbl_bugDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugDescription.Location = new System.Drawing.Point(12, 201);
            this.lbl_bugDescription.Name = "lbl_bugDescription";
            this.lbl_bugDescription.Size = new System.Drawing.Size(131, 21);
            this.lbl_bugDescription.TabIndex = 1;
            this.lbl_bugDescription.Text = "Bug Description";
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_project.Location = new System.Drawing.Point(12, 111);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(64, 21);
            this.lbl_project.TabIndex = 1;
            this.lbl_project.Text = "Project";
            // 
            // lbl_reportDate
            // 
            this.lbl_reportDate.AutoSize = true;
            this.lbl_reportDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reportDate.Location = new System.Drawing.Point(12, 337);
            this.lbl_reportDate.Name = "lbl_reportDate";
            this.lbl_reportDate.Size = new System.Drawing.Size(107, 21);
            this.lbl_reportDate.TabIndex = 1;
            this.lbl_reportDate.Text = "Report Date\r\n";
            // 
            // lbl_bugScreenshot
            // 
            this.lbl_bugScreenshot.AutoSize = true;
            this.lbl_bugScreenshot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugScreenshot.Location = new System.Drawing.Point(13, 388);
            this.lbl_bugScreenshot.Name = "lbl_bugScreenshot";
            this.lbl_bugScreenshot.Size = new System.Drawing.Size(130, 21);
            this.lbl_bugScreenshot.TabIndex = 1;
            this.lbl_bugScreenshot.Text = "Bug Screenshot";
            // 
            // textBox_bugtitle
            // 
            this.textBox_bugtitle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBox_bugtitle.Location = new System.Drawing.Point(195, 157);
            this.textBox_bugtitle.Name = "textBox_bugtitle";
            this.textBox_bugtitle.Size = new System.Drawing.Size(309, 24);
            this.textBox_bugtitle.TabIndex = 3;
            // 
            // textBox_bugdescription
            // 
            this.textBox_bugdescription.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_bugdescription.Location = new System.Drawing.Point(195, 201);
            this.textBox_bugdescription.Multiline = true;
            this.textBox_bugdescription.Name = "textBox_bugdescription";
            this.textBox_bugdescription.Size = new System.Drawing.Size(309, 118);
            this.textBox_bugdescription.TabIndex = 4;
            // 
            // dateTimePicker_reportdate
            // 
            this.dateTimePicker_reportdate.Checked = false;
            this.dateTimePicker_reportdate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_reportdate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dateTimePicker_reportdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_reportdate.Location = new System.Drawing.Point(195, 337);
            this.dateTimePicker_reportdate.Name = "dateTimePicker_reportdate";
            this.dateTimePicker_reportdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_reportdate.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker_reportdate.TabIndex = 5;
            this.dateTimePicker_reportdate.Value = new System.DateTime(2018, 11, 9, 0, 0, 0, 0);
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Items.AddRange(new object[] {
            "employe management system",
            "salary management system"});
            this.comboBoxProject.Location = new System.Drawing.Point(195, 111);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(309, 25);
            this.comboBoxProject.TabIndex = 6;
            // 
            // pictureBox_bugimg
            // 
            this.pictureBox_bugimg.Location = new System.Drawing.Point(195, 373);
            this.pictureBox_bugimg.Name = "pictureBox_bugimg";
            this.pictureBox_bugimg.Size = new System.Drawing.Size(44, 36);
            this.pictureBox_bugimg.TabIndex = 7;
            this.pictureBox_bugimg.TabStop = false;
            // 
            // lbl_img_path
            // 
            this.lbl_img_path.AutoSize = true;
            this.lbl_img_path.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_img_path.Location = new System.Drawing.Point(248, 388);
            this.lbl_img_path.Name = "lbl_img_path";
            this.lbl_img_path.Size = new System.Drawing.Size(115, 21);
            this.lbl_img_path.TabIndex = 1;
            this.lbl_img_path.Text = "[image path]";
            // 
            // lbl_addBug
            // 
            this.lbl_addBug.AutoSize = true;
            this.lbl_addBug.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_addBug.Location = new System.Drawing.Point(135, 33);
            this.lbl_addBug.Name = "lbl_addBug";
            this.lbl_addBug.Size = new System.Drawing.Size(183, 26);
            this.lbl_addBug.TabIndex = 1;
            this.lbl_addBug.Text = "Enter a new Bug";
            // 
            // btn_browse
            // 
            this.btn_browse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(195, 415);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 8;
            this.btn_browse.Text = "Browse...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Green;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(454, 515);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_add.Location = new System.Drawing.Point(214, 515);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(77, 29);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_delete.Location = new System.Drawing.Point(373, 515);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 29);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_bug
            // 
            this.dgv_bug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bug.Location = new System.Drawing.Point(543, 69);
            this.dgv_bug.Name = "dgv_bug";
            this.dgv_bug.Size = new System.Drawing.Size(478, 422);
            this.dgv_bug.TabIndex = 10;
            this.dgv_bug.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_bug_RowHeaderMouseClick);
            // 
            // lbl_searchbug
            // 
            this.lbl_searchbug.AutoSize = true;
            this.lbl_searchbug.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_searchbug.Location = new System.Drawing.Point(539, 37);
            this.lbl_searchbug.Name = "lbl_searchbug";
            this.lbl_searchbug.Size = new System.Drawing.Size(74, 22);
            this.lbl_searchbug.TabIndex = 11;
            this.lbl_searchbug.Text = "Search";
            // 
            // txt_searchbug
            // 
            this.txt_searchbug.Location = new System.Drawing.Point(619, 39);
            this.txt_searchbug.Name = "txt_searchbug";
            this.txt_searchbug.Size = new System.Drawing.Size(402, 20);
            this.txt_searchbug.TabIndex = 12;
            this.txt_searchbug.TextChanged += new System.EventHandler(this.txt_searchbug_TextChanged);
            // 
            // btn_updatebug
            // 
            this.btn_updatebug.BackColor = System.Drawing.Color.Yellow;
            this.btn_updatebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatebug.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_updatebug.Location = new System.Drawing.Point(297, 515);
            this.btn_updatebug.Name = "btn_updatebug";
            this.btn_updatebug.Size = new System.Drawing.Size(70, 29);
            this.btn_updatebug.TabIndex = 13;
            this.btn_updatebug.Text = "Update";
            this.btn_updatebug.UseVisualStyleBackColor = false;
            this.btn_updatebug.Click += new System.EventHandler(this.btn_updatebug_Click);
            // 
            // lbl_bugID
            // 
            this.lbl_bugID.AutoSize = true;
            this.lbl_bugID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugID.Location = new System.Drawing.Point(12, 66);
            this.lbl_bugID.Name = "lbl_bugID";
            this.lbl_bugID.Size = new System.Drawing.Size(61, 21);
            this.lbl_bugID.TabIndex = 1;
            this.lbl_bugID.Text = "Bug ID";
            // 
            // txtBox_bugID
            // 
            this.txtBox_bugID.Location = new System.Drawing.Point(195, 69);
            this.txtBox_bugID.Name = "txtBox_bugID";
            this.txtBox_bugID.ReadOnly = true;
            this.txtBox_bugID.Size = new System.Drawing.Size(136, 20);
            this.txtBox_bugID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(17, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Status";
            // 
            // cmbBox_status
            // 
            this.cmbBox_status.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbBox_status.FormattingEnabled = true;
            this.cmbBox_status.Items.AddRange(new object[] {
            "Solved",
            "Unsolved"});
            this.cmbBox_status.Location = new System.Drawing.Point(195, 477);
            this.cmbBox_status.Name = "cmbBox_status";
            this.cmbBox_status.Size = new System.Drawing.Size(309, 25);
            this.cmbBox_status.TabIndex = 15;
            // 
            // BugReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 556);
            this.Controls.Add(this.cmbBox_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_updatebug);
            this.Controls.Add(this.txt_searchbug);
            this.Controls.Add(this.lbl_searchbug);
            this.Controls.Add(this.dgv_bug);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.pictureBox_bugimg);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.dateTimePicker_reportdate);
            this.Controls.Add(this.textBox_bugdescription);
            this.Controls.Add(this.textBox_bugtitle);
            this.Controls.Add(this.txtBox_bugID);
            this.Controls.Add(this.lbl_project);
            this.Controls.Add(this.lbl_img_path);
            this.Controls.Add(this.lbl_bugScreenshot);
            this.Controls.Add(this.lbl_reportDate);
            this.Controls.Add(this.lbl_bugDescription);
            this.Controls.Add(this.lbl_bugTitle);
            this.Controls.Add(this.lbl_addBug);
            this.Controls.Add(this.lbl_bugID);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "BugReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BugReport";
            this.Load += new System.EventHandler(this.BugReport_load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bugimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lbl_bugTitle;
        private System.Windows.Forms.Label lbl_bugDescription;
        private System.Windows.Forms.Label lbl_project;
        private System.Windows.Forms.Label lbl_reportDate;
        private System.Windows.Forms.Label lbl_bugScreenshot;
        private System.Windows.Forms.TextBox textBox_bugtitle;
        private System.Windows.Forms.TextBox textBox_bugdescription;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reportdate;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.PictureBox pictureBox_bugimg;
        private System.Windows.Forms.Label lbl_img_path;
        private System.Windows.Forms.Label lbl_addBug;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_bug;
        private System.Windows.Forms.Label lbl_searchbug;
        private System.Windows.Forms.TextBox txt_searchbug;
        private System.Windows.Forms.Button btn_updatebug;
        private System.Windows.Forms.Label lbl_bugID;
        private System.Windows.Forms.TextBox txtBox_bugID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox_status;
    }
}



