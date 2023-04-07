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
    public partial class Details : System.Web.UI.Page
    {
        NAlumno alumnoNegocio = new NAlumno();
        Alumno alumno= new Alumno();
        NEstado estado = new NEstado();
        NEstatusAlumno estatusAlumno = new NEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
         
            if(!IsPostBack)
            {
                inicio();
            }


        }
        public void inicio()
        {
            int id = Convert.ToInt32(Request.QueryString["id"] ?? "1");
            alumno = alumnoNegocio.Consultar(id);
            lblId.Text = alumno.id.ToString();
            lblNombre.Text = alumno.nombre.ToString();
            lblApePat.Text = alumno.primerApellido.ToString();
            lblApeMat.Text = alumno.segundoApellido.ToString();
            lblCorreo.Text = alumno.correo.ToString();
            lblFecha.Text = alumno.fechaNacimiento.ToString("yyyy-MM-dd");
            lblTelefono.Text = alumno.telefono.ToString();
            lblCurp.Text = alumno.curp.ToString();
            lblSueldo.Text = alumno.sueldo.ToString();

            Estado estadoNombre = estado.Consultar(alumno.idEstadoOrigen);
            lblEstado.Text = estadoNombre.nombre;
            EstatusAlumno estatus = estatusAlumno.Consultar(alumno.idEstatus);
            lblEstatus.Text = estatus.nombre;
        }

        protected void btnImss_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(lblId.Text);
            AportacionesIMSS aportaciones = alumnoNegocio.CalcularIMSS(id);
            lblMensaje.Text = $"Enfermedad maternidad = {aportaciones.EnfermedadMaternidad}, InvalidezVida = {aportaciones.InvalidezVida}, Retiro = {aportaciones.Retiro}, Censantía = {aportaciones.Cesantía}, Infonavit = {aportaciones.Infonavit}";
            lblMensaje.Visible = true;
        }

        protected void btnIsr_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(lblId.Text);
            ItemTablaISR tablaisr = alumnoNegocio.CalcularISR(id);
            lblLimInf.Text = tablaisr.LimiteInferior.ToString();
            lblLimSup.Text = tablaisr.LimiteSuperior.ToString();
            lblCuotaFija.Text = tablaisr.CuotaFija.ToString(); 
            lblExcedente.Text = tablaisr.Excedente.ToString();
            lblSubsidio.Text = tablaisr.Subsidio.ToString();
            lblImpuesto.Text = tablaisr.ISR.ToString();
            mpeModalISR.Show();
            //lblMensaje.Text = $"Limite inferior= {tablaisr.LimiteInferior}, Limite superior = {tablaisr.LimiteSuperior}, Cuota fija = {tablaisr.CuotaFija}, Excedente = {tablaisr.Excedente}, Subsidio = {tablaisr.Subsidio}, ISR = {tablaisr.ISR}";
            //lblMensaje.Visible = true;
        }
    }
}