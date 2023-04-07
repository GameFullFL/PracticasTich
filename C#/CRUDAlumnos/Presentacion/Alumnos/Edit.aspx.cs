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

    public partial class Edit : System.Web.UI.Page
    {
        NAlumno alumnoNegocio = new NAlumno();
        Alumno alumno = new Alumno();
        EstatusAlumno estatus = new EstatusAlumno();
        NEstado estado = new NEstado();
        NEstatusAlumno estatusAlumno = new NEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                inicio();
            }
            
        }
        public void inicio()
        {
            int id = Convert.ToInt16(Request.QueryString["id"] ?? "1");
            alumno = alumnoNegocio.Consultar(id);
            txtId.Text = alumno.id.ToString();
            txtNombre.Text = alumno.nombre.ToString();
            txtApePat.Text = alumno.primerApellido.ToString();
            txtApeMat.Text = alumno.segundoApellido.ToString();
            txtCorreo.Text = alumno.correo.ToString();
            txtFechaNac.Text = alumno.fechaNacimiento.ToString("yyyy-MM-dd");
            txtTelefono.Text = alumno.telefono.ToString();
            txtCurp.Text = alumno.curp.ToString();
            txtSueldo.Text = alumno.sueldo.ToString();

            cmbEstadoOrigen.DataSource = estado.Consultar();
            cmbEstadoOrigen.DataTextField = "nombre";
            cmbEstadoOrigen.DataValueField = "id";
            cmbEstadoOrigen.DataBind();
            cmbEstadoOrigen.SelectedValue = Convert.ToString(alumno.idEstadoOrigen);

            cmbEstatus.DataSource = estatusAlumno.Consultar();
            cmbEstatus.DataTextField = "nombre";
            cmbEstatus.DataValueField = "id";
            cmbEstatus.DataBind();
            cmbEstatus.SelectedValue = Convert.ToString(alumno.idEstatus);

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["id"] ?? "1");
            alumno.id = Convert.ToInt16(txtId.Text);
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
            alumnoNegocio.Actualizar(alumno);
            Response.Redirect($"Index.aspx?");

        }

        protected void cvCurpVSFecha_ServerValidate(object source, ServerValidateEventArgs args)
        {
                var fechaNac = txtFechaNac.Text;
                var curpPartFecha = txtCurp.Text.Substring(4, 6);
                var fechaNacFormatCurp = fechaNac.Substring(2, 2) + fechaNac.Substring(5, 2) + fechaNac.Substring(8, 2);
                args.IsValid = curpPartFecha == fechaNacFormatCurp;

        }
    }
}