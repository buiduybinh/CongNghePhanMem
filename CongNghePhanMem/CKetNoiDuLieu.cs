using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CongNghePhanMem {
   class CKetNoiDuLieu {
      private SqlConnection ketNoi;
      private SqlDataAdapter boDocGhi;

      public CKetNoiDuLieu(string serverName, string databaseName) {
         ketNoi = new SqlConnection();
         string chuoiKetNoi = "Data Source="+serverName +"; Initial Catalog = "+ databaseName + "; Integrated Security=true";
         ketNoi.ConnectionString = chuoiKetNoi;
      }

      public CKetNoiDuLieu():this(".","QLSV") {
      }

      /// <summary>
      /// Đọc dữ liệu từ SQL 
      /// </summary>
      /// <param name="sql">Câu lệnh SQL</param>
      /// <returns>DataTable</returns>
      public DataTable DocDuLieu(string sql) {
         boDocGhi = new SqlDataAdapter(sql,ketNoi);
         DataTable bangTam = new DataTable();
         boDocGhi.Fill(bangTam);
         return bangTam;
      }

      /// <summary>
      /// Thêm, Cập nhật, Xoá dữ liệu
      /// </summary>
      /// <param name="bangDuLieu">DataTable chứa dữ liệu</param>
      public void CapNhatDuLieu(DataTable bangDuLieu) {
         SqlCommandBuilder capNhat = new SqlCommandBuilder(boDocGhi);
         boDocGhi.Update(bangDuLieu);
         bangDuLieu.AcceptChanges();
      }
   }
}
