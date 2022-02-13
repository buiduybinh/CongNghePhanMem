namespace CongNghePhanMem {
   partial class frmLop {
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
         this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
         this.label3 = new System.Windows.Forms.Label();
         this.txtMaLop = new System.Windows.Forms.TextBox();
         this.txtTenLop = new System.Windows.Forms.TextBox();
         this.txtSiSo = new System.Windows.Forms.TextBox();
         this.dgvDanhSach = new System.Windows.Forms.DataGridView();
         this.btnNhapLai = new System.Windows.Forms.Button();
         this.btnThem = new System.Windows.Forms.Button();
         this.btnSua = new System.Windows.Forms.Button();
         this.btnXoa = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 32);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(43, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Mã Lớp";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 60);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(47, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Tên Lớp";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 86);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(32, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Sỉ Số";
         // 
         // txtMaLop
         // 
         this.txtMaLop.Location = new System.Drawing.Point(62, 25);
         this.txtMaLop.Name = "txtMaLop";
         this.txtMaLop.ReadOnly = true;
         this.txtMaLop.Size = new System.Drawing.Size(271, 20);
         this.txtMaLop.TabIndex = 0;
         // 
         // txtTenLop
         // 
         this.txtTenLop.Location = new System.Drawing.Point(62, 53);
         this.txtTenLop.Name = "txtTenLop";
         this.txtTenLop.Size = new System.Drawing.Size(271, 20);
         this.txtTenLop.TabIndex = 1;
         // 
         // txtSiSo
         // 
         this.txtSiSo.Location = new System.Drawing.Point(62, 79);
         this.txtSiSo.Name = "txtSiSo";
         this.txtSiSo.Size = new System.Drawing.Size(271, 20);
         this.txtSiSo.TabIndex = 2;
         // 
         // dgvDanhSach
         // 
         this.dgvDanhSach.AllowUserToAddRows = false;
         this.dgvDanhSach.AllowUserToDeleteRows = false;
         this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvDanhSach.Location = new System.Drawing.Point(15, 154);
         this.dgvDanhSach.MultiSelect = false;
         this.dgvDanhSach.Name = "dgvDanhSach";
         this.dgvDanhSach.ReadOnly = true;
         this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvDanhSach.Size = new System.Drawing.Size(318, 150);
         this.dgvDanhSach.TabIndex = 7;
         this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
         // 
         // btnNhapLai
         // 
         this.btnNhapLai.Location = new System.Drawing.Point(15, 114);
         this.btnNhapLai.Name = "btnNhapLai";
         this.btnNhapLai.Size = new System.Drawing.Size(75, 23);
         this.btnNhapLai.TabIndex = 3;
         this.btnNhapLai.Text = "Nhập Lại";
         this.btnNhapLai.UseVisualStyleBackColor = true;
         this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
         // 
         // btnThem
         // 
         this.btnThem.Enabled = false;
         this.btnThem.Location = new System.Drawing.Point(96, 114);
         this.btnThem.Name = "btnThem";
         this.btnThem.Size = new System.Drawing.Size(75, 23);
         this.btnThem.TabIndex = 4;
         this.btnThem.Text = "Thêm";
         this.btnThem.UseVisualStyleBackColor = true;
         this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
         // 
         // btnSua
         // 
         this.btnSua.Location = new System.Drawing.Point(177, 114);
         this.btnSua.Name = "btnSua";
         this.btnSua.Size = new System.Drawing.Size(75, 23);
         this.btnSua.TabIndex = 5;
         this.btnSua.Text = "Sửa";
         this.btnSua.UseVisualStyleBackColor = true;
         this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
         // 
         // btnXoa
         // 
         this.btnXoa.Location = new System.Drawing.Point(258, 114);
         this.btnXoa.Name = "btnXoa";
         this.btnXoa.Size = new System.Drawing.Size(75, 23);
         this.btnXoa.TabIndex = 6;
         this.btnXoa.Text = "Xoá";
         this.btnXoa.UseVisualStyleBackColor = true;
         this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
         // 
         // frmLop
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(352, 321);
         this.Controls.Add(this.btnXoa);
         this.Controls.Add(this.btnSua);
         this.Controls.Add(this.btnThem);
         this.Controls.Add(this.btnNhapLai);
         this.Controls.Add(this.dgvDanhSach);
         this.Controls.Add(this.txtSiSo);
         this.Controls.Add(this.txtTenLop);
         this.Controls.Add(this.txtMaLop);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "frmLop";
         this.Text = "Quản Lý Lớp";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.ComponentModel.BackgroundWorker backgroundWorker1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtMaLop;
      private System.Windows.Forms.TextBox txtTenLop;
      private System.Windows.Forms.TextBox txtSiSo;
      private System.Windows.Forms.DataGridView dgvDanhSach;
      private System.Windows.Forms.Button btnNhapLai;
      private System.Windows.Forms.Button btnThem;
      private System.Windows.Forms.Button btnSua;
      private System.Windows.Forms.Button btnXoa;
   }
}

