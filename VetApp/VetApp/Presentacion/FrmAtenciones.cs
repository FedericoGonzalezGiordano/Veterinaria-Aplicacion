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
        DbHelper gestor;
           
        Mascota mascota;
      


        public FrmAtenciones()
        {
            InitializeComponent();
            gestor= new DbHelper();
           
            mascota= new Mascota();
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
            DataTable tabla = gestor.Consultar("sp_cliente");
            CboCliente.DataSource=tabla;
            CboCliente.ValueMember = tabla.Columns[0].ColumnName;
            CboCliente.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void cargarTipo()
        {
            DataTable tabla = gestor.Consultar("sp_tipo_mascota");
            cboTipo.DataSource = tabla;
            cboTipo.ValueMember = tabla.Columns[0].ColumnName;
            cboTipo.DisplayMember = tabla.Columns[1].ColumnName;
        }

        

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                DataRowView item = (DataRowView)CboCliente.SelectedItem;
                int id = Convert.ToInt32(item.Row.ItemArray[0]);
                string nom = item.Row.ItemArray[1].ToString();
                int sexo = Convert.ToInt32(item.Row.ItemArray[2].ToString());




                mascota.Nombre = TxtNombre.Text;
                mascota.Tipo = cboTipo.SelectedIndex;
                mascota.Edad = Convert.ToInt32(TxtEdad.Text);

                string descripcion = txtTratatamiento.Text;
                DateTime fecha = Convert.ToDateTime(TxtFecha.Text);
                double importe = Convert.ToDouble(TxtImporte.Text);

                Cliente c = new Cliente(id, nom, sexo);
                c.AgregarMascota(mascota);

                Atencion atencion = new Atencion(descripcion, importe, fecha);
                mascota.AgregarAtencion(atencion);
                DgvAtenciones.Rows.Add(new object[] { fecha, descripcion, importe, "Quitar" });

            }
        }

        private bool validar()
        {
            if (CboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el Duenio de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombre.Focus();
                return false;
            }
            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtEdad.Text))
            {
                MessageBox.Show("Ingrese la edad de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtEdad.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTratatamiento.Text))
            {
                MessageBox.Show("Ingrese el tratamiento de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTratatamiento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtImporte.Text) || !double.TryParse(TxtImporte.Text, out _))
            {
                MessageBox.Show("Debe ingresar un importe valido..", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtImporte.Focus();
                return false;
            }
            return true;
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

        private void DgvAtenciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvAtenciones.CurrentCell.ColumnIndex == (DgvAtenciones.ColumnCount - 1))
            {

                mascota.QuitarAtencion(DgvAtenciones.CurrentRow.Index);
                DgvAtenciones.Rows.RemoveAt(DgvAtenciones.CurrentRow.Index);
                
            }
        }
    }
}
