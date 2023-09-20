namespace VetApp.Presentacion
{
    partial class FrmReporteMascota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sPCONSULTAMASCOTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMascotas = new VetApp.Presentacion.Reportes.DSMascotas();
            this.RvMascotas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSMascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_CONSULTA_MASCOTASTableAdapter = new VetApp.Presentacion.Reportes.DSMascotasTableAdapters.SP_CONSULTA_MASCOTASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTAMASCOTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sPCONSULTAMASCOTASBindingSource
            // 
            this.sPCONSULTAMASCOTASBindingSource.DataMember = "SP_CONSULTA_MASCOTAS";
            this.sPCONSULTAMASCOTASBindingSource.DataSource = this.dSMascotas;
            // 
            // dSMascotas
            // 
            this.dSMascotas.DataSetName = "DSMascotas";
            this.dSMascotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RvMascotas
            // 
            this.RvMascotas.BackColor = System.Drawing.Color.MediumPurple;
            this.RvMascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sPCONSULTAMASCOTASBindingSource;
            this.RvMascotas.LocalReport.DataSources.Add(reportDataSource2);
            this.RvMascotas.LocalReport.ReportEmbeddedResource = "VetApp.Presentacion.Reportes.RpTMascotas.rdlc";
            this.RvMascotas.Location = new System.Drawing.Point(0, 0);
            this.RvMascotas.Name = "RvMascotas";
            this.RvMascotas.ServerReport.BearerToken = null;
            this.RvMascotas.Size = new System.Drawing.Size(890, 897);
            this.RvMascotas.TabIndex = 0;
            // 
            // dSMascotasBindingSource
            // 
            this.dSMascotasBindingSource.DataSource = this.dSMascotas;
            this.dSMascotasBindingSource.Position = 0;
            // 
            // sP_CONSULTA_MASCOTASTableAdapter
            // 
            this.sP_CONSULTA_MASCOTASTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(890, 897);
            this.Controls.Add(this.RvMascotas);
            this.Name = "ReporteMascota";
            this.Text = "ReporteMascota";
            this.Load += new System.EventHandler(this.ReporteMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTAMASCOTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RvMascotas;
        private System.Windows.Forms.BindingSource dSMascotasBindingSource;
        private Reportes.DSMascotas dSMascotas;
        private System.Windows.Forms.BindingSource sPCONSULTAMASCOTASBindingSource;
        private Reportes.DSMascotasTableAdapters.SP_CONSULTA_MASCOTASTableAdapter sP_CONSULTA_MASCOTASTableAdapter;
    }
}