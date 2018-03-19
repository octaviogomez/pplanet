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
    public class CTipoClub
    {
        ManagerBD objManagerBD;
        public CTipoClub()
        {
            objManagerBD = new ManagerBD();
        }
        #region Propiedades
        public int pk_tipoClub { get; set; }
        public string descripcion { get; set; }
        public int valor { get; set; }
        #endregion
    }
}
