using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_DangNhap : DBConnect
    {
        public DataTable getNguoiDung()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NGUOIDUNG", _conn);
            DataTable dtNguoiDung = new DataTable();
            da.Fill(dtNguoiDung);
            return dtNguoiDung;
        }

        public DataTable KTMatKhau(string mk)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NGUOIDUNG WHERE MatKhau = '" + mk + "'", _conn);
            DataTable dtNguoiDung = new DataTable();
            da.Fill(dtNguoiDung);
            return dtNguoiDung;
        }

        public  DataTable getPhanQuyen(string taikhoan)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NGUOIDUNG WHERE TaiKhoan = '" + taikhoan + "'", _conn);
            DataTable dtNguoiDung = new DataTable();
            da.Fill(dtNguoiDung);
            return dtNguoiDung;
        }

        public bool Login(string taikhoan, string matkhau)
        {
            try
            {
                // Ket noi
                _conn.Open();

                
                string SQL = string.Format("select * from NGUOIDUNG Where TaiKhoan = '" + taikhoan + "' And MatKhau = '" + matkhau + "'");
               
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader dt = cmd.ExecuteReader();
                // Query và kiểm tra
                if (dt.Read()== true)
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

        public bool DoiMatKhau(DTO_DangNhap dn, string taikhoan)
        {
           
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE NGUOIDUNG SET MatKhau = N'"+ dn.Mat_Khau +"' WHERE TaiKhoan = '" + taikhoan + "'");


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

        public bool ThemNguoiDung(DTO_DangNhap nd)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO NGUOIDUNG (TaiKhoan, MatKhau, PhanQuyen, HoTen, NgaySinh, ChucVu, DienThoai) values ('" + nd.Tai_Khoan + "', '" + nd.Mat_Khau + "','" + nd.Phan_Quyen + "', N'" + nd.Ho_Ten + "', '" + nd.Ngay_Sinh + "', N'" + nd.Chuc_Vu + "', '" + nd.Dien_Thoai + "')");

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

        public bool SuaNguoiDung(DTO_DangNhap nd)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE NGUOIDUNG SET MatKhau = '{0}', PhanQuyen = '{1}', HoTen = N'{2}', NgaySinh = '{3}', ChucVu = N'{4}', DienThoai = '{5}' WHERE TaiKhoan = '{6}'", nd.Mat_Khau, nd.Phan_Quyen, nd.Ho_Ten, nd.Ngay_Sinh, nd.Chuc_Vu, nd.Dien_Thoai, nd.Tai_Khoan);
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

        public bool XuaNguoiDung(string taikhoan)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("DELETE FROM NGUOIDUNG  WHERE TaiKhoan = '{0}'", taikhoan);
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
