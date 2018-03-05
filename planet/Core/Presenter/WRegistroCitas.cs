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
    public class WRegistroCitas
    {

        ManagerBD Manager;
        IRegistroCitas ViewRegistroCitas;
        CRegistroCitas objRegistroCitas;
        public WRegistroCitas(IRegistroCitas InterfazRegistroCitas)
        {
            objRegistroCitas = new CRegistroCitas();
            Manager = new ManagerBD();
            ViewRegistroCitas = InterfazRegistroCitas;
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
