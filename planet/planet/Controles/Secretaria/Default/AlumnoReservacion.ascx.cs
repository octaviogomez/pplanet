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

namespace planet.Controles.Secretaria.Default
{
    public partial class AlumnoReservacion : System.Web.UI.UserControl, IRegistroCitas
    {

        WCombo Wcombo;
        List<CCombo> listaDatos = new List<CCombo>();

        CRegistroCitas ObjRegistroCitas;
        WRegistroCitas WRegistroCitas;

        public GridViewRow FilaSeleccionada
        {
            get;
            private set;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ObjRegistroCitas = new CRegistroCitas();
            WRegistroCitas = new WRegistroCitas(this);
      
            if (!IsPostBack)
            {

               
                WRegistroCitas.ListadoDeCitas(ObjRegistroCitasAux, 9);
            }
        }
        #region IRegistroCitas
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
                    GridViewReservacionCitas.DataSource = value;
                    GridViewReservacionCitas.DataBind();

                    try
                    {


                        string estado = "";

                        int x = 0;
                        foreach (DataRow row in value.Tables[0].Rows)
                        {
                            estado = Convert.ToString(row[8]);
                            switch (estado)
                            {
                                case "Activo":
                                    // GridViewReservacionCitas.Rows[x].Cells[7].CssClass = "alert alert-danger";
                                    GridViewReservacionCitas.Rows[x].Cells[11].ForeColor = System.Drawing.Color.Green;
                                    break;
                                case "Cancelado":
                                    // GridViewReservacionCitas.Rows[x].Cells[7].CssClass = "alert alert-danger";
                                    GridViewReservacionCitas.Rows[x].Cells[11].ForeColor = System.Drawing.Color.Red;

                                    GridViewReservacionCitas.Rows[x].Cells[12].Enabled = false;
                                    GridViewReservacionCitas.Rows[x].Cells[1].Enabled = false;
                                    GridViewReservacionCitas.Rows[x].Cells[2].Enabled = false;
                                    GridViewReservacionCitas.Rows[x].Cells[3].Enabled = false;



                                    break;
                                case "Falta":
                                    // GridViewReservacionCitas.Rows[x].Cells[7].CssClass = "alert alert-danger";
                                    GridViewReservacionCitas.Rows[x].Cells[11].ForeColor = System.Drawing.Color.Purple;
                                    GridViewReservacionCitas.Rows[x].Cells[12].Enabled = false;
                                    GridViewReservacionCitas.Rows[x].Cells[1].Enabled = false;
                                    GridViewReservacionCitas.Rows[x].Cells[2].Enabled = false;
                                    GridViewReservacionCitas.Rows[x].Cells[3].Enabled = false;

                                    break;
                                case "Retardo":
                                    // GridViewReservacionCitas.Rows[x].Cells[7].CssClass = "alert alert-danger";
                                    GridViewReservacionCitas.Rows[x].Cells[11].ForeColor = System.Drawing.Color.Blue;
                                    GridViewReservacionCitas.Rows[x].Cells[12].Enabled = false;
                                    GridViewReservacionCitas.Rows[x].Cells[1].Enabled = false;
                                    GridViewReservacionCitas.Rows[x].Cells[2].Enabled = false;
                                    GridViewReservacionCitas.Rows[x].Cells[3].Enabled = false;

                                    break;
                                default:
                                    break;
                            }






                            x++;
                        }
                    }
                    catch (Exception)
                    {


                    }
                }
            }
        }

        public DataSet ListadoDtAux
        {
            get
            {
                return null;
            }

            set
            {

            }
        }

        public CRegistroCitas ObjRegistroCitasAux
        {
            get
            {
                CRegistroCitas obj = new CRegistroCitas();
                obj.fecha= DateTime.Now.ToShortDateString();
                obj.fk_hora = DateTime.Now.Hour;
    
                return obj;
            }

            set
            {

            }
        }

        public CRegistroCitas ObjRegistroRegistroCitas
        {
            get
            {
                CRegistroCitas obj = new CRegistroCitas();
    
                return obj;
            }
            set
            {

            }
        }

        public void Mensaje(string Mensaje, int tipo)
        {

        }
        #endregion
     

        #region General events
        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            CRegistroCitas obj = new CRegistroCitas();


            string codigo = "";
            string nombre = "";

            FilaSeleccionada = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);

            codigo = (((Label)FilaSeleccionada.FindControl("LabelId")).Text);
            nombre = FilaSeleccionada.Cells[5].Text;

            if (e.CommandName == "Cancelar")
            {
                obj.estadoReservacion = 2;
                obj.pk_registroCita = Convert.ToInt32(codigo);
                WRegistroCitas.CambioEstadoReservacion(obj, 7);
                Response.Redirect(Request.RawUrl);
            }
            if (e.CommandName == "Falta")
            {
                obj.estadoReservacion = 3;
                obj.pk_registroCita = Convert.ToInt32(codigo);
                WRegistroCitas.CambioEstadoReservacion(obj, 7);
                Response.Redirect(Request.RawUrl);
            }
            if (e.CommandName == "Retardo")
            {
                obj.estadoReservacion = 4;
                obj.pk_registroCita = Convert.ToInt32(codigo);
                WRegistroCitas.CambioEstadoReservacion(obj, 7);
                Response.Redirect(Request.RawUrl);

            }
            if (e.CommandName == "Eliminar")
            {
                LabelNombreAlumno.Text = nombre;
                TextBoxPkReservacion.Text = codigo;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script>$('#ModalEliminar').modal('show');</script>", false);
            }


            FilaSeleccionada.Dispose();
        }
       

        protected void ButtonEliminarCita_Click(object sender, EventArgs e)
        {

            CRegistroCitas obj = new CRegistroCitas();
            obj.pk_registroCita = Convert.ToInt32(TextBoxPkReservacion.Text);
            WRegistroCitas.CambioEstadoReservacion(obj, 8);
            Response.Redirect(Request.RawUrl);
        }
        #endregion

    }
}