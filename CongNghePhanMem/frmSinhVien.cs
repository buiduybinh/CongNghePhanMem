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
   public partial class frmSinhVien :Form {
      public frmSinhVien() {
         InitializeComponent();
      }

      CKetNoiDuLieu ketNoiSinhVien = new CKetNoiDuLieu();
      DataTable bangSinhVien = new DataTable();
      int donghh;

      private void HienThiLop() {
         CKetNoiDuLieu ketNoiLop = new CKetNoiDuLieu();
         string sql = "Select * From LOP";
         cboLop.DisplayMember = "tenlop";
         cboLop.ValueMember = "malop";
         cboLop.DataSource = ketNoiSinhVien.DocDuLieu(sql);
      }

      private void HienThiSinhVien() {
         string sql = "Select * from SINHVIEN";
         bangSinhVien = ketNoiSinhVien.DocDuLieu(sql);
         dgvSinhVien.DataSource = bangSinhVien;
      }

      private void frmSinhVien_Load(object sender,EventArgs e) {
         HienThiLop();
         HienThiSinhVien();
         cboGioiTinh.SelectedIndex = 0;
      }

      private void ThietLapTinhTrang(bool b) {
         txtMaSV.ReadOnly = b;
         btnThem.Enabled = !b;
         btnSua.Enabled = b;
         btnXoa.Enabled = b;
      }

      private void btnThemLop_Click(object sender,EventArgs e) {
         frmLop frmL = new frmLop();
         frmL.ShowDialog();
         HienThiLop();
      }

      private void dgvSinhVien_CellClick(object sender,DataGridViewCellEventArgs e) {
         donghh = e.RowIndex;
         if(donghh >= 0) {
            txtMaSV.Text = bangSinhVien.Rows[donghh]["masv"].ToString();
            cboLop.SelectedValue = bangSinhVien.Rows[donghh]["malop"].ToString();
            txtHoTen.Text = bangSinhVien.Rows[donghh]["hoten"].ToString();
            cboGioiTinh.Text= bangSinhVien.Rows[donghh]["gioitinh"].ToString();
            txtDiaChi.Text= bangSinhVien.Rows[donghh]["diachi"].ToString();
            txtDienThoai.Text = bangSinhVien.Rows[donghh]["dienthoai"].ToString();
            dtpNgaySinh.Value=(DateTime) bangSinhVien.Rows[donghh]["ngaysinh"];
            ThietLapTinhTrang(true);
         }
      }

      private void btnNhapLai_Click(object sender,EventArgs e) {
         txtMaSV.Clear();
         txtHoTen.Clear();
         cboGioiTinh.SelectedIndex = 0;
         cboLop.SelectedIndex = 0;
         txtDienThoai.Clear();
         txtDiaChi.Clear();
         dtpNgaySinh.Value = DateTime.Now.AddYears(-18);
         ThietLapTinhTrang(false);
      }

      private void btnThem_Click(object sender,EventArgs e) {
         if(txtMaSV.Text == "" || txtHoTen.Text == "" || cboGioiTinh.SelectedIndex == -1||cboLop.SelectedIndex==-1) {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông Báo");
         } else {
            DataRow dongMoi = bangSinhVien.NewRow();
            dongMoi["masv"] = txtMaSV.Text;
            dongMoi["hoten"] = txtHoTen.Text;
            dongMoi["ngaysinh"] = dtpNgaySinh.Value.ToString();
            dongMoi["gioitinh"] = cboGioiTinh.Text;
            dongMoi["diachi"] = txtDiaChi.Text;
            dongMoi["dienthoai"] = txtDienThoai.Text;
            dongMoi["malop"] = cboLop.SelectedValue.ToString();
            bangSinhVien.Rows.Add(dongMoi);
            ketNoiSinhVien.CapNhatDuLieu(bangSinhVien);
            bangSinhVien.Clear();
            HienThiSinhVien();
            ThietLapTinhTrang(true);
         }
      }

      private void btnXoa_Click(object sender,EventArgs e) {
         try {
            bangSinhVien.Rows[donghh].Delete();
            ketNoiSinhVien.CapNhatDuLieu(bangSinhVien);
            btnNhapLai_Click(null,null);
         } catch {
            MessageBox.Show("Không thể xoá","Thông Báo");
         }
         bangSinhVien.Clear();
         HienThiSinhVien();
      }

      private void btnSua_Click(object sender,EventArgs e) {
         bangSinhVien.Rows[donghh]["masv"] = txtMaSV.Text;
         bangSinhVien.Rows[donghh]["hoten"] = txtHoTen.Text;
         bangSinhVien.Rows[donghh]["ngaysinh"] = dtpNgaySinh.Value.ToString();
         bangSinhVien.Rows[donghh]["gioitinh"] = cboGioiTinh.Text;
         bangSinhVien.Rows[donghh]["diachi"] = txtDiaChi.Text;
         bangSinhVien.Rows[donghh]["dienthoai"] = txtDienThoai.Text;
         bangSinhVien.Rows[donghh]["malop"] = cboLop.SelectedValue.ToString();
         ketNoiSinhVien.CapNhatDuLieu(bangSinhVien);
         bangSinhVien.Clear();
         HienThiSinhVien();
         ThietLapTinhTrang(true);
      }
   }
}
