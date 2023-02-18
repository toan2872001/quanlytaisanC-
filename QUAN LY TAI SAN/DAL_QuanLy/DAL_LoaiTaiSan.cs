using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;
namespace DAL_QuanLy
{
    public class DAL_LoaiTaiSan : DBConnect
    {
        public DataTable getLoaiTaiSan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAITAISAN", _conn);
            DataTable dtLoaiTaiSan = new DataTable();
            da.Fill(dtLoaiTaiSan);
            return dtLoaiTaiSan;
        }

        public DataTable getKhauHao()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT LTS.KhauHao FROM LOAITAISAN LTS, TAISAN TS WHERE LTS.MaLoai = TS.MaLoai", _conn);
            DataTable dtLoaiTaiSan = new DataTable();
            da.Fill(dtLoaiTaiSan);
            return dtLoaiTaiSan;

        }

        public DataTable KTLoaiTaiSan(string lts)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAITAISAN WHERE MaLoai = '" + lts + "'", _conn);
            DataTable dtLoaiTaiSan = new DataTable();
            da.Fill(dtLoaiTaiSan);
            return dtLoaiTaiSan;
        }

        public bool ThemLoaiTaiSan(DTO_LoaiTaiSan lts)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO LOAITAISAN(MaLoai, TenLoai, KhauHao) VALUES ('{0}', N'{1}', '{2}')", lts.Ma_Loai, lts.Ten_Loai, lts.Khau_Hao);
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
        /// Sửa Loai tai san

        public bool SuaLoaiTaiSan(DTO_LoaiTaiSan lts)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE LOAITAISAN SET TenLoai = N'{0}', KhauHao = '{1}' WHERE MaLoai = '{2}'", lts.Ten_Loai, lts.Khau_Hao, lts.Ma_Loai);

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


        /// Xóa Loai tai san

        public bool XoaLoaiTaiSan(string maloai)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM LOAITAISAN WHERE MaLoai = '" + maloai + "'");

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

