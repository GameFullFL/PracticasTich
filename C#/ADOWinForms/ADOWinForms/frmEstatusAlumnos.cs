using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOWinForms
{
    public partial class frmEstatusAlumnos : Form
    {
        ADO.ADOEstatusAlumno estatus = new ADO.ADOEstatusAlumno();
        Entidades.EstatusAlumno estatusAlu = new Entidades.EstatusAlumno();
        List<Entidades.EstatusAlumno> EstatusAlumnoList = new List<Entidades.EstatusAlumno>();
        char bandera;
        public frmEstatusAlumnos()
        {
            InitializeComponent();
        }

        public void esconder(bool a, bool b, bool c)
        {
            lblClave.Visible = a;
            lblNombre.Visible = a;
            txtNombre.Visible = a;
            txtClave.Visible = a;
            btnModificar.Visible = a;
            btnCancelar.Visible = a;
            btnAgregar.Enabled = b;
            btnActualizar.Enabled = b;
            btnEliminar.Enabled = b;
            txtClave.Enabled = c;
            txtNombre.Enabled = c;
        }
        public void limpiar()
        {
            txtClave.Clear();
            txtNombre.Clear();
            txtNombre.Focus();
        }

        public void inicio()
        {
            EstatusAlumnoList = estatus.Consultar();
            cmbEstatusAlumnos.DataSource = EstatusAlumnoList;
            cmbEstatusAlumnos.DisplayMember = "nombre";
            cmbEstatusAlumnos.ValueMember = "id";
            dtgEstatusAlumnos.DataSource = EstatusAlumnoList;
            esconder(false, true, true);
            limpiar();
        }

        private void frmEstatusAlumnos_Load(object sender, EventArgs e)
        {
            inicio();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bandera = 'A';
            btnModificar.Text = "Guardar";
            esconder(true,false,true);
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicio();
            esconder(false, true, true);
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bandera == 'A')
            {
                estatusAlu.clave = txtClave.Text.ToUpper().Trim();
                estatusAlu.nombre = txtNombre.Text;
                estatus.Agregar(estatusAlu);
                MessageBox.Show("El registro se ha agregado");
            }
            else if (bandera == 'M')
            {
                estatusAlu.clave = txtClave.Text.ToUpper();
                estatusAlu.nombre = txtNombre.Text;
                estatus.Actualizar(estatusAlu);
                MessageBox.Show("El registro se ha actualizado");

            }
            else if(bandera == 'E')
            {
                estatus.Eliminar(estatusAlu.id);
                MessageBox.Show("El registro se ha eliminado");
            }

            esconder(false, true, true);
            limpiar();
            inicio();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bandera = 'M';
            btnModificar.Text = "Guardar";
            esconder(true, false,true);
            estatusAlu = (Entidades.EstatusAlumno)cmbEstatusAlumnos.SelectedItem;
            txtClave.Text = estatusAlu.clave;
            txtNombre.Text = estatusAlu.nombre;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bandera = 'E';
            btnModificar.Text = "Eliminar";
            esconder(true, false,false);
            estatusAlu = (Entidades.EstatusAlumno)cmbEstatusAlumnos.SelectedItem;
            txtClave.Text = estatusAlu.clave;
            txtNombre.Text = estatusAlu.nombre;
        }
    }
}
