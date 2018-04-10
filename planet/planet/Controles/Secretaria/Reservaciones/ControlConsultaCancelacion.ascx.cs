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
       

        protected void Page_Load(object sender, EventArgs e)
        {

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
                return null;
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
                return null;
            }

            set
            {
                
            }
        }
        #endregion

    }
}