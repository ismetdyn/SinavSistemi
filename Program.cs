using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SinavSistemi.Presentation.UIs;
using SinavSistemi.Entity;

namespace SinavSistemi.Presentation
{
    static class Program
    {
        public static Kullanici kullanici;
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
            SkinManager.EnableMdiFormSkins();
            Application.Run(InitializeForm.Current);
        }
    }
}
