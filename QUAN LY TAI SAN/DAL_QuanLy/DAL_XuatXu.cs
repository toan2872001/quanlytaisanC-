using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_XuatXu : DBConnect
    {
        public DataTable getXuatXu()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM XUATXU", _conn);
            DataTable dtXuatXu = new DataTable();
            da.Fill(dtXuatXu);
            return dtXuatXu;
        }

        public DataTable KTXuatXu(string mxx)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM XUATXU WHERE MaXuatXu = '" + mxx + "'", _conn);
            DataTable dtXuatXu = new DataTable();
            da.Fill(dtXuatXu);
            return dtXuatXu;
        }

        public bool themXuatXu(DTO_XuatXu xx)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO XUATXU(MaXuatXu, NoiXuatXu) VALUES ('{0}', N'{1}')", xx.Ma_Xuat_Xu, xx.Noi_Xuat_Xu);
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
        public bool suaXuatXu(DTO_XuatXu xx)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE XUATXU SET NoiXuatXu = N'{0}' WHERE MaXuatXu = '{1}'", xx.Noi_Xuat_Xu, xx.Ma_Xuat_Xu);

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

        public bool xoaXuatXu(string maxuatxu)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM XUATXU WHERE MaXuatXu = '" + maxuatxu + "'");

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
