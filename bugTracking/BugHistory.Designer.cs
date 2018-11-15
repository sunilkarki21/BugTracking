namespace bugTracking
{
    partial class BugHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_history = new System.Windows.Forms.DataGridView();
            this.button_close = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_bugname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug History";
            // 
            // dgv_history
            // 
            this.dgv_history.AllowUserToAddRows = false;
            this.dgv_history.AllowUserToDeleteRows = false;
            this.dgv_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.ReportID,
            this.user,
            this.changes});
            this.dgv_history.Location = new System.Drawing.Point(12, 105);
            this.dgv_history.Name = "dgv_history";
            this.dgv_history.ReadOnly = true;
            this.dgv_history.Size = new System.Drawing.Size(776, 333);
            this.dgv_history.TabIndex = 1;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_close.Location = new System.Drawing.Point(713, 444);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 31);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // ReportID
            // 
            this.ReportID.HeaderText = "ReportID";
            this.ReportID.Name = "ReportID";
            this.ReportID.ReadOnly = true;
            // 
            // user
            // 
            this.user.HeaderText = "user";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // changes
            // 
            this.changes.HeaderText = "changes";
            this.changes.Name = "changes";
            this.changes.ReadOnly = true;
            // 
            // cmb_bugname
            // 
            this.cmb_bugname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bugname.FormattingEnabled = true;
            this.cmb_bugname.Location = new System.Drawing.Point(117, 53);
            this.cmb_bugname.Name = "cmb_bugname";
            this.cmb_bugname.Size = new System.Drawing.Size(210, 25);
            this.cmb_bugname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bug Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(682, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "SHOW ALL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BugHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_bugname);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.dgv_history);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BugHistory";
            this.Text = "BugHistory";
            this.Load += new System.EventHandler(this.BugHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_history;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn changes;
        private System.Windows.Forms.ComboBox cmb_bugname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}