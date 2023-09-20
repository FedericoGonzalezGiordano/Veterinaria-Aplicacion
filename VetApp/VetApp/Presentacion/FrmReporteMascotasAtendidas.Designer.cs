namespace VetApp.Presentacion.Reportes
{
    partial class FrmReporteMascotasAtendidas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblNombreMascota = new System.Windows.Forms.Label();
            this.LblImporte = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtNMascota = new System.Windows.Forms.TextBox();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.dataSet1 = new VetApp.Presentacion.Reportes.DataSet1();
            this.dSMascotasAtendidas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotasAtendidas1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dSMascotasAtendidas1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VetApp.Presentacion.Reportes.RpTMascotasAtendidas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(729, 333);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // LblNombreMascota
            // 
            this.LblNombreMascota.AutoSize = true;
            this.LblNombreMascota.ForeColor = System.Drawing.Color.GhostWhite;
            this.LblNombreMascota.Location = new System.Drawing.Point(36, 33);
            this.LblNombreMascota.Name = "LblNombreMascota";
            this.LblNombreMascota.Size = new System.Drawing.Size(44, 13);
            this.LblNombreMascota.TabIndex = 1;
            this.LblNombreMascota.Text = "Nombre";
            // 
            // LblImporte
            // 
            this.LblImporte.AutoSize = true;
            this.LblImporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblImporte.Location = new System.Drawing.Point(38, 67);
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(42, 13);
            this.LblImporte.TabIndex = 2;
            this.LblImporte.Text = "Importe";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblFecha.Location = new System.Drawing.Point(259, 30);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 3;
            this.LblFecha.Text = "Fecha";
            // 
            // TxtNMascota
            // 
            this.TxtNMascota.Location = new System.Drawing.Point(86, 30);
            this.TxtNMascota.Name = "TxtNMascota";
            this.TxtNMascota.Size = new System.Drawing.Size(145, 20);
            this.TxtNMascota.TabIndex = 4;
            // 
            // TxtImporte
            // 
            this.TxtImporte.Location = new System.Drawing.Point(86, 64);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(92, 20);
            this.TxtImporte.TabIndex = 5;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(302, 27);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(104, 20);
            this.DtpFecha.TabIndex = 6;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnConsultar.Location = new System.Drawing.Point(657, 67);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(101, 32);
            this.BtnConsultar.TabIndex = 7;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSMascotasAtendidas1BindingSource
            // 
            this.dSMascotasAtendidas1BindingSource.DataMember = "DSMascotasAtendidas1";
            this.dSMascotasAtendidas1BindingSource.DataSource = this.dataSet1;
            // 
            // FrmReporteMascotasAtendidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.TxtImporte);
            this.Controls.Add(this.TxtNMascota);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblImporte);
            this.Controls.Add(this.LblNombreMascota);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteMascotasAtendidas";
            this.Text = "FrmReporteMascotasAtendidas";
            this.Load += new System.EventHandler(this.FrmReporteMascotasAtendidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotasAtendidas1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label LblNombreMascota;
        private System.Windows.Forms.Label LblImporte;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtNMascota;
        private System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.BindingSource dSMascotasAtendidas1BindingSource;
        private DataSet1 dataSet1;
    }
}