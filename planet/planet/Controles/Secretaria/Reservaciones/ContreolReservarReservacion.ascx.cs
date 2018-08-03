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
    public partial class ContreolReservarReservacion : System.Web.UI.UserControl, ICombo, IRegistroCitas
    {

        /*
         Tipos de mensajes para el metodo implementado
          del  
          5:
                        Se hace un registro de la cita
               6 SE manda mensaje de error
             */
        WCombo Wcombo;
        List<CCombo> listaDatos = new List<CCombo>();

        WRegistroCitas wRegistroCitas;
        CRegistroCitas cRegistroCitas;


        public GridViewRow FilaSeleccionada
        {
            get;
            private set;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Wcombo = new WCombo(this);//Hacer uso de metodos del combo


            wRegistroCitas = new WRegistroCitas(this);
            cRegistroCitas = new CRegistroCitas();

            if (!IsPostBack)
            {
               

                LlenadoComboGenerico(DropDownListTipoCita, 3, "ListadoCatalogos");
                LlenadoComboGenerico(DropDownListTipoLeccion, 4, "ListadoCatalogos");
                LlenadoComboGenerico(DropDownListHorarios, 2, "ListadoCatalogos");
                wRegistroCitas.ListadoDeCitas(cRegistroCitas, 1);
            }

        }
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
                    GridViewCitas.DataSource = value;
                    GridViewCitas.DataBind();

                    try
                    {


                        int? Espacios =null;
                        int? Alumno = null;
                        int x = 0;
                        foreach (DataRow row in value.Tables[0].Rows)
                        {
                            Espacios = (int?)Convert.ToInt32(row[6]);
                            Alumno = (int?)Convert.ToInt32(row[7]);

                            if (Espacios <= 0 || Espacios == null)
                                GridViewCitas.Rows[x].Cells[7].CssClass = "alert alert-danger";
                            if (Alumno >= 6 )
                                GridViewCitas.Rows[x].Cells[8].CssClass = "alert alert-warning";

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
                ;
            }
        }   
        public CRegistroCitas ObjRegistroCitasAux
        {
            get
            {
                CRegistroCitas obj = new CRegistroCitas();
                try
                {
                    obj.fk_cita = Convert.ToInt32(TextBoxIdCita.Text);
                    obj.fk_alumno = Convert.ToInt32(TextBoxIdAlumno.Text);
                    obj.fk_tipoCitas = Convert.ToInt32(DropDownListTipoCita.SelectedValue);
                    obj.fk_lecciones = Convert.ToInt32(DropDownListTipoLeccion.SelectedValue);
                }
                catch (Exception e)
                {
                    obj = null;
                   
                }
                return obj;
            }

            set
            {

            }
        } // objeto que encapsula las propiedades de la cita para poder generar el registro
        public CRegistroCitas ObjRegistroRegistroCitas
        {
            get
            {
                CRegistroCitas obj = new CRegistroCitas();
                try
                {
                    obj.fecha = TextBoxFecha.Text;
                }
                catch (Exception e)
                {
                    obj.fecha = DateTime.Now.ToShortDateString();

                }

                return obj;
            }

            set
            {

            }
        }   // objeto que encapsula las propiedades para hacer un listado
        public void Mensaje(string Mensaje, int tipo)
        {
            switch (tipo)
            {
        
                case 5:
                    wRegistroCitas.RegistroCita(ObjRegistroCitasAux, 3);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script> $('#Notificacion').modal('show');</script>", false);


                    break;
                case 6:
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script> $('#ModalAlumnoFaltas').modal('show');</script>", false);
                    break;
                case 7:
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script> $('#NotificacionError').modal('show');</script>", false);
                    break;

                default:
                    break;
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

        #region Eventos 
        protected void ButtonBuscarFecha_Click(object sender, EventArgs e)//buscar fechar con el boton
        {
            wRegistroCitas.ListadoDeCitas(ObjRegistroRegistroCitas, 2);
        }
        protected void TextBoxFecha_TextChanged(object sender, EventArgs e)//buscar fechas sin boton
        {
            wRegistroCitas.ListadoDeCitas(ObjRegistroRegistroCitas, 2);
        }

        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            string codigo = "";
            FilaSeleccionada = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);

            foreach (GridViewRow row in GridViewCitas.Rows)//Se realiza un recorrido de la tabla
            {
                for (int i = 1; i <= FilaSeleccionada.Cells.Count - 1; i++) //se hace un recorrido de 1 al tamaño de las columnas 
                {
                    GridViewCitas.Rows[row.RowIndex].Cells[i].CssClass = ""; // row.RowIndex obtiene el indice de la fila
                    if (FilaSeleccionada.RowIndex== row.RowIndex)            // si al recorrer la tabla coincide con el seleccionado se marca 
                        GridViewCitas.Rows[FilaSeleccionada.RowIndex].Cells[i].CssClass = "alert alert-info";//FilaSeleccionada.RowIndex -> es el indice (posision) del elemento seleccionado
                }
            }
            if (e.CommandName == "seleccion")
            {
                codigo = (((Label)FilaSeleccionada.FindControl("LabelId")).Text);
                TextBoxIdCita.Text = codigo;
                TextBoxIdCita.CssClass = "form-control is-valid";
            }
        

            FilaSeleccionada.Dispose();
        }


        protected void ButtonCrear_Click(object sender, EventArgs e)
        {
            //Verificar las faltas
            /*
             El alumno tiene 6 creditos
             los cuales estan repartidos de la siguiente manera
             1 falta =3
             1 cancelacion =2
             6 es el limite
             */
            if (TextBoxIdCita.Text!=null && TextBoxIdCita.Text != "")
            {
                wRegistroCitas.FaltasDeAlumno(ObjRegistroCitasAux, 4);
            }
            else {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script> $('#NotificacionError').modal('show');</script>", false);
            }
            
       
        }

        protected void ButtonRegistrarAlumoFalta_Click(object sender, EventArgs e)
        {
            wRegistroCitas.RegistroCita(ObjRegistroCitasAux, 3);
            Response.Redirect(Request.RawUrl);
        }
        protected void ButtonActualizarPagina_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }

        #endregion


    }
}