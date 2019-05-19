namespace phiguihang
{
    partial class Form_main
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
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhíGửiHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchBưuGửiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.quảnLýPhíGửiHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đổiToolStripMenuItem});
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đổiToolStripMenuItem
            // 
            this.đổiToolStripMenuItem.Name = "đổiToolStripMenuItem";
            this.đổiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đổiToolStripMenuItem.Text = "Đăng xuất";
            this.đổiToolStripMenuItem.Click += new System.EventHandler(this.đổiToolStripMenuItem_Click);
            // 
            // quảnLýPhíGửiHàngToolStripMenuItem
            // 
            this.quảnLýPhíGửiHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchBưuGửiToolStripMenuItem,
            this.traCứuThôngTinToolStripMenuItem,
            this.thêmToolStripMenuItem});
            this.quảnLýPhíGửiHàngToolStripMenuItem.Name = "quảnLýPhíGửiHàngToolStripMenuItem";
            this.quảnLýPhíGửiHàngToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.quảnLýPhíGửiHàngToolStripMenuItem.Text = "Quản lý phí gửi hàng";
            // 
            // danhSáchBưuGửiToolStripMenuItem
            // 
            this.danhSáchBưuGửiToolStripMenuItem.Name = "danhSáchBưuGửiToolStripMenuItem";
            this.danhSáchBưuGửiToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.danhSáchBưuGửiToolStripMenuItem.Text = "Danh sách bưu gửi";
            this.danhSáchBưuGửiToolStripMenuItem.Click += new System.EventHandler(this.danhSáchBưuGửiToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.thêmToolStripMenuItem.Text = "Thêm bưu gửi";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // traCứuThôngTinToolStripMenuItem
            // 
            this.traCứuThôngTinToolStripMenuItem.Name = "traCứuThôngTinToolStripMenuItem";
            this.traCứuThôngTinToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.traCứuThôngTinToolStripMenuItem.Text = "Tra cứu thông tin";
            this.traCứuThôngTinToolStripMenuItem.Click += new System.EventHandler(this.traCứuThôngTinToolStripMenuItem_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 350);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_main";
            this.Text = "Form_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhíGửiHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchBưuGửiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuThôngTinToolStripMenuItem;
    }
}