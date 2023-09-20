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

namespace VetApp.Presentacion.Reportes
{
    public partial class FrmReporteMascotasAtendidas : Form
    {
        DbHelper dbHelper = null;
        public FrmReporteMascotasAtendidas()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
        }

        private void FrmReporteMascotasAtendidas_Load(object sender, EventArgs e)
        {

            DtpFecha.Value = DateTime.Today.AddDays(-30);

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
               List<Parametro> lParam= new List<Parametro>();
                
                lParam.Add(new Parametro("@nombreM", TxtNMascota.Text));
                lParam.Add(new Parametro("@importe", TxtImporte.Text));
                lParam.Add(new Parametro("@fecha",DtpFecha.Value));

                DataTable dt=dbHelper.Consultar("SP_CONSULTA_MASCOTA_ATENDIDAS", lParam);
                this.dSMascotasAtendidas1BindingSource.DataSource = dt;
                this.reportViewer1.RefreshReport();
            }

        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(TxtNMascota.Text))
            {
                MessageBox.Show("Ingrese el nombre de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNMascota.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtImporte.Text) || !decimal.TryParse(TxtImporte.Text, out _))
            {
                MessageBox.Show("Debe ingresar un importe valido..", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtImporte.Focus();
                return false;
            }
            return true;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
