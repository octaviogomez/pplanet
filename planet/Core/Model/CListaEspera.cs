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
    public class CListaEspera
    {
        ManagerBD objManagerBD;
        public CListaEspera()
        {
            objManagerBD = new ManagerBD();
        }
        #region Propiedades
        public int pk_listaEspera { get; set; }
        public int fk_alumno { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public int fk_club { get; set; }
        public int fk_cita { get; set; }
        #endregion
    }
}
