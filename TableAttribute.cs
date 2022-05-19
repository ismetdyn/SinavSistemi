using System;

namespace SinavSistemi.Common
{
    public class TableAttribute : Attribute
    {
        public TableAttribute(
            string tableName,
            string identityColumn,
            string primaryKeyColumn,
            string uniqueColumn = null)
        {
            TableName = tableName;
            IdentityColumn = identityColumn;
            PrimaryKeyColumn = primaryKeyColumn;
            UniqueColumn = uniqueColumn;
        }
        public string  TableName { get; set; }
        public string IdentityColumn { get; set; }
        public string PrimaryKeyColumn { get; set; }
        public string UniqueColumn { get; set; }
    }
}
