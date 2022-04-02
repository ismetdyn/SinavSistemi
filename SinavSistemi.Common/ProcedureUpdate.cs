using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.Common
{
    public class ProcedureUpdate<ET> : Procedure<ET> where ET : class
    {
        public string query = "";
        SqlCommand cmd = new SqlCommand();
        public override string GetStoreProcedure => "update";
        public override string AddQuery(ET entity)
        {
            PropertyInfo[] properties = typeof(ET).GetProperties();
            query += string.Format(" {0} set", base.TableAtt.TableName);
            foreach (PropertyInfo pi in properties)
            {
                if(pi.Name == base.TableAtt.IdentityColumn)
                {
                    continue;
                }
                object value = pi.GetValue(entity);
                if (value == null) continue;
                query += string.Format(" {0} =", pi.Name);
                query += string.Format(" @{0},", pi.Name);
                cmd.Parameters.AddWithValue(string.Format("@{0}", pi.Name), value);
            }
            query = query.Remove(query.Length - 1, 1);
            query += string.Format(" where {0}=", TableAtt.IdentityColumn.ToString());
            //query += string.Format("{0}", );

            cmd.CommandText = query;
            cmd.Connection = Tools.Connection;

            return query;
        }
    }
}
