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
    public class CClubs
    {
        ManagerBD objManagerBD;
        public CClubs()
        {
            objManagerBD = new ManagerBD();
        }

        #region Propiedades
        public int pk_club { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int estado { get; set; }
        public string fecha { get; set; }
        public int fk_hora { get; set; }
        public int fk_profesor { get; set; }
        public int cupo { get; set; }
        public int fk_tipoClub { get; set; }
        public int id_registro { get; set; }
        #endregion
    }
}
