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
   public partial class frmLop :Form {
      public frmLop() {
         InitializeComponent();
      }

      CKetNoiDuLieu ketNoiLop = new CKetNoiDuLieu();
      DataTable bangLop = new DataTable();
      int donghh;

      private void HienThiLop() {
         string sql = "Select * from LOP";
         bangLop = ketNoiLop.DocDuLieu(sql);
         dgvDanhSach.DataSource = bangLop;
      }

      private void Form1_Load(object sender,EventArgs e) {
         HienThiLop();
      }

      private void ThietLapTinhTrang(bool b) {
         txtMaLop.ReadOnly = b;
         btnThem.Enabled = !b;
         btnSua.Enabled = b;
         btnXoa.Enabled = b;
      }

      private void btnNhapLai_Click(object sender,EventArgs e) {
         txtMaLop.Clear();
         txtTenLop.Clear();
         txtSiSo.Clear();
         ThietLapTinhTrang(false);
      }

      private void btnThem_Click(object sender,EventArgs e) {
         if(txtMaLop.Text == "" || txtTenLop.Text == "" || txtSiSo.Text == "") {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông Báo");
         } else {
            DataRow dongMoi = bangLop.NewRow();
            dongMoi["malop"] = txtMaLop.Text;
            dongMoi["tenlop"] = txtTenLop.Text;
            dongMoi["siso"] = txtSiSo.Text;
            bangLop.Rows.Add(dongMoi);
            ketNoiLop.CapNhatDuLieu(bangLop);
            bangLop.Clear();
            HienThiLop();
            ThietLapTinhTrang(true);
         }
      }

      private void btnXoa_Click(object sender,EventArgs e) {
         try {
            bangLop.Rows[donghh].Delete();
            ketNoiLop.CapNhatDuLieu(bangLop);
            btnNhapLai_Click(null,null);
         } catch {
            MessageBox.Show("Không thể xoá","Thông Báo");
         }
         bangLop.Clear();
         HienThiLop();
      }

      private void btnSua_Click(object sender,EventArgs e) {
         bangLop.Rows[donghh]["malop"] = txtMaLop.Text;
         bangLop.Rows[donghh]["tenlop"] = txtTenLop.Text;
         bangLop.Rows[donghh]["siso"] = txtSiSo.Text;
         ketNoiLop.CapNhatDuLieu(bangLop);
         bangLop.Clear();
         HienThiLop();
      }

      private void dgvDanhSach_CellClick(object sender,DataGridViewCellEventArgs e) {
         donghh = e.RowIndex;
         if (donghh>=0) {
            txtMaLop.Text = bangLop.Rows[donghh]["malop"].ToString();
            txtTenLop.Text = bangLop.Rows[donghh]["tenlop"].ToString();
            txtSiSo.Text = bangLop.Rows[donghh]["siso"].ToString();
            ThietLapTinhTrang(true);
         }
      }
   }
}
