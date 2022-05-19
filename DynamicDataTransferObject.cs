using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;

namespace SinavSistemi.Common
{
    public class DynamicDataTransferObject : DynamicObject
    {
        public  Dictionary<string, object> dictionary = new Dictionary<string, object>();

        public object this[string propertyName]
        {
            get { return dictionary[propertyName]; }
            set { AddProperty(propertyName, value); }
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return dictionary.TryGetValue(binder.Name , out result);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            AddProperty(binder.Name, value);
            return true;
        }

        public void AddProperty(string name, object value)
        {
            dictionary[name] = value;
        }
    }
}
