namespace VetApp.Presentacion
{
    partial class FrmDetallesConsultaAtencion
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
            this.LblMascotas = new System.Windows.Forms.Label();
            this.DgvMascotas = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.ColIdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMascotas
            // 
            this.LblMascotas.AutoSize = true;
            this.LblMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMascotas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LblMascotas.Location = new System.Drawing.Point(12, 9);
            this.LblMascotas.Name = "LblMascotas";
            this.LblMascotas.Size = new System.Drawing.Size(111, 24);
            this.LblMascotas.TabIndex = 0;
            this.LblMascotas.Text = "MASCOTA";
            // 
            // DgvMascotas
            // 
            this.DgvMascotas.AllowUserToAddRows = false;
            this.DgvMascotas.AllowUserToDeleteRows = false;
            this.DgvMascotas.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.DgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdMascota,
            this.ColNombre,
            this.ColEdad,
            this.ColTipo,
            this.ColCliente});
            this.DgvMascotas.GridColor = System.Drawing.Color.SlateBlue;
            this.DgvMascotas.Location = new System.Drawing.Point(16, 47);
            this.DgvMascotas.Name = "DgvMascotas";
            this.DgvMascotas.ReadOnly = true;
            this.DgvMascotas.Size = new System.Drawing.Size(563, 113);
            this.DgvMascotas.TabIndex = 1;
            this.DgvMascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnSalir.Location = new System.Drawing.Point(434, 176);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(129, 34);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ColIdMascota
            // 
            this.ColIdMascota.HeaderText = "#Mascota";
            this.ColIdMascota.Name = "ColIdMascota";
            this.ColIdMascota.ReadOnly = true;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColEdad
            // 
            this.ColEdad.HeaderText = "Edad";
            this.ColEdad.Name = "ColEdad";
            this.ColEdad.ReadOnly = true;
            // 
            // ColTipo
            // 
            this.ColTipo.HeaderText = "Tipo";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            // 
            // ColCliente
            // 
            this.ColCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            // 
            // FrmDetallesConsultaAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(591, 233);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.DgvMascotas);
            this.Controls.Add(this.LblMascotas);
            this.Name = "FrmDetallesConsultaAtencion";
            this.Text = "FrmDetallesConsultaAtencion";
            this.Load += new System.EventHandler(this.FrmDetallesConsultaAtencion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMascotas;
        private System.Windows.Forms.DataGridView DgvMascotas;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
    }
}