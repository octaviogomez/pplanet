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
    public class WAlumno
    {
        ManagerBD Manager;
        IAlumno ViewAlumno;
        CAlumno objAlumno;
        public WAlumno(IAlumno InterfazAlumno)
        {
            objAlumno = new CAlumno();
            Manager = new ManagerBD();
            ViewAlumno = InterfazAlumno;
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
