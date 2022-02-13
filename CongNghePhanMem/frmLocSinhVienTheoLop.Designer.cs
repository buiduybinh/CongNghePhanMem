namespace CongNghePhanMem {
   partial class frmLocSinhVienTheoLop {
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
         this.dgvSinhVien = new System.Windows.Forms.DataGridView();
         this.btnTim = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.cboLop = new System.Windows.Forms.ComboBox();
         this.lblTongSo = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
         this.SuspendLayout();
         // 
         // dgvSinhVien
         // 
         this.dgvSinhVien.AllowUserToAddRows = false;
         this.dgvSinhVien.AllowUserToDeleteRows = false;
         this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvSinhVien.Location = new System.Drawing.Point(4, 57);
         this.dgvSinhVien.Name = "dgvSinhVien";
         this.dgvSinhVien.ReadOnly = true;
         this.dgvSinhVien.Size = new System.Drawing.Size(669, 192);
         this.dgvSinhVien.TabIndex = 5;
         // 
         // btnTim
         // 
         this.btnTim.Location = new System.Drawing.Point(337, 13);
         this.btnTim.Name = "btnTim";
         this.btnTim.Size = new System.Drawing.Size(75, 23);
         this.btnTim.TabIndex = 4;
         this.btnTim.Text = "Tìm";
         this.btnTim.UseVisualStyleBackColor = true;
         this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 16);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(44, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Lớp học";
         // 
         // cboLop
         // 
         this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboLop.FormattingEnabled = true;
         this.cboLop.Location = new System.Drawing.Point(64, 13);
         this.cboLop.Name = "cboLop";
         this.cboLop.Size = new System.Drawing.Size(267, 21);
         this.cboLop.TabIndex = 7;
         // 
         // lblTongSo
         // 
         this.lblTongSo.Location = new System.Drawing.Point(107, 37);
         this.lblTongSo.Name = "lblTongSo";
         this.lblTongSo.Size = new System.Drawing.Size(557, 17);
         this.lblTongSo.TabIndex = 8;
         this.lblTongSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // frmLocSinhVienTheoLop
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(676, 261);
         this.Controls.Add(this.lblTongSo);
         this.Controls.Add(this.cboLop);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dgvSinhVien);
         this.Controls.Add(this.btnTim);
         this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "frmLocSinhVienTheoLop";
         this.Text = "Lọc Sinh Viên Theo Lớp";
         this.Load += new System.EventHandler(this.frmLocSinhVienTheoLop_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dgvSinhVien;
      private System.Windows.Forms.Button btnTim;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cboLop;
      private System.Windows.Forms.Label lblTongSo;
   }
}