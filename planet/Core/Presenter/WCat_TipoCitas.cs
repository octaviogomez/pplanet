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
    public class WCat_TipoCitas
    {
        ManagerBD Manager;
        ICat_TipoCitas ViewCat_TipoCitas;
        CCat_TipoCitas objCat_TipoCitas;
        public WCat_TipoCitas(ICat_TipoCitas InterfazCat_TipoCitas)
        {
            objCat_TipoCitas = new CCat_TipoCitas();
            Manager = new ManagerBD();
            ViewCat_TipoCitas = InterfazCat_TipoCitas;
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
