using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.Common
{
    public class ProcedureInsert<ET> : Procedure<ET> where ET : class
    {
        private string query = "";
        private string values = " values(";
        SqlCommand cmd = new SqlCommand();
        public override string GetStoreProcedure => "insert into";

        public override string AddQuery(ET entity)
        {
             query += string.Format(" {0}(", base.TableAtt.TableName);
             foreach (PropertyInfo pi in base.GetProperties)
             {
                 if(pi.Name == base.TableAtt.IdentityColumn)
                 {
                     continue;
                 }
                object value = pi.GetValue(entity);
                if (value == null) continue;
                query += string.Format("{0},", pi.Name);
                values += string.Format("@{0},", pi.Name);
                cmd.Parameters.AddWithValue(string.Format("@{0}", pi.Name), value);
             }

            query = query.Remove(query.Length - 1, 1);
            values = values.Remove(values.Length - 1, 1);
            values += string.Format(")");
            query += string.Format(") {0}", values);


            return query;
        }
    }
}
