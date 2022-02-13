namespace CongNghePhanMem {
   partial class frmSinhVien {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if(disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.txtMaSV = new System.Windows.Forms.TextBox();
         this.txtHoTen = new System.Windows.Forms.TextBox();
         this.txtDienThoai = new System.Windows.Forms.TextBox();
         this.txtDiaChi = new System.Windows.Forms.TextBox();
         this.cboGioiTinh = new System.Windows.Forms.ComboBox();
         this.cboLop = new System.Windows.Forms.ComboBox();
         this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
         this.btnXoa = new System.Windows.Forms.Button();
         this.btnSua = new System.Windows.Forms.Button();
         this.btnThem = new System.Windows.Forms.Button();
         this.btnNhapLai = new System.Windows.Forms.Button();
         this.btnThemLop = new System.Windows.Forms.Button();
         this.dgvSinhVien = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(28, 27);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(39, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Mã SV";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(180, 28);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(39, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Họ tên";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(20, 56);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(47, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Giới tính";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(150, 56);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(54, 13);
         this.label4.TabIndex = 0;
         this.label4.Text = "Ngày sinh";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(312, 56);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(55, 13);
         this.label5.TabIndex = 0;
         this.label5.Text = "Điện thoại";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(27, 85);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(40, 13);
         this.label6.TabIndex = 0;
         this.label6.Text = "Địa chỉ";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(42, 114);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(25, 13);
         this.label7.TabIndex = 0;
         this.label7.Text = "Lớp";
         // 
         // txtMaSV
         // 
         this.txtMaSV.Location = new System.Drawing.Point(76, 24);
         this.txtMaSV.Name = "txtMaSV";
         this.txtMaSV.Size = new System.Drawing.Size(95, 20);
         this.txtMaSV.TabIndex = 0;
         // 
         // txtHoTen
         // 
         this.txtHoTen.Location = new System.Drawing.Point(228, 24);
         this.txtHoTen.Name = "txtHoTen";
         this.txtHoTen.Size = new System.Drawing.Size(239, 20);
         this.txtHoTen.TabIndex = 1;
         // 
         // txtDienThoai
         // 
         this.txtDienThoai.Location = new System.Drawing.Point(373, 52);
         this.txtDienThoai.Name = "txtDienThoai";
         this.txtDienThoai.Size = new System.Drawing.Size(95, 20);
         this.txtDienThoai.TabIndex = 4;
         // 
         // txtDiaChi
         // 
         this.txtDiaChi.Location = new System.Drawing.Point(73, 81);
         this.txtDiaChi.Name = "txtDiaChi";
         this.txtDiaChi.Size = new System.Drawing.Size(395, 20);
         this.txtDiaChi.TabIndex = 5;
         // 
         // cboGioiTinh
         // 
         this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboGioiTinh.FormattingEnabled = true;
         this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
         this.cboGioiTinh.Location = new System.Drawing.Point(73, 52);
         this.cboGioiTinh.Name = "cboGioiTinh";
         this.cboGioiTinh.Size = new System.Drawing.Size(62, 21);
         this.cboGioiTinh.TabIndex = 2;
         // 
         // cboLop
         // 
         this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboLop.FormattingEnabled = true;
         this.cboLop.Location = new System.Drawing.Point(73, 110);
         this.cboLop.Name = "cboLop";
         this.cboLop.Size = new System.Drawing.Size(294, 21);
         this.cboLop.TabIndex = 6;
         // 
         // dtpNgaySinh
         // 
         this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
         this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dtpNgaySinh.Location = new System.Drawing.Point(210, 52);
         this.dtpNgaySinh.Name = "dtpNgaySinh";
         this.dtpNgaySinh.Size = new System.Drawing.Size(83, 20);
         this.dtpNgaySinh.TabIndex = 3;
         // 
         // btnXoa
         // 
         this.btnXoa.Location = new System.Drawing.Point(388, 142);
         this.btnXoa.Name = "btnXoa";
         this.btnXoa.Size = new System.Drawing.Size(75, 23);
         this.btnXoa.TabIndex = 11;
         this.btnXoa.Text = "Xoá";
         this.btnXoa.UseVisualStyleBackColor = true;
         this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
         // 
         // btnSua
         // 
         this.btnSua.Location = new System.Drawing.Point(307, 142);
         this.btnSua.Name = "btnSua";
         this.btnSua.Size = new System.Drawing.Size(75, 23);
         this.btnSua.TabIndex = 10;
         this.btnSua.Text = "Sửa";
         this.btnSua.UseVisualStyleBackColor = true;
         this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
         // 
         // btnThem
         // 
         this.btnThem.Enabled = false;
         this.btnThem.Location = new System.Drawing.Point(226, 142);
         this.btnThem.Name = "btnThem";
         this.btnThem.Size = new System.Drawing.Size(75, 23);
         this.btnThem.TabIndex = 9;
         this.btnThem.Text = "Thêm";
         this.btnThem.UseVisualStyleBackColor = true;
         this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
         // 
         // btnNhapLai
         // 
         this.btnNhapLai.Location = new System.Drawing.Point(145, 142);
         this.btnNhapLai.Name = "btnNhapLai";
         this.btnNhapLai.Size = new System.Drawing.Size(75, 23);
         this.btnNhapLai.TabIndex = 8;
         this.btnNhapLai.Text = "Nhập Lại";
         this.btnNhapLai.UseVisualStyleBackColor = true;
         this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
         // 
         // btnThemLop
         // 
         this.btnThemLop.Location = new System.Drawing.Point(373, 109);
         this.btnThemLop.Name = "btnThemLop";
         this.btnThemLop.Size = new System.Drawing.Size(38, 23);
         this.btnThemLop.TabIndex = 7;
         this.btnThemLop.Text = "...";
         this.btnThemLop.UseVisualStyleBackColor = true;
         this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
         // 
         // dgvSinhVien
         // 
         this.dgvSinhVien.AllowUserToAddRows = false;
         this.dgvSinhVien.AllowUserToDeleteRows = false;
         this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvSinhVien.Location = new System.Drawing.Point(12, 193);
         this.dgvSinhVien.Name = "dgvSinhVien";
         this.dgvSinhVien.ReadOnly = true;
         this.dgvSinhVien.Size = new System.Drawing.Size(474, 212);
         this.dgvSinhVien.TabIndex = 12;
         this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
         // 
         // frmSinhVien
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(498, 417);
         this.Controls.Add(this.dgvSinhVien);
         this.Controls.Add(this.btnThemLop);
         this.Controls.Add(this.btnXoa);
         this.Controls.Add(this.btnSua);
         this.Controls.Add(this.btnThem);
         this.Controls.Add(this.btnNhapLai);
         this.Controls.Add(this.dtpNgaySinh);
         this.Controls.Add(this.cboLop);
         this.Controls.Add(this.cboGioiTinh);
         this.Controls.Add(this.txtHoTen);
         this.Controls.Add(this.txtDiaChi);
         this.Controls.Add(this.txtDienThoai);
         this.Controls.Add(this.txtMaSV);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "frmSinhVien";
         this.Text = "Quản Lý Sinh Viên";
         this.Load += new System.EventHandler(this.frmSinhVien_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox txtMaSV;
      private System.Windows.Forms.TextBox txtHoTen;
      private System.Windows.Forms.TextBox txtDienThoai;
      private System.Windows.Forms.TextBox txtDiaChi;
      private System.Windows.Forms.ComboBox cboGioiTinh;
      private System.Windows.Forms.ComboBox cboLop;
      private System.Windows.Forms.DateTimePicker dtpNgaySinh;
      private System.Windows.Forms.Button btnXoa;
      private System.Windows.Forms.Button btnSua;
      private System.Windows.Forms.Button btnThem;
      private System.Windows.Forms.Button btnNhapLai;
      private System.Windows.Forms.Button btnThemLop;
      private System.Windows.Forms.DataGridView dgvSinhVien;
   }
}