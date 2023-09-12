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

namespace VetApp.Presentacion
{
    public partial class FrmConsultaAtencion : Form
    {
        DbHelper gestor;
        public FrmConsultaAtencion()
        {
            InitializeComponent();
            gestor = new DbHelper();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
            TxtMascota.Text= string.Empty;
            TxtCliente.Text= string.Empty;
        }

        private void FrmConsultaAtencion_Load(object sender, EventArgs e)
        {
        
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@nombreC", TxtCliente.Text));
                lst.Add(new Parametro("@nombreM", TxtMascota.Text));
                DataTable d=new DataTable();
                
                d=gestor.Consultar("SP_CONSULTA_ATENCION", lst);

                DgvConsultaAtencion.Rows.Clear();

                foreach (DataRow fila in d.Rows)
                {
                    DgvConsultaAtencion.Rows.Add(new object[] { fila["id_atencion"].ToString(),
                                                        fila["descripcion"].ToString(),
                                                        fila["importe"].ToString(),
                                                        fila["fecha"].ToString(),
                                                        fila["tratamiento"].ToString(),
                                                        "Mascota"});
                } 
            }
        }

        private bool Validar()
        {
           if (string.IsNullOrEmpty(TxtCliente.Text))
            {
                MessageBox.Show("Ingrese el cliente","Agregar",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(TxtMascota.Text))
            {
                MessageBox.Show("Ingrese la mascota", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;    
        }

        private void DgvConsultaAtencion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsultaAtencion.CurrentCell.ColumnIndex == 5)
            {
                int nroAtencion = Convert.ToInt32(DgvConsultaAtencion.CurrentRow.Cells["ColAtencion"].Value);
               FrmDetallesConsultaAtencion detalle=new FrmDetallesConsultaAtencion(nroAtencion);
                detalle.Nro = nroAtencion;
                detalle.ShowDialog();

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Saliendo", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
