using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.Common
{
    class ProcedureDelete<ET> : Procedure<ET> where ET : class
    {
        public override string GetStoreProcedure => throw new NotImplementedException();

        public override string AddQuery(ET entity)
        {
            throw new NotImplementedException();
        }
    }
}
