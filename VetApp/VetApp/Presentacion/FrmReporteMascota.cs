using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetApp.Presentacion
{
    public partial class FrmReporteMascota : Form
    {
        public FrmReporteMascota()
        {
            InitializeComponent();
        }

        private void ReporteMascota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMascotas.SP_CONSULTA_MASCOTAS' Puede moverla o quitarla según sea necesario.
            this.sP_CONSULTA_MASCOTASTableAdapter.Fill(this.dSMascotas.SP_CONSULTA_MASCOTAS);
            // TODO: esta línea de código carga datos en la tabla 'dSMascotas.SP_CONSULTAR_MASCOTAS' Puede moverla o quitarla según sea necesario.
            this.sP_CONSULTA_MASCOTASTableAdapter.Fill(this.dSMascotas.SP_CONSULTA_MASCOTAS);

            this.RvMascotas.RefreshReport();
        }
    }
}
