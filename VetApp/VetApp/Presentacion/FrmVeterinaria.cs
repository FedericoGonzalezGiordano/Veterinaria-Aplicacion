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
using VetApp.Vistas;

namespace VetApp
{
    public partial class FrmVeterinaria : Form
    {
        private DbHelper gestor;
        public FrmVeterinaria()
        {
            InitializeComponent();
            gestor = new DbHelper();
        }

        

        private void nuevaAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtenciones atenciones = new FrmAtenciones();
            atenciones.ShowDialog();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmVeterinaria_Load(object sender, EventArgs e)
        {
            DataTable tabla= new DataTable();
            tabla = gestor.Consultar("sp_cliente");
            DgvClientes.DataSource = tabla;
            LblNroCliente.Text =LblNroCliente.Text+gestor.ProximoCliente().ToString();
        }

        private void mascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = TxtNombreCliente.Text;
                string sexo=string.Empty;
                if (rbtHombre.Checked)
                {
                    cliente.Sexo = 1;
                    
                }
                else
                {
                    cliente.Sexo = 0;
                   
                    
                }
                
                gestor.AgregarCliente(cliente);
                MessageBox.Show("Se agrego con exito el Cliente!", "Agregando", MessageBoxButtons.OK);
                
            }
            else
            {
                MessageBox.Show("No se pudo aniadir el cliente");
            }

            
        }
        private bool Validar()
        {
            if (TxtNombreCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar una nombre valido..", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombreCliente.Focus();
                return false;
            }
            if (rbtHombre.Checked == false && rbtMujer.Checked == false)
            {
                MessageBox.Show("Seleccione un sexo..", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rbtHombre.Focus();
                return false;
            }
            return true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNombreCliente.Text = DgvClientes.CurrentRow.Cells[2].Value.ToString();
            //rbtHombre.Checked = DgvClientes.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
