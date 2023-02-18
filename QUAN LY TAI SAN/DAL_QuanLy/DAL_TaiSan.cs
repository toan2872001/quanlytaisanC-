using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_TaiSan : DBConnect
    {
        public DataTable getTaiSan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable KTTaiSan(string mats)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE MaTS = '"+ mats +"'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable KTLoaiTaiSan(string maloai)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE MaLoai = '" + maloai + "'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }
        public DataTable KTNguonQuy(string manguon)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE MaNguon = '" + manguon + "'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable KTBoPhan(string mabp)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE MaBP = '" + mabp + "'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }
        public bool themTaiSan(DTO_TaiSan ts)
        {
            try
            {
                // Ket noi
                _conn.Open();
                //string SQL = string.Format("INSERT INTO TAISAN (MaTS, TenTS, DVT, SoLuong, DonGia, NgayNhap, MaLoai, MaXuatXu, MaNguon, MaBP, MucKH, TinhTrang) values ('" + ts.Ma_TS + "', N'" + ts.Ten_TS + "', N'" + ts.D_VT + "', '" + ts.So_Luong + "', '" + ts.Don_Gia + "', '" + ts.Ngay_Nhap + "', '"+ ts.Ma_Loai +"', '" + ts.Ma_Xuat_Xu + "', '" + ts.Ma_Nguon + "', '" + ts.Ma_BP + "', '"+ ts.Muc_KH +"', N'" + ts.Tinh_Trang + "')");
                string SQL = string.Format("INSERT INTO TAISAN (MaTS, TenTS, DVT, SoLuong, DonGia, NgayNhap, MaLoai, MaXuatXu, MaNguon, MaBP, MucKH, TinhTrang) values ('" + ts.Ma_TS + "', N'" + ts.Ten_TS + "', N'" + ts.D_VT + "', '" + ts.So_Luong + "', '" + ts.Don_Gia + "', '" + ts.Ngay_Nhap + "', '" + ts.Ma_Loai + "', '" + ts.Ma_Xuat_Xu + "', '" + ts.Ma_Nguon + "', '" + ts.Ma_BP + "', '" + ts.Muc_KH + "', N'" + ts.Tinh_Trang + "')");

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

        public bool suaTaiSan(DTO_TaiSan ts)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE TAISAN SET TenTS = N'{0}', SoLuong = '{1}', DonGia = '{2}', NgayNhap = '{3}', MaLoai = '{4}', MaXuatXu = N'{5}', MaNguon = '{6}', MaBP = '{7}', MucKH = '{8}', TinhTrang = N'{9}' WHERE MaTS = '{10}'", ts.Ten_TS, ts.So_Luong, ts.Don_Gia, ts.Ngay_Nhap, ts.Ma_Loai, ts.Ma_Xuat_Xu, ts.Ma_Nguon, ts.Ma_BP, ts.Muc_KH, ts.Tinh_Trang, ts.Ma_TS);


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

        public bool xoaTaiSan(string mats)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("DELETE FROM TAISAN WHERE MaTS = '"+ mats +"'");
                               
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

        public DataTable TimTen(string ts)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE TenTS like N'%" + ts + "%'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable TimMa(string ts)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE MaTS like '%" + ts + "%'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable TimDonGia(float ts)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE DonGia like '%" + ts + "%'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable TimNgayNhap(DateTime ts)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE NgayNhap like '%" + ts + "%'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable TimMaLoai(string ts)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE MaLoai like '%" + ts + "%'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable TimMaXuatXu(string ts)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE MaXuatXu like '%" + ts + "%'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable TimMaNguon(string ts)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE MaNguon like '%" + ts + "%'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable TimMaBP(string ts)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE MaBP like '%" + ts + "%'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable TimMucKH(int ts)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE MucKH like '%" + ts + "%'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public DataTable TimTinhTrang(string ts)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAISAN WHERE TinhTrang like N'%" + ts + "%'", _conn);
            DataTable dtTaiSan = new DataTable();
            da.Fill(dtTaiSan);
            return dtTaiSan;
        }

        public bool KhauHao(int kh, string mats)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE TAISAN TS, LOAITAISAN LTS SET TS.MucKH = TS.MucKH + LTS.KhauHao WHERE TS.MaLoai = LTS.MaLoai");


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
