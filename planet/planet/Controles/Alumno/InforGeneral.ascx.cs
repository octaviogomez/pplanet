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
using System.Security.Policy;

namespace planet.Controles.Alumno
{
    public partial class InforGeneral : System.Web.UI.UserControl
    {

        CAlumno objLoggerinfAlumno;

        
        protected void Page_Load(object sender, EventArgs e)
        {
            objLoggerinfAlumno = (CAlumno)Session["AlumnoSesion"];
            LabelNombre.Text = objLoggerinfAlumno.nombre+ " "+objLoggerinfAlumno.apellidos;
            LabelClubs.Text = objLoggerinfAlumno.noClubs.ToString();
            LabelPeliculas.Text = objLoggerinfAlumno.noPelis.ToString();
            LabelNivel.Text = objLoggerinfAlumno.nivel.ToString();
        }
       
    }
}