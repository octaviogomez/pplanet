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
    public class WSecretaria
    {
        ManagerBD Manager;
        ISecretaria ViewSecretaria;
        CSecretaria objSecretaria;
        public WSecretaria(ISecretaria InterfazSecretaria)
        {
            objSecretaria = new CSecretaria();
            Manager = new ManagerBD();
            ViewSecretaria = InterfazSecretaria;
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
