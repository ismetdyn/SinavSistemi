using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace SinavSistemi.Common
{
    public class ORMBase<ET, OT> : IORM<ET>
        where ET : class, new()
        where OT : class, new()
    {
        private static OT _current;
        public static OT Current
        {
            get
            { if (_current == null) _current = new OT();
                return _current;
            }
        }

        public Result<ET> GetByID(int id)
        {
            try
            {
                if (id <= 0) throw new Exception("Hata! verilen ID geçersiz.");
                TableAttribute table = Tools.TableAtt<ET>();
                string query = string.Format("select * from {0}",table.TableName);
                
                PropertyInfo[] properties = typeof(ET).GetProperties();
                SqlCommand cmd = new SqlCommand();
                foreach (PropertyInfo pi in properties)
                {
                    DataObjectFieldAttribute dofa = Tools.DataObjectField(pi);
                    if (dofa != null && dofa.IsIdentity == true)
                    {
                        if (dofa.ColumnName == table.IdentityColumn)
                        {
                            query += string.Format(" where {0}=", table.IdentityColumn);
                            query += string.Format("@{0}", pi.Name);
                            cmd.Parameters.AddWithValue(string.Format("@{0}", pi.Name), id);
                        }
                    }
                }

                cmd.CommandText = query;
                cmd.Connection = Tools.Connection;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count <= 0 || dt.Rows[0][0] == DBNull.Value) throw new Exception("Eşleşen veri bulunamadı");
                Result<ET> result = dt.Rows[0].ToEntity<ET>();
                if(!result.IsSuccess) throw new Exception(result.Message);
                return new Result<ET>
                {
                    IsSuccess = true,
                    Message = string.Format("{0} bulundu ve getirildi.", typeof(ET)),
                    Data = result.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<ET>
                {
                    IsSuccess = false,
                    Message = string.Format("Hata! {0} ' erişilemedi." + ex.Message, typeof(ET)),
                    Data = null
                };
            }
        }

        public Result<ET> GetBy(string propertyName, string value)
        {
            try
            {
                ET enntity = new ET();
                if (value == null) throw new Exception("Hata! deger geçersiz.");
                string query = string.Format("select * from {0}", Tools.TableAtt<ET>().TableName);

                SqlCommand cmd = new SqlCommand();
                foreach (PropertyInfo pi in typeof(ET).GetProperties())
                {
                    DataObjectFieldAttribute dofa = Tools.DataObjectField(pi);
                    if (dofa != null && dofa.ColumnName == propertyName)
                    {
                        if (pi.Name == propertyName)
                        {
                            query += string.Format(" where {0}=@{1}", dofa.ColumnName, pi.Name);
                            cmd.Parameters.AddWithValue(string.Format("@{0}", pi.Name), value);
                        }
                    }
                }

                cmd.CommandText = query;
                cmd.Connection = Tools.Connection;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Result<ET> result1 = new Result<ET> { IsSuccess = true };
                if (dt.Rows.Count <= 0 || dt.Rows[0][0] == DBNull.Value)
                {
                    result1.Message = "Komut başarıyla çalıştı fakat eşleşen öğe bulunamadı";
                    result1.Data = null;
                }
                else
                {
                    result1.Message = "Komut başarıyla çalıştı, eşleşen öğe bulundu";
                    Result<ET> result2 = dt.Rows[0].ToEntity<ET>();
                    if (!result2.IsSuccess) throw new Exception(result2.Message);
                    result1.Data = result2.Data;
                }
                return result1;
            }
            catch (Exception ex)
            {
                return new Result<ET>
                {
                    IsSuccess = false,
                    Message = string.Format("Hata(GetBy)!" + ex.Message),
                    Data = null
                };
            }
        }

        public Result<List<ET>> Select()
        {
            string query = "select * from ";
            query += string.Format("{0}", Tools.TableAtt<ET>().TableName);
            SqlDataAdapter adp = new SqlDataAdapter(query, Tools.Connection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt.ToList<ET>();
        }

        private Result<SqlCommand> CreateInsertCommand(ET entity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = string.Format("insert into {0}(",Tools.TableAtt<ET>().TableName);
                string values = " values(";

                foreach (PropertyInfo pi in typeof(ET).GetProperties())
                {
                    DataObjectFieldAttribute att = Tools.DataObjectField(pi);
                    if (pi.Name == Tools.TableAtt<ET>().IdentityColumn || att.IsColumn == false) continue;

                    object value = pi.GetValue(entity);
                    if (value == null) continue;
                    query += string.Format("{0},", att.ColumnName);
                    values += string.Format("@{0},", pi.Name);
                    cmd.Parameters.AddWithValue(string.Format("@{0}", pi.Name), value);
                }

                query = query.Remove(query.Length - 1, 1);
                values = values.Remove(values.Length - 1, 1);
                values += string.Format(")");
                query += string.Format(") {0}", values);

                cmd.CommandText = query;
                cmd.Connection = Tools.Connection;

                return new Result<SqlCommand>
                {
                    IsSuccess = true,
                    Message = "Sql insert komut oluşturma başarılı.",
                    Data = cmd
                };
            }
            catch (Exception ex)
            {
                return new Result<SqlCommand>
                {
                    IsSuccess = false,
                    Message = "Hata(CreateInsertCommand)!" + ex.Message,
                    Data = null
                };
            }
        }

        public Result<bool> Insert(ET entity)
        {
            try 
            {
                Result<SqlCommand> result1 = CreateInsertCommand(entity);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                Result<bool> result2 = result1.Data.ExecAsync().Result;
                if (!result2.IsSuccess) throw new Exception(result2.Message);

                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "Insert işlemi başarılı",
                    Data = true,
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = "Hata! Insert işlemi başarısız." + ex.Message,
                    Data = false
                };
            }
        }

        public Result<bool> AddRange(List<ET> entities)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Tools.Connection;
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                foreach (ET entity in entities)
                {
                    if (entity != null)
                    {
                        Result<SqlCommand> result1 = CreateInsertCommand(entity);
                        if(!result1.IsSuccess) throw new Exception(result1.Message);
                        result1.Data.Connection = Tools.Connection;
                        result1.Data.ExecuteNonQuery();
                    }
                }
                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "İşlem Başarılı"
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = "Hata!" + ex.Message,
                };
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
            }
        }

        public Result<bool> Update(ET entity)
        {
            
            try
            {
                Result<SqlCommand> result1 =  CreateUpdateCommand(entity);
                if(!result1.IsSuccess) throw new Exception(result1.Message);
                Result<bool> result2 = result1.Data.ExecAsync().Result;
                if (!result2.IsSuccess) throw new Exception(result2.Message);

                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "Update işlemi başarılı",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = "Hata! Update işlemi başarısız."+ex.Message,
                    Data = false
                };
            }
            
        }

        private Result<SqlCommand> CreateUpdateCommand(ET entity)
        {
            string query = string.Format("update {0} set", Tools.TableAtt<ET>().TableName);
            string where = string.Format(" where {0}=", Tools.TableAtt<ET>().IdentityColumn);

            SqlCommand cmd = new SqlCommand();
            try
            {
                foreach (PropertyInfo pi in typeof(ET).GetProperties())
                {
                    DataObjectFieldAttribute att = Tools.DataObjectField(pi);
                    if (att.IsIdentity)
                    {
                        object val = pi.GetValue(entity);
                        where += string.Format("@{0}", pi.Name);
                        cmd.Parameters.AddWithValue(string.Format("@{0}", pi.Name), val);
                        continue;
                    }
                    object value = pi.GetValue(entity);
                    if (value == null) continue;
                    query += string.Format(" {0} = @{1},", att.ColumnName, pi.Name);
                    cmd.Parameters.AddWithValue(string.Format("@{0}", pi.Name), value);
                }

                query = query.Remove(query.Length - 1, 1);
                query += where;

                cmd.CommandText = query;
                cmd.Connection = Tools.Connection;

                return new Result<SqlCommand>
                {
                    IsSuccess = true,
                    Message = "işlem başarılı",
                    Data = cmd
                };
            }
            catch (Exception ex)
            {
                return new Result<SqlCommand>
                {
                    IsSuccess = false,
                    Message = "Hata!" + ex.Message,
                    Data = null
                };
            }

        }

        public Result<bool> Delete(ET entity)
        {
            try
            {   Result<SqlCommand> result1 = CreateDeleteCommand(entity);
                if(!result1.IsSuccess) throw new Exception(result1.Message);
                Result<bool> result2 = result1.Data.ExecAsync().Result;
                if (!result2.IsSuccess) throw new Exception(result2.Message);
                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "Delete işlemi Başarılı",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = "Hata!"+ex.Message,
                    Data = false
                };
            }
        }

        private Result<SqlCommand> CreateDeleteCommand(ET entity)
        {
            try
            {
                Result<string> result1 = Tools.CheckIDandIdentityColumn(entity);
                if (!result1.IsSuccess) throw new Exception(result1.Message);

                SqlCommand cmd = new SqlCommand();
                string query = string.Format("delete from {0} where {1} =", Tools.TableAtt<ET>().TableName, Tools.TableAtt<ET>().IdentityColumn);
                query += string.Format(" @{0}",result1.Data);
                
                Result<int> result3 = Tools.GetID(entity);
                if(!result3.IsSuccess) throw new Exception(result3.Message);
                
                cmd.Parameters.AddWithValue(string.Format("@{0}", result1.Data), result3.Data);
                cmd.CommandText = query;
                cmd.Connection = Tools.Connection;
                Result<bool> result4 = cmd.ExecAsync().Result;
                if(!result4.IsSuccess) throw new Exception(result4.Message);
                return new Result<SqlCommand>
                {
                    IsSuccess = true,
                    Message = "işlem başarılı",
                    Data = cmd
                };
            }
            catch (Exception ex)
            {
                return new Result<SqlCommand>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = null
                };
            }
        }

        public Result<bool> RemoveRange(List<ET> entities)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Tools.Connection;
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                foreach (ET entity in entities)
                {
                    if (entity != null)
                    {
                        Result<SqlCommand> result1 = CreateDeleteCommand(entity);
                        if (!result1.IsSuccess) throw new Exception(result1.Message);
                        result1.Data.Connection = Tools.Connection;
                        result1.Data.ExecuteNonQuery();
                    }
                }
                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "RemoveRange işlemi başarılı"
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
