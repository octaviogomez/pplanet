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
    public class CRegistroClubs
    {
        ManagerBD objManagerBD;
        public CRegistroClubs()
        {
            objManagerBD = new ManagerBD();
        }

        #region Propiedades
        public int pk_registroClub { get; set; }
        public int fk_club { get; set; }
        public int fk_alumno { get; set; }
        public int estadoReservacion { get; set; }
        #endregion
    }
}
