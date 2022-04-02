﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.Common
{
    public class DataObjectFieldAttribute : Attribute
    {
        public DataObjectFieldAttribute(
            [CallerMemberName] string columnName = "",
            bool isColumn = true,
            bool isIdentity = false,
            bool isPrimaryKey = false,
            bool isUnique = false
            )
        {
            IsColumn = isColumn;
            ColumnName = columnName;
            IsIdentity = isIdentity;
            IsPrimaryKey = isPrimaryKey;
            IsUnique = isUnique;
        }
        public bool IsColumn { get; set; }
        public string ColumnName { get; set; }
        public bool IsIdentity { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsUnique { get; set; }
    }
}
