using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_BoPhan : DBConnect
    {
        public DataTable getBoPhan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BOPHAN", _conn);
            DataTable dtBoPhan = new DataTable();
            da.Fill(dtBoPhan);
            return dtBoPhan;
        }

        public DataTable KTBoPhan(string bp)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BOPHAN WHERE MaBP = '" + bp + "'", _conn);
            DataTable dtBoPhan = new DataTable();
            da.Fill(dtBoPhan);
            return dtBoPhan;
        }

        public bool ThemBoPhan(DTO_BoPhan bp)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO BOPHAN(MaBP, TenBP, ChucNang) VALUES ('{0}', N'{1}', N'{2}')", bp.Ma_BP, bp.Ten_BP, bp.Chuc_Nang);
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
        /// Sửa thành viên

        public bool SuaBoPhan(DTO_BoPhan bp)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE BOPHAN SET TenBP = N'{0}', ChucNang = '{1}' WHERE MaBP = '{2}'", bp.Ten_BP, bp.Chuc_Nang, bp.Ma_BP);

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


        /// Xóa thành viên

        public bool XoaBoPhan(string mabp)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("DELETE FROM BOPHAN WHERE MaBP = '" + mabp + "'");
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
