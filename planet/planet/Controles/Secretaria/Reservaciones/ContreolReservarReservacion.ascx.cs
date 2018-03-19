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

        protected void Page_Load(object sender, EventArgs e)
        {
            Wcombo = new WCombo(this);//Hacer uso de metodos del combo


            wRegistroCitas = new WRegistroCitas(this);
            cRegistroCitas = new CRegistroCitas();

            if (!IsPostBack)
            {
                LlenadoComboGenerico(DropDownListTipoCita, 3, "ListadoCatalogos");
                LlenadoComboGenerico(DropDownListTipoLeccion, 4, "ListadoCatalogos");
                wRegistroCitas.ListadoDeCitas(ObjRegistroRegistroCitas, 1);
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
                if (value!=null)
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
                return null;
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
                try
                {
                    //obj.fecha = DateTime.Now.ToShortDateString();
                    obj.fecha = (TextBoxFecha.Text!="")? "2018/03/19":TextBoxFecha.Text;
                }
                catch (Exception)
                {
                    obj.fecha = "2000/01/01";

                }

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
      
    }
}