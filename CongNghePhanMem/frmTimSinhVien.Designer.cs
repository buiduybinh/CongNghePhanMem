namespace CongNghePhanMem {
   partial class frmTimSinhVien {
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
         this.txtMaSV = new System.Windows.Forms.TextBox();
         this.btnTim = new System.Windows.Forms.Button();
         this.dgvSinhVien = new System.Windows.Forms.DataGridView();
         this.rbChinhXac = new System.Windows.Forms.RadioButton();
         this.rbCoChua = new System.Windows.Forms.RadioButton();
         this.rbBatDau = new System.Windows.Forms.RadioButton();
         this.rbKetThuc = new System.Windows.Forms.RadioButton();
         ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(29, 25);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(66, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Mã sinh viên";
         // 
         // txtMaSV
         // 
         this.txtMaSV.Location = new System.Drawing.Point(102, 21);
         this.txtMaSV.Name = "txtMaSV";
         this.txtMaSV.Size = new System.Drawing.Size(193, 21);
         this.txtMaSV.TabIndex = 1;
         // 
         // btnTim
         // 
         this.btnTim.Location = new System.Drawing.Point(602, 20);
         this.btnTim.Name = "btnTim";
         this.btnTim.Size = new System.Drawing.Size(75, 23);
         this.btnTim.TabIndex = 2;
         this.btnTim.Text = "Tìm";
         this.btnTim.UseVisualStyleBackColor = true;
         this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
         // 
         // dgvSinhVien
         // 
         this.dgvSinhVien.AllowUserToAddRows = false;
         this.dgvSinhVien.AllowUserToDeleteRows = false;
         this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvSinhVien.Location = new System.Drawing.Point(12, 61);
         this.dgvSinhVien.Name = "dgvSinhVien";
         this.dgvSinhVien.ReadOnly = true;
         this.dgvSinhVien.Size = new System.Drawing.Size(669, 188);
         this.dgvSinhVien.TabIndex = 3;
         // 
         // rbChinhXac
         // 
         this.rbChinhXac.AutoSize = true;
         this.rbChinhXac.Checked = true;
         this.rbChinhXac.Location = new System.Drawing.Point(301, 23);
         this.rbChinhXac.Name = "rbChinhXac";
         this.rbChinhXac.Size = new System.Drawing.Size(72, 17);
         this.rbChinhXac.TabIndex = 4;
         this.rbChinhXac.TabStop = true;
         this.rbChinhXac.Text = "Chính xác";
         this.rbChinhXac.UseVisualStyleBackColor = true;
         // 
         // rbCoChua
         // 
         this.rbCoChua.AutoSize = true;
         this.rbCoChua.Location = new System.Drawing.Point(379, 23);
         this.rbCoChua.Name = "rbCoChua";
         this.rbCoChua.Size = new System.Drawing.Size(65, 17);
         this.rbCoChua.TabIndex = 4;
         this.rbCoChua.Text = "Có chứa";
         this.rbCoChua.UseVisualStyleBackColor = true;
         // 
         // rbBatDau
         // 
         this.rbBatDau.AutoSize = true;
         this.rbBatDau.Location = new System.Drawing.Point(450, 23);
         this.rbBatDau.Name = "rbBatDau";
         this.rbBatDau.Size = new System.Drawing.Size(62, 17);
         this.rbBatDau.TabIndex = 4;
         this.rbBatDau.Text = "Bắt đầu";
         this.rbBatDau.UseVisualStyleBackColor = true;
         // 
         // rbKetThuc
         // 
         this.rbKetThuc.AutoSize = true;
         this.rbKetThuc.Location = new System.Drawing.Point(519, 23);
         this.rbKetThuc.Name = "rbKetThuc";
         this.rbKetThuc.Size = new System.Drawing.Size(65, 17);
         this.rbKetThuc.TabIndex = 4;
         this.rbKetThuc.Text = "Kết thúc";
         this.rbKetThuc.UseVisualStyleBackColor = true;
         // 
         // frmTimSinhVien
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(693, 261);
         this.Controls.Add(this.rbKetThuc);
         this.Controls.Add(this.rbBatDau);
         this.Controls.Add(this.rbCoChua);
         this.Controls.Add(this.rbChinhXac);
         this.Controls.Add(this.dgvSinhVien);
         this.Controls.Add(this.btnTim);
         this.Controls.Add(this.txtMaSV);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "frmTimSinhVien";
         this.Text = "Tìm Sinh Viên";
         ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtMaSV;
      private System.Windows.Forms.Button btnTim;
      private System.Windows.Forms.DataGridView dgvSinhVien;
      private System.Windows.Forms.RadioButton rbChinhXac;
      private System.Windows.Forms.RadioButton rbCoChua;
      private System.Windows.Forms.RadioButton rbBatDau;
      private System.Windows.Forms.RadioButton rbKetThuc;
   }
}