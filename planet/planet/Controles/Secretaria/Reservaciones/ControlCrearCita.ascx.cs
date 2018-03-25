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
    public partial class ControlCrearCita : System.Web.UI.UserControl,ICombo,ICitas
    {
        WCombo Wcombo;
        List<CCombo> listaDatos = new List<CCombo>();

        CCitas ObjCitas;
        WCitas WCitas;


        protected void Page_Load(object sender, EventArgs e)
        {
            ObjCitas = new CCitas();
            WCitas = new WCitas(this);
            Wcombo = new WCombo(this);//Hacer uso de metodos del combo
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
        #region ICitas
        public CCitas ObjetoCitas
        {
            get
            {
                CCitas CitasReturn = new CCitas();
                try
                {
                    CitasReturn.estado = 1; //Activo
                    CitasReturn.fecha = TextBoxFecha.Text;//Fecha
                    CitasReturn.fk_hora = Convert.ToInt32(DropDownListHorarios.SelectedValue);//Fk del horario
                    CitasReturn.NoProfes = Convert.ToInt32(TextBoxNoProfesores.Text);//Sabemos el número de profesores
                    CitasReturn.cupo = CitasReturn.NoAlumno * CitasReturn.NoProfes; // operacion matematica para calcular los espacios 
                    CitasReturn.id_registro = Convert.ToInt32(1);       /// opcional, reguistar quien registro la cita (quien secretaria lo hizo)
                }
                catch (Exception)
                {
                    CitasReturn = null;
                    PanelAvisoError.Visible = true;
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
                CCitas obj = new CCitas();
                try
                {
                    obj.fecha = TextBoxFecha.Text;
                }
                catch (Exception)
                {

                    obj.fecha = "2000-01-01";
                }
                return obj;
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

        protected void ButtonCrear_Click(object sender, EventArgs e)
        {
            //Validaciones pendientes
            if (true)
            {
                WCitas.CrearCita(1, ObjetoCitas);

                //Limpiamos cajas de texto
                TextBoxFecha.Text = "";         
                TextBoxNoProfesores.Text = "";
            }
        }

       

        protected void TextBoxFecha_TextChanged(object sender, EventArgs e)
        {
            //  LlenadoCombo(DropDownListHorarios,2, "ListadoCatalogos");
            //para usar este el listado debe de recirnir un objeto con la fecha 
            LlenadoCombo(DropDownListHorarios, 2, "ListadoCatalogos");
        }
    }
}