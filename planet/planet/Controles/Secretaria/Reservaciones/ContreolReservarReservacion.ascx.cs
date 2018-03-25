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

            //   wRegistroCitas.ListadoDeCitas(ObjRegistroCitasAux, 3);


            //  wRegistroCitas.RegistroCita(ObjRegistroCitasAux, 3);

            //   Response.Redirect(Request.RawUrl);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalView", "<script>    $('#ModalAlumnoFaltas').modal('show');</script>", false);

        }


        #endregion


    }
}