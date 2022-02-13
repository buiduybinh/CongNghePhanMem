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
         string chuoikn = "Data Source="+serverName +"; Initial Catalog = "+ databaseName + "; Integrated Security=true";
         ketNoi.ConnectionString = chuoikn;
      }

      public CKetNoiDuLieu():this(".","QLSV") {
      }

      public DataTable DocDuLieu(string sql) {
         boDocGhi = new SqlDataAdapter(sql,ketNoi);
         DataTable tam = new DataTable();
         boDocGhi.Fill(tam);
         return tam;
      }

     public void CapNhatDuLieu(DataTable bang) {
         SqlCommandBuilder capNhat = new SqlCommandBuilder(boDocGhi);
         boDocGhi.Update(bang);
         //bang.AcceptChanges();
      }
   }
}
