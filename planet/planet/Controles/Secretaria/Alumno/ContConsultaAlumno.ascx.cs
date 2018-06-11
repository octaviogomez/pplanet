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
    public partial class ContConsultaAlumno : System.Web.UI.UserControl,IAlumno
    {
        CAlumno ObjAlumno;
        WAlumno WAlumno;

        public GridViewRow FilaSeleccionada
        {
            get;
            private set;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ObjAlumno = new CAlumno();
            WAlumno = new WAlumno(this);

            WAlumno.ListadoAlumno(ObjAlumno,3);


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
                if (value!=null)
                {
                    GridViewReservacionCitas.DataSource = value;
                    GridViewReservacionCitas.DataBind();
                }
            }
        }

        public void MensajeAlumno(string Mensaje, int tipo)
        {
            
        }
        #endregion


        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            CRegistroCitas obj = new CRegistroCitas();


            string codigo = "";
            string nombre = "";

            FilaSeleccionada = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);

            codigo = (((Label)FilaSeleccionada.FindControl("LabelId")).Text);
            nombre = FilaSeleccionada.Cells[4].Text+" "+ FilaSeleccionada.Cells[5].Text;

          
           
            if (e.CommandName == "Baja")
            {
                LabelNombreAlumno.Text = nombre;
                TextBoxPkAlumno.Text = codigo;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script>$('#ModalEliminar').modal('show');</script>", false);
            }
            if (e.CommandName == "Consultar")
            {
          
                Response.Redirect("Perfil.aspx?id=" + codigo, true);//

            }


            FilaSeleccionada.Dispose();
        }

        protected void ButtonBajaAlumno_Click(object sender, EventArgs e)
        {
            CAlumno ob = new CAlumno();
            ob.pk_alumno = Convert.ToInt32(TextBoxPkAlumno.Text);
            WAlumno.AltaAlumno(ob, 4);
            WAlumno.ListadoAlumno(ObjAlumno, 3);

        }
    }
}