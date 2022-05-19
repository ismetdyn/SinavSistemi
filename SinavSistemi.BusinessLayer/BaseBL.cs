namespace SinavSistemi.BusinessLayer
{
    public class BaseBL<OT> where OT : class, new()
    {
        private static OT _current;

        public static OT Current
        {
            get 
            {
                if (_current == null) _current = new OT();
                return _current; 
            }
        }
    }
}
