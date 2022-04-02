using System;
using System.Linq;
using System.Reflection;

namespace SinavSistemi.Common
{
    public abstract class Procedure<ET> where ET : class
    {
        private string query = "";
        protected string Query
        {
            get
            {
                return query;
            }
        }
        private Type ETType
        {
            get
            {
                return typeof(ET);
            }
        }

        protected PropertyInfo[] GetProperties
        {
            get
            {
                PropertyInfo[] properties = ETType.GetProperties();
                return properties;
            }
        }

        protected TableAttribute TableAtt
        {
            get
            {
                var attributes = ETType.GetCustomAttributes(typeof(TableAttribute), false);
                if (attributes != null && attributes.Any())
                {
                    TableAttribute tbl = (TableAttribute)attributes[0];
                    return tbl;
                }
                return null;
            }
        }
        public abstract string GetStoreProcedure { get; }

        public abstract string AddQuery(ET entity);
    }
}
