using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;

namespace GUI_QuanLy
{
    public partial class Frm_DocFile : Form
    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties = 'Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties = 'Excel 8.0;HDR={1}'";

        public Frm_DocFile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            string extension = Path.GetExtension(filePath);
            string header = rdbCo.Checked ? "Yes" : "No";
            string conStr, sheetName;

            conStr = string.Empty;
            switch (extension)
            {
                case ".xls":
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;
                case ".xlsx":
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            using (OleDbConnection conn = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    DataTable dtExcelSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    conn.Close();
                }
            }
            using (OleDbConnection conn = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        cmd.CommandText = "Select * From [" + sheetName + "]";
                        cmd.Connection = conn;
                        conn.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        conn.Close();

                        dataGridView1.DataSource = dt;
                         
                    }
                }
            }
        }
    }
}
