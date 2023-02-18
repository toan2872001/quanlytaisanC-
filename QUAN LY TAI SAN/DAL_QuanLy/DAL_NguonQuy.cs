using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_NguonQuy : DBConnect
    {
        /// <summary>
        /// Get toàn bộ nguon quy
        /// </summary>
        /// <returns></returns>
        public DataTable getNguonQuy()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NGUONQUY", _conn);
            DataTable dtNguonQuy = new DataTable();
            da.Fill(dtNguonQuy);
            return dtNguonQuy;
        }

        /// <summary>
       

        public DataTable KTNguonQuy(string mn)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NGUONQUY WHERE MaNguon = '" + mn + "'", _conn);
            DataTable dtNguonQuy = new DataTable();
            da.Fill(dtNguonQuy);
            return dtNguonQuy;
        }
        
        /// Thêm nguon quy
        public bool ThemNguonQuy(DTO_NguonQuy nq)
        {
            try
            {
                // Ket noi
                _conn.Open();
                
                string SQL = string.Format("INSERT INTO NGUONQUY(MaNguon, TenNguon) VALUES ('{0}', N'{1}')", nq.Ma_Nguon, nq.Ten_Nguon);
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Sửa Nguon quy
        public bool SuaNguonQuy(DTO_NguonQuy nq)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE NGUONQUY SET TenNguon = N'{0}' WHERE MaLoai = '{1}'", nq.Ten_Nguon, nq.Ma_Nguon);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }


        /// Xóa nguon quy

        public bool XoaNguonQuy(string manguon)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM NGUONQUY WHERE MaNguon = '"+ manguon +"'");

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }
}
