using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetApp.Datos;
using VetApp.Dominio;

namespace VetApp.Vistas
{
    public partial class FrmAtenciones : Form 
    {
        DbHelper Gestor=null;
        Cliente cliente;
        

        public FrmAtenciones()
        {
            InitializeComponent();
            Gestor= new DbHelper();
            cliente= new Cliente();
           
        }

        private void FrmAtenciones_Load(object sender, EventArgs e)
        {
            TxtFecha.Text = DateTime.Today.ToShortDateString();
            TxtFecha.Enabled = false;


            cargarCliente();
            cargarTipo();
            
            //LblNroAtencion.Text = LblNroAtencion.Text + " " + Gestor.ProximaAtencion().ToString();
        }

        private void cargarCliente()
        {
            DataTable tabla = Gestor.Consultar("sp_cliente");
            CboCliente.DataSource=tabla;
            CboCliente.ValueMember = tabla.Columns[0].ColumnName;
            CboCliente.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void cargarTipo()
        {
            DataTable tabla = Gestor.Consultar("sp_tipo_mascota");
            cboTipo.DataSource = tabla;
            cboTipo.ValueMember = tabla.Columns[0].ColumnName;
            cboTipo.DisplayMember = tabla.Columns[1].ColumnName;
        }

        

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            

            if (CboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el Duenio de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombre.Focus();
                return;
            }
            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(TxtEdad.Text))
            {
                MessageBox.Show("Ingrese la edad de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtEdad.Focus();
                return;
            }
            if(string.IsNullOrEmpty(txtTratatamiento.Text))
            {
                MessageBox.Show("Ingrese el tratamiento de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTratatamiento.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtImporte.Text) || !double.TryParse(TxtImporte.Text, out _))
            {
                MessageBox.Show("Debe ingresar un importe valido..", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtImporte.Focus();
                return;
            }

            Cliente clienteSeleccionado=CboCliente.SelectedItem as Cliente;
            Mascota mascota=new Mascota();
            clienteSeleccionado.AgregarMascota(mascota);
          
        
        }

        private void LblEdad_Click(object sender, EventArgs e)
        {

        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
