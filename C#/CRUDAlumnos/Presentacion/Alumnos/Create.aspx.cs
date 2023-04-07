using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Presentacion.Alumnos
{
    public partial class Create : System.Web.UI.Page
    {
        NAlumno alumnoNegocio = new NAlumno();
        Alumno alumno = new Alumno();
        NEstado estado = new NEstado();
        NEstatusAlumno estatusAlumno = new NEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cmbEstadoOrigen.DataSource = estado.Consultar();
                cmbEstadoOrigen.DataTextField = "nombre";
                cmbEstadoOrigen.DataValueField = "id";
                cmbEstadoOrigen.DataBind();


                cmbEstatus.DataSource = estatusAlumno.Consultar();
                cmbEstatus.DataTextField = "nombre";
                cmbEstatus.DataValueField = "id";
                cmbEstatus.DataBind();
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            alumno.nombre = txtNombre.Text.Trim();
            alumno.primerApellido = txtApePat.Text.Trim();
            alumno.segundoApellido = txtApeMat.Text.Trim();
            alumno.correo = txtCorreo.Text.Trim();
            alumno.telefono = txtTelefono.Text.Trim();
            alumno.fechaNacimiento = Convert.ToDateTime(txtFechaNac.Text.Trim());
            alumno.curp = txtCurp.Text.Trim();
            alumno.sueldo = Convert.ToDecimal(txtSueldo.Text.Trim());
            alumno.idEstadoOrigen = Convert.ToInt16(cmbEstadoOrigen.SelectedValue);
            alumno.idEstatus = Convert.ToInt16(cmbEstatus.SelectedValue);
            alumnoNegocio.Agregar(alumno);

            Response.Redirect(Request.RawUrl);
        }

 


    }
}