﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_DangNhapMoi());
            Application.Run(new Frm_MainAdmin);
            //Application.Run(new Frm_XuatTheTS());
            

        }
    }
}
