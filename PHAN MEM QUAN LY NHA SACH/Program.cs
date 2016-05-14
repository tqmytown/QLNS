using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PHAN_MEM_QUAN_LY_NHA_SACH
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

            //Enable Skin for Xtra Form of DevExpress
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();

            Application.Run(new Login());

        }
    }
}
