namespace bugTracking.user
{
    partial class ViewUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_userdelete = new System.Windows.Forms.Button();
            this.butn_cancel = new System.Windows.Forms.Button();
            this.text_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Users";
            // 
            // btn_userdelete
            // 
            this.btn_userdelete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_userdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userdelete.Location = new System.Drawing.Point(354, 401);
            this.btn_userdelete.Name = "btn_userdelete";
            this.btn_userdelete.Size = new System.Drawing.Size(75, 23);
            this.btn_userdelete.TabIndex = 2;
            this.btn_userdelete.Text = "Delete";
            this.btn_userdelete.UseVisualStyleBackColor = false;
            this.btn_userdelete.Click += new System.EventHandler(this.btn_userdelete_Click);
            // 
            // butn_cancel
            // 
            this.butn_cancel.BackColor = System.Drawing.Color.Green;
            this.butn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butn_cancel.Location = new System.Drawing.Point(448, 401);
            this.butn_cancel.Name = "butn_cancel";
            this.butn_cancel.Size = new System.Drawing.Size(75, 23);
            this.butn_cancel.TabIndex = 3;
            this.butn_cancel.Text = "Cancel";
            this.butn_cancel.UseVisualStyleBackColor = false;
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(92, 57);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(431, 31);
            this.text_search.TabIndex = 5;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(448, 28);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 439);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.butn_cancel);
            this.Controls.Add(this.btn_userdelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewUsers";
            this.Load += new System.EventHandler(this.ViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_userdelete;
        private System.Windows.Forms.Button butn_cancel;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_refresh;
    }
}