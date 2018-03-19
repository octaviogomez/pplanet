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
        #region Metodo de logeo
        public void ValidarSecretaria(int opcion, CSecretaria SecretariaIngresado)
        {
            DataSet datLoggerUserInformation = new DataSet();
            CSecretaria objAuthenticatedUser = new CSecretaria();
            bool ExisteUsuario = false;

            if (ExisteConexion())
            {
                ExisteUsuario = objAuthenticatedUser.AutentificarSecretaria(opcion, ref datLoggerUserInformation, SecretariaIngresado);
                if (ExisteUsuario)
                {
                    try
                    {
                        objAuthenticatedUser.pk_secreatria = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][0].ToString());
                        objAuthenticatedUser.rol = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][1].ToString());
                        objAuthenticatedUser.id = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][2].ToString());
                        objAuthenticatedUser.clave = datLoggerUserInformation.Tables[0].Rows[0][3].ToString();
                        objAuthenticatedUser.activo = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][4].ToString());
                        objAuthenticatedUser.correo = datLoggerUserInformation.Tables[0].Rows[0][5].ToString();
                        objAuthenticatedUser.nombre = datLoggerUserInformation.Tables[0].Rows[0][6].ToString();
                        objAuthenticatedUser.apellido = datLoggerUserInformation.Tables[0].Rows[0][7].ToString();
                        objAuthenticatedUser.anioIngreso = datLoggerUserInformation.Tables[0].Rows[0][8].ToString();
                        objAuthenticatedUser.anioEgreso = datLoggerUserInformation.Tables[0].Rows[0][9].ToString();
                        objAuthenticatedUser.telefono = datLoggerUserInformation.Tables[0].Rows[0][10].ToString();
                        objAuthenticatedUser.celular = datLoggerUserInformation.Tables[0].Rows[0][11].ToString();

                        ViewSecretaria.ObjSecretaria = objAuthenticatedUser;
                    }
                    catch (Exception)
                    {
                        ViewSecretaria.ObjSecretaria = null;
                    }
                }
                else
                {
                    ViewSecretaria.MensajeSecretaria("No Valido", 2);
                }
            }
            else
            {
                ViewSecretaria.MensajeSecretaria("No hay conexion en red", 1);
            }
        }
        #endregion
    }
}
