﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _00_ProgramacionWeb.Conexion;
using MySql.Data.MySqlClient;

namespace _00_ProgramacionWeb.Vista
{
    public partial class RegistrarMaestro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Insertar(object sender, EventArgs e)
        {            
            Consultas con = new Consultas();
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String correo = txtCorreo.Text;
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;
            if ( con.RegistrarMaestro( nombre, apellido, correo, usuario, password ) )
            {
                Response.Redirect( "Administrador.aspx?e=1");
            }
            else
            { 

                Response.Write( "Error, No se puede completar la operación" );
            }
        }
    }
}