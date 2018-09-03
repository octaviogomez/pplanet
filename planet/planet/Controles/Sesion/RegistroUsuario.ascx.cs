using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using Core.Model;
using Core.Presenter;
using Core.View;

namespace planet.Controles.Sesion
{
    public partial class RegistroUsuario : System.Web.UI.UserControl,IAlumno
    {

     
        WAlumno WAlumno;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            WAlumno = new WAlumno(this);

        }




        #region IAlumno
        public CAlumno UsuarioLogeado
        {
            get
            {
                return null;
            }

            set
            {
                
            }
        }

        public CAlumno UsuarioActulizar
        {
            get
            {
                CAlumno objAux = new CAlumno();
                try
                {
                    objAux.clave = TextBoxAlumnoClave.Text.Trim();
                    objAux.correo = (!string.IsNullOrWhiteSpace(TextBoxAlumnoCorreo.Text)) ? TextBoxAlumnoCorreo.Text : "0";
                    objAux.nombre = TextBoxAlumnoNombre.Text;
                    objAux.apellidos = TextBoxAlumnoApellidos.Text;
                    objAux.sexo = GeneroList.SelectedValue;
                    objAux.FechaNacimiento = Convert.ToDateTime(TextBoxCumple.Text).ToShortDateString();

                }
                catch (Exception ex)
                {
                    MensajeAlumno("Revise que los datos sean los correctos", 4);
                }

                return objAux;
            }

            set
            {
             
            }
        }

        public DataSet UsuariosDt
        {
            get
            {
                return null;
            }

            set
            {
               
            }
        }

        public void MensajeAlumno(string Mensaje, int tipo)
        {
            switch (tipo)
            {
                default:
                    Response.Redirect(Request.RawUrl);
                    break;
            }
        }
        #endregion



        protected void LinkButtonGuardarAlumo_Click(object sender, EventArgs e)
        {
            if (UsuarioActulizar!=null)
            {
                WAlumno.AltaAlumno( UsuarioActulizar,2);
            }
        }
    }
}