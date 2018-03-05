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
    public class WClubs
    {
        ManagerBD Manager;
        Iclubs ViewClubs;
        CClubs objClubs;
        public WClubs(Iclubs InterfazClubs)
        {
            objClubs = new CClubs();
            Manager = new ManagerBD();
            ViewClubs = InterfazClubs;
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
