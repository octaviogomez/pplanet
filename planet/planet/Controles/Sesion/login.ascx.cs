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
    public partial class login : System.Web.UI.UserControl,IAlumno,ISecretaria,ICombo
    {
        CAlumno objLoggerinfAlumno;//Objeto donde estara la informacion de logeo temporal
        WAlumno WAlumnoVista;//Objeto para poder ocupar los metodos de la wAlumno

        CSecretaria objLoggerinfSecretaria;
        WSecretaria WSecreatriaVista;


        WCombo Wcombo;
        List<CCombo> listaDatos = new List<CCombo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session.RemoveAll();//Limpiamos sesiones

            Wcombo = new WCombo(this);//Hacer uso de metodos del combo



            WAlumnoVista = new WAlumno(this);
            objLoggerinfAlumno = new CAlumno();


            objLoggerinfSecretaria = new CSecretaria() ;
             WSecreatriaVista =new WSecretaria(this);

            if (!IsPostBack)
            {
                LlenadoComboGenerico(DropDownListRol, 1, "ListadoCatalogos");
            }
           
        }

        #region IAlumno
        public CAlumno UsuarioActulizar
        {
            get
            {
                return null;
            }

            set
            {

            }
        }

        public CAlumno UsuarioLogeado
        {
            get
            {
                CAlumno AlumnoReturn = new CAlumno();
               
                    AlumnoReturn.rol =Convert.ToInt32(DropDownListRol.SelectedValue);
                    AlumnoReturn.id = Convert.ToInt32(TextBoxClave.Text.Trim());
                    AlumnoReturn.clave = TextBoxClave.Text.Trim();
              
                return AlumnoReturn;
            }
            set
            {
                objLoggerinfAlumno = null;
                if (value!=null)
                {
                    objLoggerinfAlumno = value;
                }
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
            
        }

      
        #endregion
        #region ISecretaria
        public CSecretaria ObjSecretaria
        {
            get
            {
                CSecretaria SecretariaReturn = new CSecretaria();

                SecretariaReturn.rol = Convert.ToInt32(DropDownListRol.SelectedValue);
                SecretariaReturn.id = Convert.ToInt32(TextBoxClave.Text.Trim());
                SecretariaReturn.clave = TextBoxClave.Text.Trim();

                return SecretariaReturn;
            }

            set
            {
                objLoggerinfSecretaria = null;
                if (value!=null)
                {
                    objLoggerinfSecretaria = value;
                }
            }
        }

        public CSecretaria ObjSecretariaAux
        {
            get
            {
                return null;
            }

            set
            {
               
            }
        }

        public DataSet SecretariaDt
        {
            get
            {
                return null;
            }

            set
            {
        
            }
        }

 

        public void MensajeSecretaria(string Mensaje, int tipo)
        {
            
        }
        #endregion
        #region ICombo
        public List<CCombo> LlenarCombo
        {
            get
            {
                return listaDatos;
            }

            set
            {
                if (value != null)
                { listaDatos = value; }
            }
        }
        #endregion

        #region Metodos Combo
        private void LlenadoComboGenerico(DropDownList Combo, int Opcion, string procedimiento)
        {
            Wcombo.ListarDatos(Opcion, procedimiento);/// se implementa el llenado de la interfaz
            if (listaDatos != null)
            {
                foreach (CCombo item in listaDatos)
                {
                    Combo.Items.Add(new System.Web.UI.WebControls.ListItem(item.Descripcion, item.Id.ToString()));
                }
            }
        }
        #endregion

        #region Eventos de botones
        protected void Buttoniniciar_Click(object sender, EventArgs e)
        {


            switch (DropDownListRol.SelectedValue)
            {
                case "1":
                    WAlumnoVista.ValidarAlumno(1, UsuarioLogeado);
                    if (UsuarioLogeado != null)
                    {
                       
                        Session.Add("AlumnoSesion", objLoggerinfAlumno);//Creamos la variable de sesion en donde la podremos utlizar cuando nos mande a la master
                        Response.Redirect("/Paginas/Alumno/Default.aspx", true);// no direcciona a la pagina default de la master
                    }
                    break;
                case "3":
                    WSecreatriaVista.ValidarSecretaria(1, ObjSecretaria);
                    if (objLoggerinfSecretaria != null)
                    {
                        Session.Clear();// limpiamos la sesion
                        Session.Add("SecretariaSesion", objLoggerinfSecretaria);//Creamos la variable de sesion en donde la podremos utlizar cuando nos mande a la master
                        Response.Redirect("/Paginas/Secretaria/Default.aspx", true);// no direcciona a la pagina default de la master
                    }
                    break;

                default:
                    break;
            }
        }
        #endregion
    }
}