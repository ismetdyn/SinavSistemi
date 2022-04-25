using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

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
            WindowsFormsSettings.EnableFormSkins();
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Office Dark");
            SetSkinPalette();

            DevExpress.Utils.AppearanceObject.DefaultFont = new System.Drawing.Font(" Segoe UI", GetDefaultSize());

            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;
            WindowsFormsSettings.CustomizationFormSnapMode = DevExpress.Utils.Controls.SnapMode.OwnerControl;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminUI());
        }

        static float GetDefaultSize()
        {
            return 8.25F;
        }

        static void SetSkinPalette()
        {
            var skin = CommonSkins.GetSkin(WindowsFormsSettings.DefaultLookAndFeel);
            DevExpress.Utils.Svg.SvgPalette palette = skin.CustomSvgPalettes["Office Dark"];
            skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(palette);
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }
    }
}
