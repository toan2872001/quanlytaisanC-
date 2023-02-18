using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=QUOC-TOAN\\SQLEXPRESS;Initial Catalog=QLTS;Integrated Security=True");
    }
}
