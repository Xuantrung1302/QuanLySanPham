namespace QuanLySanPham
{
    partial class SanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbDanhsachSP = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeleteSP = new System.Windows.Forms.Button();
            this.btnUpdateSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThoatDSSP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbTrangThai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbKieuSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIdChiTiet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTenSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdSanPham = new System.Windows.Forms.TextBox();
            this.dtgvDanhsachSanPham = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            this.grbDanhsachSP.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhsachSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDanhsachSP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 483);
            this.panel1.TabIndex = 0;
            // 
            // grbDanhsachSP
            // 
            this.grbDanhsachSP.Controls.Add(this.panel3);
            this.grbDanhsachSP.Controls.Add(this.panel2);
            this.grbDanhsachSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhsachSP.Location = new System.Drawing.Point(0, 0);
            this.grbDanhsachSP.Name = "grbDanhsachSP";
            this.grbDanhsachSP.Size = new System.Drawing.Size(1030, 483);
            this.grbDanhsachSP.TabIndex = 0;
            this.grbDanhsachSP.TabStop = false;
            this.grbDanhsachSP.Text = "Danh sách sản phẩm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnDeleteSP);
            this.panel3.Controls.Add(this.btnUpdateSP);
            this.panel3.Controls.Add(this.btnThemSP);
            this.panel3.Controls.Add(this.btnDangXuat);
            this.panel3.Controls.Add(this.btnThoatDSSP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 46);
            this.panel3.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkGray;
            this.btnReset.Location = new System.Drawing.Point(300, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 38);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDeleteSP
            // 
            this.btnDeleteSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSP.Location = new System.Drawing.Point(210, 5);
            this.btnDeleteSP.Name = "btnDeleteSP";
            this.btnDeleteSP.Size = new System.Drawing.Size(84, 38);
            this.btnDeleteSP.TabIndex = 9;
            this.btnDeleteSP.Text = "Xóa";
            this.btnDeleteSP.UseVisualStyleBackColor = false;
            this.btnDeleteSP.Click += new System.EventHandler(this.btnDeleteSP_Click);
            // 
            // btnUpdateSP
            // 
            this.btnUpdateSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdateSP.Location = new System.Drawing.Point(111, 5);
            this.btnUpdateSP.Name = "btnUpdateSP";
            this.btnUpdateSP.Size = new System.Drawing.Size(84, 38);
            this.btnUpdateSP.TabIndex = 8;
            this.btnUpdateSP.Text = "Sửa";
            this.btnUpdateSP.UseVisualStyleBackColor = false;
            this.btnUpdateSP.Click += new System.EventHandler(this.btnUpdateSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnThemSP.Location = new System.Drawing.Point(11, 5);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(84, 38);
            this.btnThemSP.TabIndex = 7;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.Location = new System.Drawing.Point(817, 5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(84, 38);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThoatDSSP
            // 
            this.btnThoatDSSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnThoatDSSP.Location = new System.Drawing.Point(907, 5);
            this.btnThoatDSSP.Name = "btnThoatDSSP";
            this.btnThoatDSSP.Size = new System.Drawing.Size(84, 38);
            this.btnThoatDSSP.TabIndex = 5;
            this.btnThoatDSSP.Text = "Thoát";
            this.btnThoatDSSP.UseVisualStyleBackColor = false;
            this.btnThoatDSSP.Click += new System.EventHandler(this.btnThoatDSSP_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbTrangThai);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txbSoLuong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txbKieuSanPham);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txbIdChiTiet);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbTenSanPham);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbIdSanPham);
            this.panel2.Controls.Add(this.dtgvDanhsachSanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 462);
            this.panel2.TabIndex = 0;
            // 
            // txbTrangThai
            // 
            this.txbTrangThai.Location = new System.Drawing.Point(133, 286);
            this.txbTrangThai.Name = "txbTrangThai";
            this.txbTrangThai.Size = new System.Drawing.Size(161, 22);
            this.txbTrangThai.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trạng thái:";
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Location = new System.Drawing.Point(133, 240);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(161, 22);
            this.txbSoLuong.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng:";
            // 
            // txbKieuSanPham
            // 
            this.txbKieuSanPham.Location = new System.Drawing.Point(133, 190);
            this.txbKieuSanPham.Name = "txbKieuSanPham";
            this.txbKieuSanPham.Size = new System.Drawing.Size(161, 22);
            this.txbKieuSanPham.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kiểu sản phẩm:";
            // 
            // txbIdChiTiet
            // 
            this.txbIdChiTiet.Location = new System.Drawing.Point(133, 140);
            this.txbIdChiTiet.Name = "txbIdChiTiet";
            this.txbIdChiTiet.Size = new System.Drawing.Size(161, 22);
            this.txbIdChiTiet.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID detail:";
            // 
            // txbTenSanPham
            // 
            this.txbTenSanPham.Location = new System.Drawing.Point(133, 84);
            this.txbTenSanPham.Name = "txbTenSanPham";
            this.txbTenSanPham.Size = new System.Drawing.Size(161, 22);
            this.txbTenSanPham.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID sản phẩm:";
            // 
            // txbIdSanPham
            // 
            this.txbIdSanPham.Location = new System.Drawing.Point(133, 30);
            this.txbIdSanPham.Name = "txbIdSanPham";
            this.txbIdSanPham.Size = new System.Drawing.Size(161, 22);
            this.txbIdSanPham.TabIndex = 1;
            // 
            // dtgvDanhsachSanPham
            // 
            this.dtgvDanhsachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhsachSanPham.Location = new System.Drawing.Point(300, 3);
            this.dtgvDanhsachSanPham.Name = "dtgvDanhsachSanPham";
            this.dtgvDanhsachSanPham.ReadOnly = true;
            this.dtgvDanhsachSanPham.RowHeadersWidth = 51;
            this.dtgvDanhsachSanPham.RowTemplate.Height = 24;
            this.dtgvDanhsachSanPham.Size = new System.Drawing.Size(691, 320);
            this.dtgvDanhsachSanPham.TabIndex = 0;
            this.dtgvDanhsachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhsachSanPham_CellClick);
            this.dtgvDanhsachSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhsachSanPham_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(413, 15);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(161, 22);
            this.txbTimKiem.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tìm kiếm:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.Location = new System.Drawing.Point(580, 7);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(84, 38);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTimKiem);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txbTimKiem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1030, 56);
            this.panel4.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 543);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.TabIndex = 2;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 543);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SanPham_FormClosed);
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.panel1.ResumeLayout(false);
            this.grbDanhsachSP.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhsachSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbDanhsachSP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvDanhsachSanPham;
        private System.Windows.Forms.Button btnThoatDSSP;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.TextBox txbIdSanPham;
        private System.Windows.Forms.TextBox txbIdChiTiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txbTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbKieuSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteSP;
        private System.Windows.Forms.Button btnUpdateSP;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}