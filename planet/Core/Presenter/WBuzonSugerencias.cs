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
    public class WBuzonSugerencias
    {
        ManagerBD Manager;
        IBuzonSugerencias ViewBuzonSugerencias;
        CBuzonSugerencias objBuzonSugerencias;
        public WBuzonSugerencias(IBuzonSugerencias InterfazBuzonSugerencias)
        {
            objBuzonSugerencias = new CBuzonSugerencias();
            Manager = new ManagerBD();
            ViewBuzonSugerencias = InterfazBuzonSugerencias;
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
