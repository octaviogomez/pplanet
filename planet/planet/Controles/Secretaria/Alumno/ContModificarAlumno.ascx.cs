using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Core.Model;
using Core.Presenter;
using Core.View;
using System.Data;

namespace planet.Controles.Secretaria.Alumno
{
    public partial class ContModificarAlumno : System.Web.UI.UserControl, IAlumno
    {
        CAlumno ObjAlumno;
        WAlumno WAlumno;
        protected void Page_Load(object sender, EventArgs e)
        {
            ObjAlumno = new CAlumno();
            WAlumno = new WAlumno(this);


            if (!IsPostBack)
            {
                WAlumno.ListadoAlumno(UsuarioLogeado, 5);
            }

        }
        #region IAlumno
        public CAlumno UsuarioActulizar
        {
            get
            {
                CAlumno ObjAlumno = new CAlumno();
                try
                {
                    ObjAlumno.pk_alumno = Convert.ToInt32(TextBoxPkUsuario.Text.Trim());
                    ObjAlumno.id= Convert.ToInt32(TextBoxId.Text);
                    ObjAlumno.clave = TextBoxPassword.Text;
                    ObjAlumno.correo = TextBoxCorreo.Text;
                    ObjAlumno.nombre= TextBoxNombre.Text ;
                    ObjAlumno.apellidos= TextBoxApellidos.Text ;
                    ObjAlumno.anioEgreso = TextBoxAnioEgreso.Text;
                    ObjAlumno.estadoPago = (CheckBoxEstadoPago.Checked) ? 1 : 0;
                    ObjAlumno.facebook= TextBoxFacebook.Text;
                    ObjAlumno.telefono= TextBoxTelefono.Text;
                    ObjAlumno.celular=TextBoxCelular.Text;
                    ObjAlumno.sexo=RadioButtonListSexo.SelectedValue;//no se modifica
                    ObjAlumno.nivel= Convert.ToInt32(DropDownListNivel.SelectedValue) ;
                    ObjAlumno.direccion=TextBoxDireccion.Text ;
                    ObjAlumno.FechaNacimiento=TextBoxCumple.Text;

                }
                catch (Exception)
                {
                    ObjAlumno = null;
                }

                return ObjAlumno;
            }

            set
            {

            }
        }

        public CAlumno UsuarioLogeado
        {
            get
            {
                CAlumno obj = new CAlumno();
                try
                {

                    obj.pk_alumno = (Request.QueryString["id"].ToString() != null) ? Convert.ToInt32(Request.QueryString["id"].ToString()) : 0;
                    
                }
                catch (Exception)
                {

                    obj.pk_alumno = 0;

                }
                return obj;
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
                if (value != null)
                {
                    try
                    {
                        TextBoxPkUsuario.Text = value.Tables[0].Rows[0][0].ToString();//oculto
                        TextBoxId.Text = value.Tables[0].Rows[0][2].ToString();
                        TextBoxPassword.Text = value.Tables[0].Rows[0][3].ToString();
                        TextBoxCorreo.Text = value.Tables[0].Rows[0][5].ToString();
                        TextBoxNombre.Text = value.Tables[0].Rows[0][6].ToString();
                        TextBoxApellidos.Text = value.Tables[0].Rows[0][7].ToString();
                        TextBoxAnioIngreso.Text = value.Tables[0].Rows[0][8].ToString();//No se modifica
                        TextBoxAnioEgreso.Text = value.Tables[0].Rows[0][9].ToString();
                        CheckBoxEstadoPago.Checked = (value.Tables[0].Rows[0][10].ToString() == "1") ? false : true;
                        TextBoxFacebook.Text = value.Tables[0].Rows[0][11].ToString();
                        TextBoxTelefono.Text = value.Tables[0].Rows[0][12].ToString();
                        TextBoxCelular.Text = value.Tables[0].Rows[0][13].ToString();
                        RadioButtonListSexo.SelectedValue = value.Tables[0].Rows[0][14].ToString();//no se modifica
                        DropDownListNivel.SelectedValue = value.Tables[0].Rows[0][16].ToString();
                        TextBoxDireccion.Text = value.Tables[0].Rows[0][17].ToString();
                        TextBoxClubs.Text = value.Tables[0].Rows[0][18].ToString();
                        TextBoxPelis.Text = value.Tables[0].Rows[0][19].ToString();

                        string a = value.Tables[0].Rows[0][20].ToString();
                        TextBoxCumple.Attributes.Add("value", value.Tables[0].Rows[0][20].ToString());


                    }
                    catch (Exception)
                    {



                    }
                }
                else
                {

                }
            }
        }

        public void MensajeAlumno(string Mensaje, int tipo)
        {
            switch (tipo)
            {
                case 1:
                    break;
                case 5:
                    PanelError.Visible = true;
                    break;
                case 6:
                    PanelAviso.Visible = true;
                    break;
                default:
                    break;
            }

        }
        #endregion
        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (UsuarioActulizar!=null)
            {
                WAlumno.ModificacionAlumno(UsuarioActulizar,6);
            }
        }
    }
}