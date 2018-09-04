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

        #region Metodo de logeo
        public void ValidarAlumno(int opcion, CAlumno AlumnoIngresado)
        {
            DataSet datLoggerUserInformation = new DataSet();
            CAlumno objAuthenticatedUser = new CAlumno();
            bool ExisteUsuario = false;

            if (ExisteConexion())
            {
                ExisteUsuario = objAuthenticatedUser.AutentificarAlumno(opcion, ref datLoggerUserInformation, AlumnoIngresado);
                if (ExisteUsuario)
                {
                    try
                    {
                        objAuthenticatedUser.pk_alumno = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][0].ToString());
                        objAuthenticatedUser.rol = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][1].ToString());
                        objAuthenticatedUser.id = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][2].ToString());
                        objAuthenticatedUser.clave = datLoggerUserInformation.Tables[0].Rows[0][3].ToString();
                        objAuthenticatedUser.activo = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][4].ToString());
                        objAuthenticatedUser.correo = datLoggerUserInformation.Tables[0].Rows[0][5].ToString();
                        objAuthenticatedUser.nombre = datLoggerUserInformation.Tables[0].Rows[0][6].ToString();
                        objAuthenticatedUser.apellidos = datLoggerUserInformation.Tables[0].Rows[0][7].ToString();
                        objAuthenticatedUser.anioIngreso = datLoggerUserInformation.Tables[0].Rows[0][8].ToString();
                        objAuthenticatedUser.anioEgreso = datLoggerUserInformation.Tables[0].Rows[0][9].ToString();
                        objAuthenticatedUser.estadoPago = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][10].ToString());
                        objAuthenticatedUser.facebook = datLoggerUserInformation.Tables[0].Rows[0][11].ToString();
                        objAuthenticatedUser.telefono = datLoggerUserInformation.Tables[0].Rows[0][12].ToString();
                        objAuthenticatedUser.celular = datLoggerUserInformation.Tables[0].Rows[0][13].ToString();
                        objAuthenticatedUser.sexo = datLoggerUserInformation.Tables[0].Rows[0][14].ToString();
                        objAuthenticatedUser.edad = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][15].ToString());
                        objAuthenticatedUser.nivel = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][16].ToString());
                        objAuthenticatedUser.direccion = datLoggerUserInformation.Tables[0].Rows[0][17].ToString();
                        objAuthenticatedUser.noClubs = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][18].ToString());
                        objAuthenticatedUser.noPelis = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][19].ToString());
                        objAuthenticatedUser.FechaNacimiento =datLoggerUserInformation.Tables[0].Rows[0][20].ToString();
         
                        ViewAlumno.UsuarioLogeado = objAuthenticatedUser;
                    }
                    catch (Exception)
                    {
                        ViewAlumno.UsuarioLogeado = null;
                    }
                }
                else
                {
                    ViewAlumno.MensajeAlumno("Datos no validos", 2);
                }
            }
            else
            {
                ViewAlumno.MensajeAlumno("No hay conexión en red", 1);
            }
        }
        #endregion

        #region Crud alumno
        /// <summary>
        /// De de alta a un alumno
        /// </summary>
        /// <param name="objAlum"></param>
        /// <param name="opcion"></param>
        public void AltaAlumno(CAlumno objAlum, int opcion)
        {
            bool BolRegistro = false;
            CAlumno objAlumno = new CAlumno();

            if (ExisteConexion())
            {
                BolRegistro = objAlumno.CreateAlumno(opcion, objAlum);

                if (BolRegistro == true)
                {
                    ViewAlumno.MensajeAlumno("Registo exitoso", 3);
                }
                else
                {

                    ViewAlumno.MensajeAlumno("No se pudo registrar el usuario, revise bien sus datos.", 2);
                }
            }
            else {
                ViewAlumno.MensajeAlumno("No hay conexión en red", 1);
            }
        }
        #endregion
        /// <summary>
        /// Listado generico del alumno, respecto a la opcion del procedimiento
        /// </summary>
        /// <param name="objCita"></param>
        /// <param name="opcion"></param>
        public void ListadoAlumno(CAlumno objCita, int opcion)
        {
            DataSet dtsDatos = new DataSet();
            CAlumno objaux = new CAlumno();
            bool BolRegistro = false;
            if (ExisteConexion())
            {
                BolRegistro = objaux.ListarAlumno(opcion, objCita, ref dtsDatos);

                if (BolRegistro == true)
                {
                     ViewAlumno.UsuariosDt = dtsDatos;

                    ViewAlumno.MensajeAlumno("Lisatado correcto", 3);
                }
                else
                {
                    ViewAlumno.MensajeAlumno("Sin resultados ", 2);
                }
            }
            else {
                ViewAlumno.MensajeAlumno("Error no se pudieron listar, error de conexión en la base de datos", 1);
            }
        }

    }
}
