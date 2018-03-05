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
    public class CCitas
    {
        ManagerBD objManagerBD;
        public CCitas()
        {
            objManagerBD = new ManagerBD();
        }
        #region Propiedaes
        public int pk_cita { get; set; }
        public int estado { get; set; }
        public string fecha { get; set; }
        public int fk_hora { get; set; }
        public int cupo { get; set; }
        public int NoProfes { get; set; }
        public int id_registro { get; set; }
        #endregion
    }
}
