using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.Common
{
    public static class Tools
    {
        private static SqlConnection _connection;
        public static SqlConnection Connection
        {
            get 
            { 
                if( _connection == null )
                {
                    _connection = new SqlConnection();
                    _connection.ConnectionString = ConfigurationManager.ConnectionStrings["SinavSistemiDB"].ConnectionString;
                }
                return _connection; 
            }
        }

        public static TableAttribute TableAtt<ET>()
        {
             TableAttribute attribute = (TableAttribute)typeof(ET).GetCustomAttribute(typeof(TableAttribute), false);
             if (attribute != null)
             {
                 TableAttribute tbl = attribute;
                 return tbl;
             }
             return null;
        }

        public static DataObjectFieldAttribute DataObjectField(PropertyInfo pi)
        {
            return (DataObjectFieldAttribute)pi.GetCustomAttribute(typeof(DataObjectFieldAttribute), false);
        }

        public static Result<List<ET>> ToList<ET>(this DataTable dt) where ET : class,new()
        {
            try
            {
                List<ET> list = new List<ET>();

                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(dr.ToEntity<ET>().Data);
                }

                return new Result<List<ET>>
                {
                    IsSuccess =true,
                    Message = "İşlem Başarılı",
                    Data = list
                };
            }
            catch (Exception ex)
            {
                return new Result<List<ET>>
                {
                    IsSuccess = false,
                    Message = "Hata! " + ex.Message 
                };
            }
        }
        public static Result<ET> ToEntity<ET>(this DataRow dr) where ET : class, new()
        {
            try
            {
                Type type = typeof(ET);
                ET obj = new ET();

                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo pi in properties)
                {
                    DataObjectFieldAttribute attr = DataObjectField(pi);
                    object value = dr[attr.ColumnName];

                    if (value == null || value == DBNull.Value) continue;
                    else pi.SetValue(obj, value);
                }

                return new Result<ET>
                {
                    IsSuccess = true,
                    Data = obj
                };
            }
            catch (Exception ex)
            {
                return new Result<ET>
                {
                    IsSuccess = false,
                    Message = "Hata! " + ex.Message
                };
            }
        }

        public static Result<DynamicDataTransferObject> ToDDTO(this DataTable dt)
        {
            try
            {
                DataRow dr = dt.Rows[0]; 
                DynamicDataTransferObject ddto = new DynamicDataTransferObject();
                foreach (DataColumn column in dt.Columns)
                {
                    ddto[column.ColumnName] = dt.Rows[0][column];
                }

                return new Result<DynamicDataTransferObject>
                {
                    IsSuccess = true,
                    Message = "DataRow'dan DDTO başarıyla oluşturuldu.",
                    Data = ddto 
                };
            }
            catch (Exception ex)
            {
                return new Result<DynamicDataTransferObject>
                {
                    IsSuccess = false, 
                    Message = ex.Message
                };
            }
        }

        public static async Task<Result<bool>> ExecAsync(this SqlCommand command)
        {
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                    await command.Connection.OpenAsync().ConfigureAwait(false);

                int result = await command.ExecuteNonQueryAsync().ConfigureAwait(false);
                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "İşlem Başarılı.",
                    Data = result >0
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = false
                };
            }
            finally
            {
                if(command.Connection.State != ConnectionState.Closed)
                    command.Connection.Close();
            }
        }

        public static Result<string> CheckIDandIdentityColumn<ET>(ET entity)
        {
            try
            {
                string identityColumnName = "";
                TableAttribute table = TableAtt<ET>();
                PropertyInfo[] properties = typeof(ET).GetProperties();
                int count = 0;

                foreach (PropertyInfo pi in properties)
                {
                    DataObjectFieldAttribute dofa = DataObjectField(pi);
                    if (dofa != null && dofa.IsIdentity == true)
                    {
                        if (dofa.ColumnName != table.IdentityColumn)
                        {
                            throw new Exception("Hata! Nesneye ilişkin Identity property var, fakat veritabanında ilişkili tablo yok!");
                        } else identityColumnName = dofa.ColumnName;
                        object value = pi.GetValue(entity);
                        if(value == null || value == DBNull.Value || (Convert.ToInt32(value) <= 0))
                        {
                            throw new Exception("ID değeri kabul edilebilir bir değer değil.");
                        }
                    }
                    count++;
                }
                if (count == 0) throw new Exception("Hata! Bu nesneye ilişkin identity property bulunamadı");

                return new Result<string>
                {
                    IsSuccess = true,
                    Message = "İdentity bilgisi ve ilgili tablosu var",
                    Data = identityColumnName
                };
            }
            catch (Exception ex)
            {
                return new Result<string>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }

        public static Result<int> GetID<ET>(ET entity)
        {
            try
            {
                int id = -1;
                PropertyInfo[] properties = typeof(ET).GetProperties();
                foreach (PropertyInfo pi in properties)
                {
                    DataObjectFieldAttribute att = DataObjectField(pi);
                    if (att.IsIdentity)
                    {
                        object value = pi.GetValue(entity);
                        if (value == null) throw new Exception("Hata! Identity değeri null.");
                        id = Convert.ToInt32(value);
                    }
                }
                return new Result<int>
                {
                    IsSuccess = true,
                    Message = "id bulundu",
                    Data = id
                };
            }
            catch (Exception ex)
            {
                return new Result<int>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }

        public static Result<bool> CheckEntityinDB<ET>(ET entity)
        {
            try
            {
                Result<int> result1 = GetID(entity);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                Type type = typeof(ET);
                string query = "select * from";
                TableAttribute table = TableAtt<ET>();
                PropertyInfo[] properties = typeof(ET).GetProperties();
                SqlCommand cmd = new SqlCommand();
                foreach (PropertyInfo pi in properties)
                {
                    DataObjectFieldAttribute dofa = DataObjectField(pi);
                    if (dofa != null && dofa.IsIdentity == true)
                    {
                        query += string.Format(" {0}", table.TableName);
                        query += string.Format(" where {0}=", table.IdentityColumn.ToString());
                        query += string.Format("@{0}", dofa.ColumnName);
                        cmd.Parameters.AddWithValue(string.Format("@{0}", dofa.ColumnName),result1.Data);
                    }
                }
                cmd.CommandText = query;
                cmd.Connection = Connection;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count <= 0 || dt.Rows[0][0] == DBNull.Value) throw new Exception("Hata! Eşleşen veri bulunamadı");
                if (dt.Rows.Count > 1) throw new Exception("Hata! aynı idetity ile eşleşen 1' den fazla kayıt");
                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "Nesne veritabanında var.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = false
                };
            }
        }

        public static Result<DataTable> CheckIDinDB<ET>(int id)
        {
            try
            {
                Type type = typeof(ET);
                string query = "select * from";
                TableAttribute table = TableAtt<ET>();
                PropertyInfo[] properties = typeof(ET).GetProperties();
                SqlCommand cmd = new SqlCommand();
                foreach (PropertyInfo pi in properties)
                {
                    DataObjectFieldAttribute dofa = DataObjectField(pi);
                    if (dofa != null && dofa.IsIdentity == true)
                    {
                        query += string.Format(" {0}", table.TableName);
                        query += string.Format(" where {0}=", table.IdentityColumn.ToString());
                        query += string.Format("@{0}", dofa.ColumnName);
                        cmd.Parameters.AddWithValue(string.Format("@{0}", dofa.ColumnName), id);
                    }
                }
                cmd.CommandText = query;
                cmd.Connection = Connection;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count <= 0 || dt.Rows[0][0] == DBNull.Value) throw new Exception("Hata! Eşleşen veri bulunamadı");
                if (dt.Rows.Count > 1) throw new Exception("Hata! aynı idetity ile eşleşen 1' den fazla kayıt");
                return new Result<DataTable>
                {
                    IsSuccess = true,
                    Message = "Nesne bulundu! Geri dönüş datatable şeklinde!",
                    Data = dt
                };
            }

            catch (Exception ex)
            {
                return new Result<DataTable>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = null
                };
            }
        }
    }
}
