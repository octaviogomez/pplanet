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

namespace planet
{
    public partial class Default : System.Web.UI.Page, IAlumno, ISecretaria, ICombo
    {
        private CAlumno objLoggerinfAlumno;//Objeto donde estara la informacion de logeo temporal
        private WAlumno WAlumnoVista;

        private CSecretaria objLoggerinfSecretaria;
        private WSecretaria WSecreatriaVista;


        private WCombo Wcombo;
        private List<CCombo> listaDatos = new List<CCombo>();

        protected void Page_Load(object sender, EventArgs e)
        {


            Session.RemoveAll();
            Wcombo = new WCombo(this);//Hacer uso de metodos del combo
            WAlumnoVista = new WAlumno(this);
            WSecreatriaVista = new WSecretaria(this);

            if (!IsPostBack)
            {
                LlenadoComboGenerico(DropDownListRol, 1, "ListadoCatalogos");
            }
        }


        #region IAlumno     
        public CAlumno UsuarioLogeado
        {
            get
            {
                this.objLoggerinfAlumno = new CAlumno();
               
                try
                {
                    this.objLoggerinfAlumno.pk_alumno = Convert.ToInt32(TextBoxNumeroDeControl.Text.Trim());
                    this.objLoggerinfAlumno.clave = TextBoxContrasena.Text.Trim();
                }
                catch (Exception)
                {

                    this.objLoggerinfAlumno = null; ;
                }
                return this.objLoggerinfAlumno;
            }
            set
            {
                this.objLoggerinfAlumno = null;
                if (value != null)
                {
                    this.objLoggerinfAlumno = value;
                }
            }
        }
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
            //
        }


        #endregion
        #region ISecretaria
        public CSecretaria ObjSecretaria
        {
            get
            {
                objLoggerinfSecretaria = new CSecretaria();
                try
                {
                    objLoggerinfSecretaria.pk_secreatria = Convert.ToInt32(TextBoxNumeroDeControl.Text.Trim());
                    objLoggerinfSecretaria.clave = TextBoxContrasena.Text.Trim();
                }
                catch (Exception)
                {
                    objLoggerinfSecretaria = null;
                }

                return objLoggerinfSecretaria;
            }

            set
            {
                objLoggerinfSecretaria = null;
                if (value != null)
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
                    listaDatos = value;      
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
                    if (UsuarioLogeado!=null)
                    {

                        WAlumnoVista.ValidarAlumno(1, UsuarioLogeado);

                        if (objLoggerinfAlumno != null)
                        {
                            Session.Add("AlumnoSesion", objLoggerinfAlumno);//Creamos la variable de sesion en donde la podremos utlizar cuando nos mande a la master
                            Response.Redirect("/Paginas/Alumno/Default.aspx", true);// no direcciona a la pagina default de la master
                        }
                    }

                    break;

                case "3":
                    if (ObjSecretaria != null)
                    {
                        WSecreatriaVista.ValidarSecretaria(1, ObjSecretaria);
                        if (objLoggerinfSecretaria != null)
                        {
                            Session.Add("SecretariaSesion", objLoggerinfSecretaria);//Creamos la variable de sesion en donde la podremos utlizar cuando nos mande a la master
                            Response.Redirect("/Paginas/Secretaria/Default.aspx", true);// no direcciona a la pagina default de la master
                        }
                    }
                    else {
                        //via jquey mensaje
                    }
                    break;

                default:
                    break;
            }
        }
        #endregion
    }
}