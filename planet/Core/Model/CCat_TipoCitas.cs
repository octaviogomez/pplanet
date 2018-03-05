using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

using Core.Model;
namespace Core.Model
{
    public class CCat_TipoCitas
    {
        ManagerBD objManagerBD;
        public CCat_TipoCitas()
        {
            objManagerBD = new ManagerBD();
        }
        #region Propiedades

        public int pk_tipoCitas { get; set; }
        public string descripcion { get; set; }
        public int valor { get; set; }
        #endregion
    }
}
