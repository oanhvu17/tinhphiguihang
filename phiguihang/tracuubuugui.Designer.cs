namespace phiguihang
{
    partial class tracuubuugui
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbmabg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoattracuu = new System.Windows.Forms.Button();
            this.dsbuugui = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU THÔNG TIN BƯU GỬI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbmabg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(72, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbmabg
            // 
            this.cmbmabg.FormattingEnabled = true;
            this.cmbmabg.Location = new System.Drawing.Point(329, 22);
            this.cmbmabg.Name = "cmbmabg";
            this.cmbmabg.Size = new System.Drawing.Size(121, 21);
            this.cmbmabg.TabIndex = 0;
            this.cmbmabg.SelectedIndexChanged += new System.EventHandler(this.cmbmabg_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Bưu gửi";
            // 
            // btnthoattracuu
            // 
            this.btnthoattracuu.Location = new System.Drawing.Point(879, 424);
            this.btnthoattracuu.Name = "btnthoattracuu";
            this.btnthoattracuu.Size = new System.Drawing.Size(75, 23);
            this.btnthoattracuu.TabIndex = 3;
            this.btnthoattracuu.Text = "Thoát";
            this.btnthoattracuu.UseVisualStyleBackColor = true;
            this.btnthoattracuu.Click += new System.EventHandler(this.btnthoattracuu_Click);
            // 
            // dsbuugui
            // 
            this.dsbuugui.AllowColumnReorder = true;
            this.dsbuugui.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.cl,
            this.columnHeader10,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader12});
            this.dsbuugui.FullRowSelect = true;
            this.dsbuugui.GridLines = true;
            this.dsbuugui.Location = new System.Drawing.Point(24, 183);
            this.dsbuugui.Name = "dsbuugui";
            this.dsbuugui.Size = new System.Drawing.Size(930, 101);
            this.dsbuugui.TabIndex = 4;
            this.dsbuugui.UseCompatibleStateImageBehavior = false;
            this.dsbuugui.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 35;
            // 
            // cl
            // 
            this.cl.Text = "Mã bưu gửi";
            this.cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã người dùng";
            this.columnHeader10.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên người gửi";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa chỉ người gửi";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Người nhận";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 74;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Địa chỉ người nhận";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 105;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ngày nhận gửi";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 88;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Khối lượng";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 68;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tổng cước";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 65;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Số tiền thu hộ";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 141;
            // 
            // tracuubuugui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 472);
            this.Controls.Add(this.dsbuugui);
            this.Controls.Add(this.btnthoattracuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "tracuubuugui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tracuubuugui";
            this.Load += new System.EventHandler(this.tracuubuugui_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbmabg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoattracuu;
        private System.Windows.Forms.ListView dsbuugui;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader cl;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}