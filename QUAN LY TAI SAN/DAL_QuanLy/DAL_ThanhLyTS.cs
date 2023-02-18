using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_ThanhLyTS : DBConnect
    {

        public DataTable getThanhLyTS()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM THANHLYTS", _conn);
            DataTable dtThanhLyTS = new DataTable();
            da.Fill(dtThanhLyTS);
            return dtThanhLyTS;
        }
        public DataTable KTThanhLyTS(string mats)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM THANHLYTS WHERE MaTS = '" + mats + "'", _conn);
            DataTable dtThanhLyTS = new DataTable();
            da.Fill(dtThanhLyTS);
            return dtThanhLyTS;
        }


        public bool themThanhLyTS(DTO_ThanhLyTS ts)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string SQL = string.Format("INSERT INTO THANHLYTS(MaTS, TenTS, DVT, SoLuong, MaLoai, MaXuatXu, MaNguon, MaBP, MucKH, TinhTrang) values('" + ts.Ma_TS + "', N'" + ts.Ten_TS + "', '" + ts.D_VT + "', '" + ts.So_Luong + "', '" + ts.Ma_Loai + "', '" + ts.Ma_Xuat_Xu + "', '" + ts.Ma_Nguon + "', '" + ts.Ma_BP + "', '" + ts.Muc_KH + "', N'" + ts.Tinh_Trang + "')");

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

        public bool suaThanhLyTS(DTO_ThanhLyTS ts)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE THANHLYTS SET TenTS = N'{0}', SoLuong = '{1}', DVT = '{2}', MaLoai = '{3}', MaXuatXu = '{4}', MaNguon = '{5}', MaBP = '{6}', MucKH = '{7}', TinhTrang = N'{8}' WHERE MaTS = '{9}'", ts.Ten_TS, ts.So_Luong, ts.D_VT, ts.Ma_Loai, ts.Ma_Xuat_Xu, ts.Ma_Nguon, ts.Ma_BP, ts.Muc_KH, ts.Tinh_Trang, ts.Ma_TS);


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

        public bool xoaThanhLyTS(string mats)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("DELETE FROM THANHLYTS WHERE MaTS = '" + mats + "'");

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

        public bool CapNhatTinhTrang(string mats)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE THANHLYTS SET TinhTrang = N'Chờ thanh lý' WHERE MaTS = '" + mats + "'");

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
