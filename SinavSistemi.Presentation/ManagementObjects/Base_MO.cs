using DevExpress.LookAndFeel;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace SinavSistemi.Presentation.ManagementObjects
{
    public class Base_MO<MO, UI> where MO : class, new() where UI : class, new() 
    {
        //private static MO _currentMO;

        //protected internal static MO CurrentMO
        //{
        //    get 
        //    {
        //        if (_currentMO == null) _currentMO = new MO();
        //        return _currentMO; 
        //    }
        //}

        //private static UI _currentUI;

        //protected internal static UI CurrentUI
        //{
        //    get
        //    {
        //        if (_currentUI == null) _currentUI = new UI();
        //        return _currentUI;
        //    }
        //}

        //public static void TrySetProperty()
        //{
        //    Type type = typeof(MO);
        //    PropertyInfo pi = type.GetProperty("UI");
        //    if(pi != null && pi.CanWrite && pi.GetValue(CurrentMO) == null) pi.SetValue(CurrentMO, new UI());
        //}

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
