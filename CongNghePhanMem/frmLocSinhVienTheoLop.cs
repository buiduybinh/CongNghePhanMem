using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongNghePhanMem {
   public partial class frmLocSinhVienTheoLop :Form {
      public frmLocSinhVienTheoLop() {
         InitializeComponent();
      }

      CKetNoiDuLieu ketNoiSinhVien = new CKetNoiDuLieu();

      private void HienThiLop() {
         CKetNoiDuLieu ketNoiLop = new CKetNoiDuLieu();
         string sql = "Select * From LOP";
         cboLop.DisplayMember = "tenlop";
         cboLop.ValueMember = "malop";
         cboLop.DataSource = ketNoiLop.DocDuLieu(sql);
      }

      private void frmLocSinhVienTheoLop_Load(object sender,EventArgs e) {
         HienThiLop();
      }

      private void btnTim_Click(object sender,EventArgs e) {
         Tim();
      }

      private void Tim() {
         string sql = "Select * From SINHVIEN Where malop='" + cboLop.SelectedValue.ToString() + "'";
         dgvSinhVien.DataSource = ketNoiSinhVien.DocDuLieu(sql);
         lblTongSo.Text = "Lớp: " + cboLop.Text + " có " +  dgvSinhVien.RowCount + " sinh viên";
      }
   }
}
