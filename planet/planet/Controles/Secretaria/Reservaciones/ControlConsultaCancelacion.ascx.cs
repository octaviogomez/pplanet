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
    public partial class ControlConsultaCancelacion : System.Web.UI.UserControl,IRegistroCitas,ICombo
    {

        WCombo Wcombo;
        List<CCombo> listaDatos = new List<CCombo>();

        CRegistroCitas ObjRegistroCitas;
        WRegistroCitas WRegistroCitas;

        protected void Page_Load(object sender, EventArgs e)
        {
            ObjRegistroCitas = new CRegistroCitas();
            WRegistroCitas = new WRegistroCitas(this);
            Wcombo = new WCombo(this);
            if (!IsPostBack)
            {
                WRegistroCitas.ListadoDeCitas(ObjRegistroCitasAux,5);
                LlenadoCombo(DropDownListHorarios, 2, "ListadoCatalogos");
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
                if (value!=null)
                {
                    GridViewReservacionCitas.DataSource = value;
                    GridViewReservacionCitas.DataBind();
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
                obj.fecha = DateTime.Now.ToShortDateString();
                obj.fk_hora = 0;
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
                obj.fecha = TextBoxFecha.Text;
                obj.fk_hora = Convert.ToInt32(DropDownListHorarios.SelectedValue);
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

        #region iCombo
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
        private void LlenadoCombo(DropDownList Combo, int Opcion, string procedimiento)
        {
            Combo.Items.Clear();// limpiamos combo

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

        #region Eventos de la tabla
        protected void LinkButtonCancelar_Click(object sender, EventArgs e)
        {

        }
        protected void LinkButtonFalta_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButtonRetardo_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButtonEliminar_Click(object sender, EventArgs e)
        {

        }



        #endregion
        #region General events
        protected void ButtonBuscarFecha_Click(object sender, EventArgs e)
        {
            WRegistroCitas.ListadoDeCitas(ObjRegistroCitasAux, 5);
        }
        #endregion

    }
}