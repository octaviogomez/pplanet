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

namespace planet.Controles.Secretaria.Alumno
{
    public partial class ContAltaAlumno : System.Web.UI.UserControl,IAlumno
    {
        CAlumno ObjAlumno;
        WAlumno WAlumno;

        protected void Page_Load(object sender, EventArgs e)
        {
            ObjAlumno = new CAlumno();
            WAlumno = new WAlumno(this);
        }

      
        #region IALumno
        public CAlumno UsuarioLogeado
        {
            get
            {
                CAlumno obj = new CAlumno();
                try
                {
                    obj.id = Convert.ToInt32(TextBoxId.Text);
                    obj.clave = TextBoxPasswordUno.Text;
                    obj.correo = TextBoxCorreo.Text;
                    obj.nombre = TextBoxNombre.Text;
                    obj.apellidos = TextBoxApellidos.Text;
                    obj.estadoPago = (CheckBoxEstadoPago.Checked) ? 1 : 0;
                    obj.facebook = TextBoxFacebook.Text;
                    obj.celular = TextBoxCelular.Text;
                    obj.telefono = TextBoxTelefono.Text;
                    obj.sexo = RadioButtonListSexo.SelectedValue;
                    obj.direccion = TextBoxDireccion.Text;
                    obj.FechaNacimiento = TextBoxCumple.Text;
                }
                catch (Exception e)
                {
                    obj = null;
                    //activar via jquery notificacion
                }
                return obj;
            }

            set
            {
              
            }
        }

        public CAlumno UsuarioActulizar //objeto para alta y modificacion
        {
            get
            {
                CAlumno objAux = new CAlumno();
                try
                {
                    objAux.id = Convert.ToInt32(TextBoxId.Text);
                    objAux.clave = TextBoxPasswordDos.Text;
                    objAux.correo = TextBoxCorreo.Text;
                    objAux.nombre = TextBoxNombre.Text;
                    objAux.apellidos = TextBoxApellidos.Text;
                    objAux.estadoPago = (CheckBoxEstadoPago.Checked) ? 2 : 1;
                    objAux.facebook = TextBoxFacebook.Text;
                    objAux.telefono = TextBoxTelefono.Text;
                    objAux.celular = TextBoxCelular.Text;
                    objAux.sexo = RadioButtonListSexo.SelectedValue.ToUpper();
                    objAux.direccion = TextBoxDireccion.Text;
                    objAux.FechaNacimiento = TextBoxCumple.Text;
                }
                catch (Exception e) 
                {
                    MensajeAlumno("Revise que los datos sean los correctos",4);
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
            //activacion de elemenos via jquery 
        }
        #endregion

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            WAlumno.AltaAlumno(UsuarioActulizar, 2);
        }
    }
}