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
    public class WListaEspera
    {
        ManagerBD Manager;
        IListaEspera ViewListaEspera;
        CListaEspera objListaEspera;
        public WListaEspera(IListaEspera InterfazListaEspera)
        {
            objListaEspera = new CListaEspera();
            Manager = new ManagerBD();
            ViewListaEspera = InterfazListaEspera;
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
