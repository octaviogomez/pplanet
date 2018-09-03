﻿using System;
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
    public partial class ContPerfil : System.Web.UI.UserControl,IAlumno
    {
        CAlumno ObjAlumno;
        WAlumno WAlumno;

        protected void Page_Load(object sender, EventArgs e)
        {
             ObjAlumno=new CAlumno();
             WAlumno=new WAlumno(this);
           
            WAlumno.ListadoAlumno(UsuarioLogeado, 5);

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
                CAlumno obj = new CAlumno();
                try
                {
                    
                    obj.pk_alumno = (Request.QueryString["id"].ToString() != null) ? Convert.ToInt32(Request.QueryString["id"].ToString()) : 0;
                }
                catch (Exception)
                {

                    obj.pk_alumno = 0;
                }
                return obj;
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
                    try
                    {
                        TextBoxId.Text = value.Tables[0].Rows[0][0].ToString(); 
                        TextBoxPassword.Text= value.Tables[0].Rows[0][3].ToString();
                        TextBoxCorreo.Text= value.Tables[0].Rows[0][5].ToString();
                        TextBoxNombre.Text= value.Tables[0].Rows[0][6].ToString();
                        TextBoxApellidos.Text = value.Tables[0].Rows[0][7].ToString();
                        TextBoxAnioIngreso.Text = value.Tables[0].Rows[0][8].ToString();
                        TextBoxAnioEgreso.Text = value.Tables[0].Rows[0][9].ToString();
                        CheckBoxEstadoPago.Checked = (value.Tables[0].Rows[0][10].ToString() == "1") ? false : true;
                        TextBoxFacebook.Text = value.Tables[0].Rows[0][11].ToString();
                        TextBoxTelefono.Text = value.Tables[0].Rows[0][12].ToString();
                        TextBoxCelular.Text = value.Tables[0].Rows[0][13].ToString();
                        RadioButtonListSexo.SelectedValue = value.Tables[0].Rows[0][14].ToString();
                        DropDownListNivel.SelectedValue = value.Tables[0].Rows[0][16].ToString();

                        DropDownListNivel.SelectedValue= value.Tables[0].Rows[0][16].ToString();

                        TextBoxDireccion.Text = value.Tables[0].Rows[0][17].ToString();
                        TextBoxClubs.Text = value.Tables[0].Rows[0][18].ToString();
                        TextBoxPelis.Text = value.Tables[0].Rows[0][19].ToString();
                        TextBoxCumple.Text = value.Tables[0].Rows[0][20].ToString();

                    }
                    catch (Exception)
                    {

                        
                    }
                }
            }
        }

        public void MensajeAlumno(string Mensaje, int tipo)
        {
            
        }
        #endregion

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            
                Response.Redirect("Perfil.aspx?id=" + TextBoxidBuscar.Text, true);//
          
        }

        protected void ButtonModifica_Click(object sender, EventArgs e)
        {
            TextBoxId.Enabled = true;
            TextBoxPassword.Enabled = true;
            TextBoxAnioEgreso.Enabled = true;
            TextBoxCorreo.Enabled = true;
            TextBoxNombre.Enabled = true;
            TextBoxApellidos.Enabled = true;
            CheckBoxEstadoPago.Enabled = true;
            TextBoxFacebook.Enabled = true;
            TextBoxTelefono.Enabled = true;
            TextBoxCelular.Enabled = true;
            DropDownListNivel.Enabled = true;
            TextBoxDireccion.Enabled = true;
            TextBoxCumple.Enabled = true;

            ButtonGuardaModificar.Visible = true;

            TextBoxidBuscar.Enabled = false;
            ButtonBusca.Enabled = false;
        }

        protected void ButtonGuardaModificar_Click(object sender, EventArgs e)
        {

        }
    }
}