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
    public class WRegistroClubs
    {
        ManagerBD Manager;
        IRegistroClubs ViewRegistroClubs;
        CRegistroClubs objRegistroClubs;
        public WRegistroClubs(IRegistroClubs InterfazRegistroClubs)
        {
            objRegistroClubs = new CRegistroClubs();
            Manager = new ManagerBD();
            ViewRegistroClubs = InterfazRegistroClubs;
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
