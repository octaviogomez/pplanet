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
    public class WProfesor
    {
        ManagerBD Manager;
        IProfesor ViewProfesor;
        CProfesor objProfesor;
        public WProfesor(IProfesor InterfazProfesor)
        {
            objProfesor = new CProfesor();
            Manager = new ManagerBD();
            ViewProfesor = InterfazProfesor;
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
