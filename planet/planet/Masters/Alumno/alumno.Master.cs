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

namespace planet.Masters.alumno
{
    public partial class alumno : System.Web.UI.MasterPage,IAlumno
    {
        CAlumno objLoggerdUser;
        WAlumno objWAlumno;



        protected void Page_Load(object sender, EventArgs e)
        {
            objWAlumno = new WAlumno(this);
            objLoggerdUser = (CAlumno)Session["AlumnoSesion"];
            if (objLoggerdUser != null)
            {

            }
            else {
                this.Visible = false;
                Response.Redirect("../../Sesion.aspx", true);
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
            
        }
        #endregion
    }
}