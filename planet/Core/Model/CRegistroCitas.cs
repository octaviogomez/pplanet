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
    public class CRegistroCitas
    {
        ManagerBD objManagerBD;
        public CRegistroCitas()
        {
            objManagerBD = new ManagerBD();
        }

        #region Propiedades
        public int pk_registroCita { get; set; }

        public int fk_cita { get; set; }

        public int fk_alumno { get; set; }

        public int fk_tipoCitas { get; set; }

        public int estadoReservacion { get; set; }

        public int fk_lecciones { get; set; }
        #endregion
    }
}
