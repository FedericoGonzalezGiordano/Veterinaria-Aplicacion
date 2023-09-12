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

namespace VetApp.Presentacion
{
    public partial class FrmDetallesConsultaAtencion : Form
    {
        DbHelper gestor;
        public FrmDetallesConsultaAtencion(int nro)
        {
            InitializeComponent();
            this.Text += nro.ToString();
            gestor = new DbHelper();
        }
        public int Nro { get; set; }

        private void FrmDetallesConsultaAtencion_Load(object sender, EventArgs e)
        {

            cargarGrilla();
           

        }

        private void cargarGrilla()
        {
            DataTable dt = new DataTable();
            dt = gestor.Consultar("SP_CONSULTA_MASCOTA", Nro);
           

            foreach (DataRow fila in dt.Rows)
            {
                DgvMascotas.Rows.Add(new object[] { Convert.ToInt32(fila["cod_mascota"].ToString()),
                                                        fila["nombreM"].ToString(),
                                                        fila["edad"].ToString(),
                                                        fila["descripcion"].ToString(),
                                                        fila["nombreC"].ToString()
                                                      });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Saliendo","Salir",MessageBoxButtons.OK,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
