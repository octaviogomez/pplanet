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
    public class WAvisoGenerales
    {
        ManagerBD Manager;
        IAvisoGenerales ViewAvisoGenerales;
        CAvisoGenerales objAvisogenerales;
        public WAvisoGenerales(IAvisoGenerales InterfazAvisoGenerales)
        {
            objAvisogenerales = new CAvisoGenerales();
            Manager = new ManagerBD();
            ViewAvisoGenerales = InterfazAvisoGenerales;
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
        public void ObtenerAvisoGeneral(int opcion)
        {
            DataSet datLoggerUserInformation = new DataSet();
            CAvisoGenerales objAviso = new CAvisoGenerales();
            bool ExisteUsuario = false;

            if (ExisteConexion())
            {
                ExisteUsuario = objAviso.ConsultaAvisoGeneral(opcion,ref datLoggerUserInformation);
                if (ExisteUsuario)
                {
                    try
                    {
                        objAviso.Descripcion = datLoggerUserInformation.Tables[0].Rows[0][0].ToString();
                        objAviso.Fecha = datLoggerUserInformation.Tables[0].Rows[0][1].ToString();
                        objAviso.Direccion = datLoggerUserInformation.Tables[0].Rows[0][2].ToString();
                        ViewAvisoGenerales.ObjAvisoGenerales = objAviso;
                    }
                    catch (Exception)
                    {
                        ViewAvisoGenerales.ObjAvisoGenerales = null;
                    }
                }
                else
                {
                    ViewAvisoGenerales.MensajeAvisoGenerales("No Valido", 2);
                }
            }
            else
            {
                ViewAvisoGenerales.MensajeAvisoGenerales("No hay conexion en red", 1);
            }
        }
    }
}
