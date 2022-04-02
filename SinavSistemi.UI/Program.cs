using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SinavSistemi.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace SinavSistemi.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowsFormsSettings.ForceDirectXPaint();
            WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Basic");
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;
            WindowsFormsSettings.CustomizationFormSnapMode = DevExpress.Utils.Controls.SnapMode.OwnerControl;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            Application.Run(new LoginUI());
            SkinManager.EnableMdiFormSkins();
        }
    }
}
