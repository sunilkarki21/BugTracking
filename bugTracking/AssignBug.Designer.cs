namespace bugTracking
{
    partial class AssignBug
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_assign = new System.Windows.Forms.ComboBox();
            this.btn_appoint = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_BugTitle = new System.Windows.Forms.TextBox();
            this.textBox_bugID = new System.Windows.Forms.TextBox();
            this.label_bugTitle = new System.Windows.Forms.Label();
            this.label_BugID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(325, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(247, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(528, 33);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Assign Bug ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Assign To ";
            // 
            // comboBox_assign
            // 
            this.comboBox_assign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_assign.FormattingEnabled = true;
            this.comboBox_assign.Items.AddRange(new object[] {
            "--Select--"});
            this.comboBox_assign.Location = new System.Drawing.Point(119, 129);
            this.comboBox_assign.Name = "comboBox_assign";
            this.comboBox_assign.Size = new System.Drawing.Size(189, 29);
            this.comboBox_assign.TabIndex = 21;
            // 
            // btn_appoint
            // 
            this.btn_appoint.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_appoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appoint.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_appoint.Location = new System.Drawing.Point(119, 170);
            this.btn_appoint.Name = "btn_appoint";
            this.btn_appoint.Size = new System.Drawing.Size(98, 32);
            this.btn_appoint.TabIndex = 22;
            this.btn_appoint.Text = "Assign";
            this.btn_appoint.UseVisualStyleBackColor = false;
            this.btn_appoint.Click += new System.EventHandler(this.btn_appoint_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(218, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_BugTitle
            // 
            this.textBox_BugTitle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_BugTitle.Location = new System.Drawing.Point(119, 97);
            this.textBox_BugTitle.Name = "textBox_BugTitle";
            this.textBox_BugTitle.ReadOnly = true;
            this.textBox_BugTitle.Size = new System.Drawing.Size(189, 27);
            this.textBox_BugTitle.TabIndex = 27;
            // 
            // textBox_bugID
            // 
            this.textBox_bugID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_bugID.Location = new System.Drawing.Point(119, 64);
            this.textBox_bugID.Name = "textBox_bugID";
            this.textBox_bugID.ReadOnly = true;
            this.textBox_bugID.Size = new System.Drawing.Size(189, 27);
            this.textBox_bugID.TabIndex = 26;
            // 
            // label_bugTitle
            // 
            this.label_bugTitle.AutoSize = true;
            this.label_bugTitle.BackColor = System.Drawing.Color.Transparent;
            this.label_bugTitle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_bugTitle.Location = new System.Drawing.Point(24, 103);
            this.label_bugTitle.Name = "label_bugTitle";
            this.label_bugTitle.Size = new System.Drawing.Size(75, 21);
            this.label_bugTitle.TabIndex = 25;
            this.label_bugTitle.Text = "Bug Title";
            // 
            // label_BugID
            // 
            this.label_BugID.AutoSize = true;
            this.label_BugID.BackColor = System.Drawing.Color.Transparent;
            this.label_BugID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_BugID.Location = new System.Drawing.Point(24, 70);
            this.label_BugID.Name = "label_BugID";
            this.label_BugID.Size = new System.Drawing.Size(61, 21);
            this.label_BugID.TabIndex = 24;
            this.label_BugID.Text = "Bug ID";
            // 
            // AssignBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1066, 494);
            this.Controls.Add(this.textBox_BugTitle);
            this.Controls.Add(this.textBox_bugID);
            this.Controls.Add(this.label_bugTitle);
            this.Controls.Add(this.label_BugID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_appoint);
            this.Controls.Add(this.comboBox_assign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AssignBug";
            this.Text = "AssignBug";
            this.Load += new System.EventHandler(this.AssignBug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_assign;
        private System.Windows.Forms.Button btn_appoint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_BugTitle;
        private System.Windows.Forms.TextBox textBox_bugID;
        private System.Windows.Forms.Label label_bugTitle;
        private System.Windows.Forms.Label label_BugID;
    }
}