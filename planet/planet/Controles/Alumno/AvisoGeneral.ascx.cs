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

namespace planet.Controles.Alumno
{
    public partial class AvisoGeneral : System.Web.UI.UserControl,IAvisoGenerales
    {

        CAvisoGenerales ContAvisoGenerales;
        WAvisoGenerales WAvisoGenerales;
        protected void Page_Load(object sender, EventArgs e)
        {
            WAvisoGenerales = new WAvisoGenerales(this);
            ContAvisoGenerales = new CAvisoGenerales();

            WAvisoGenerales.ObtenerAvisoGeneral(1);
        }
        #region IAvisoGenerales
        public DataSet AvisoGeneralesDt
        {
            get
            {
                return null;
            }

            set
            { 
            }
        }

        public CAvisoGenerales ObjAvisoGenerales
        {
            get
            {
                return null;
            }

            set
            {

                if (value != null)
                {
                    LabelDescripcion.Text = value.Descripcion;
                    LabelFecha.Text = value.Fecha;
                    LabelDireccion.Text = value.Direccion;
                }
            }
        }

        public void MensajeAvisoGenerales(string Mensaje, int tipo)
        {
          
        }
        #endregion

    }
}