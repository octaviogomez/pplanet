using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Model;
using Core.View;
using System.Data;
using System.Data.SqlClient;

namespace Core.Presenter
{
    class WCitas
    {

        ManagerBD Manager;
        ICitas ViewCitas;
        CCitas objCitas;
        public WCitas(ICitas InterfazCitas)
        {
            objCitas = new CCitas();
            Manager = new ManagerBD();
            ViewCitas = InterfazCitas;
        }
        public bool ExisteConexion()
        {
            bool ConexcionAvierta = false;
            SqlConnection sqlCon = Manager.GetConnection();
            if (sqlCon.State == ConnectionState.Open)
            {
                ConexcionAvierta = true;
            }
            return ConexcionAvierta;
        }
    }
}
