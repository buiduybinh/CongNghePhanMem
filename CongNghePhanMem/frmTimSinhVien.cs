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
   public partial class frmTimSinhVien :Form {
      public frmTimSinhVien() {
         InitializeComponent();
      }

      CKetNoiDuLieu ketNoiSinhVien = new CKetNoiDuLieu();

      private void btnTim_Click(object sender,EventArgs e) {
         TimSinhVien();
      }

      private void TimSinhVien() {
         string sql="Select * From SINHVIEN Where masv='" + txtMaSV.Text.Trim()+ "'";
         if (rbCoChua.Checked) {
            sql = "Select * From SINHVIEN Where masv like'%" + txtMaSV.Text.Trim() + "%'";
         } else if(rbBatDau.Checked) {
            sql = "Select * From SINHVIEN Where masv like'" + txtMaSV.Text.Trim() + "%'";
         } else if(rbKetThuc.Checked) {
            sql = "Select * From SINHVIEN Where masv like'%" + txtMaSV.Text.Trim() + "'";
         }
         dgvSinhVien.DataSource = ketNoiSinhVien.DocDuLieu(sql);
      }
   }
}
