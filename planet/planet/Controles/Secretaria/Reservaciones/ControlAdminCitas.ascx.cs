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


namespace planet.Controles.Secretaria.Reservaciones
{
    public partial class ControlAdminCitas : System.Web.UI.UserControl,  ICitas
    {
       
      
        CCitas ObjCitas;//Objeto donde estara la informacion de logeo temporal
        WCitas WCitas;//meotodo para poder ocupar los metodos de la wAlumno


        protected void Page_Load(object sender, EventArgs e)
        {
            ObjCitas = new CCitas();
            WCitas = new WCitas(this);
       

            if (!IsPostBack)
            {
                WCitas.ListadoDeCitas(ObjetoCitasAux, 2);//Listado generico de citas, solo muestra las del dia de hoy 
               
            }

        }
        public GridViewRow FilaSeleccionada
        {
            get;
            private set;
        }

        #region ICitas
        public CCitas ObjetoCitas
        {
            get
            {
                CCitas CitasReturn = new CCitas();
                try
                {
                    CitasReturn.pk_cita = Convert.ToInt32(TextBoxPkCita.Text); 
                }
                catch (Exception e)
                {
                }
                return CitasReturn;
            }

            set
            {

            }
        }

        public CCitas ObjetoCitasAux
        {
            get
            {
                CCitas CitasReturn = new CCitas();
                CitasReturn.fecha = TextBoxFecha.Text;
                CitasReturn.fk_hora = 0;
                return CitasReturn;
            }

            set
            {

            }
        }

        public DataSet ListadoDt
        {
            get
            {
                return null;
            }

            set
            {
                if (value != null)
                {
                    GridViewCitas.DataSource = value;
                    GridViewCitas.DataBind();
                }

            }
        }

        public DataSet ListadoEsp
        {
            get
            {
                return null;
            }

            set
            {
              

            }
        }
        public void Mensaje(string Mensaje, int tipo)
        {
            PanelAvisoCorrecto.Visible = false;
            PanelAvisoError.Visible = false;

            switch (tipo)
            {
                case 1:
                    PanelAvisoCorrecto.Visible = true;
                    break;
                case 2:
                    PanelAvisoError.Visible = true;
                    break;
                default:
                    PanelAvisoCorrecto.Visible = false;
                    PanelAvisoError.Visible = false;
                    break;
            }
        }
        #endregion

        #region Evento Boton
        protected void ButtonCrear_Click(object sender, EventArgs e)// Ver citas con el boton
        {
            WCitas.ListadoDeCitas(ObjetoCitasAux, 3);
        }
        protected void TextBoxFecha_TextChanged(object sender, EventArgs e)// citas automatico
        {
            WCitas.ListadoDeCitas(ObjetoCitasAux, 3);
        }
        protected void Button1_Click(object sender, EventArgs e)//eliminar una cita
        {
            WCitas.EliminarCita(4, ObjetoCitas);
            Response.Redirect(Request.RawUrl);
        }

        #endregion
        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            FilaSeleccionada = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Eliminar")
            {
                TextBoxPkCita.Text   = (((Label)FilaSeleccionada.FindControl("LabelId")).Text);// 
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script>$('#ModalModificarFormapago').modal('show');</script>", false);
            }
            FilaSeleccionada.Dispose();
        }

      
    }
}