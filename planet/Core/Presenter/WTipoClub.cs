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
    public class WTipoClub
    {
        ManagerBD Manager;
        ITipoClub ViewTipoClub;
        CTipoClub objTipoClub;
        public WTipoClub(ITipoClub InterfazTipoClub)
        {
            objTipoClub = new CTipoClub();
            Manager = new ManagerBD();
            ViewTipoClub = InterfazTipoClub;
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
