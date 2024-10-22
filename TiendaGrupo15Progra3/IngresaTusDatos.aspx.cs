﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiendaGrupo15Progra3.conexion;

namespace TiendaGrupo15Progra3
{
    public partial class IngresaTusDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            
        }

        private ConexionSql conexionSql = new ConexionSql();

        public void ParticiparButton_Click(object sender, EventArgs e)
        {
            conexionSql = new ConexionSql();
            
            try
            {

                string numeroDNI = DNInumero.Text.Trim();
                string nombre = nombreText.Text.Trim();
                string apellido = apellidoText.Text.Trim();
                string email = EmailInput.Text.Trim();
                string direccion = direccionText.Text.Trim();
                string ciudad = ciudadText.Text.Trim();
                //CUANDO RECIBE TEXTO TIRA EX, ARREGLAR CARTELITO QUE RECIBE NUMEROS
                int codigoPostal = Int32.Parse(codigoPostalText.Text.Trim());

                conexionSql.insertarCliente(numeroDNI, nombre, apellido, email, direccion, ciudad, codigoPostal);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario se ha cargado con exito');", true);

            }
            catch (Exception ex)
            {
                string excepcion = ex.ToString();

            }

            
        }


    }
}