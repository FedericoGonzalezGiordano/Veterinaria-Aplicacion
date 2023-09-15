namespace VetApp.Presentacion
{
    partial class FrmConsultaAtencion
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
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.LblMascota = new System.Windows.Forms.Label();
            this.TxtMascota = new System.Windows.Forms.TextBox();
            this.Consultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DgvConsultaAtencion = new System.Windows.Forms.DataGridView();
            this.ColAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImpor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultaAtencion)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCliente
            // 
            this.TxtCliente.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TxtCliente.Location = new System.Drawing.Point(98, 27);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(298, 22);
            this.TxtCliente.TabIndex = 1;
            this.TxtCliente.Text = "Nombre del Cliente";
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Location = new System.Drawing.Point(40, 27);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(55, 16);
            this.LblNombreCliente.TabIndex = 0;
            this.LblNombreCliente.Text = "Cliente";
            // 
            // LblMascota
            // 
            this.LblMascota.AutoSize = true;
            this.LblMascota.Location = new System.Drawing.Point(31, 56);
            this.LblMascota.Name = "LblMascota";
            this.LblMascota.Size = new System.Drawing.Size(66, 16);
            this.LblMascota.TabIndex = 2;
            this.LblMascota.Text = "Mascota";
            // 
            // TxtMascota
            // 
            this.TxtMascota.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TxtMascota.Location = new System.Drawing.Point(98, 53);
            this.TxtMascota.Name = "TxtMascota";
            this.TxtMascota.Size = new System.Drawing.Size(298, 22);
            this.TxtMascota.TabIndex = 2;
            this.TxtMascota.Text = "Nombre de la mascota";
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Consultar.Location = new System.Drawing.Point(482, 56);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(97, 30);
            this.Consultar.TabIndex = 3;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNombreCliente);
            this.groupBox1.Controls.Add(this.Consultar);
            this.groupBox1.Controls.Add(this.TxtCliente);
            this.groupBox1.Controls.Add(this.TxtMascota);
            this.groupBox1.Controls.Add(this.LblMascota);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnModificar.Location = new System.Drawing.Point(29, 254);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(104, 28);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnEliminar.Location = new System.Drawing.Point(166, 254);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(104, 28);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnSalir.Location = new System.Drawing.Point(522, 254);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(104, 28);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DgvConsultaAtencion
            // 
            this.DgvConsultaAtencion.AllowUserToAddRows = false;
            this.DgvConsultaAtencion.AllowUserToDeleteRows = false;
            this.DgvConsultaAtencion.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.DgvConsultaAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultaAtencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAtencion,
            this.ColTipo,
            this.ColImpor,
            this.ColFech,
            this.ColTrat,
            this.ColVer});
            this.DgvConsultaAtencion.GridColor = System.Drawing.SystemColors.WindowText;
            this.DgvConsultaAtencion.Location = new System.Drawing.Point(29, 122);
            this.DgvConsultaAtencion.Name = "DgvConsultaAtencion";
            this.DgvConsultaAtencion.ReadOnly = true;
            this.DgvConsultaAtencion.Size = new System.Drawing.Size(597, 119);
            this.DgvConsultaAtencion.TabIndex = 2;
            this.DgvConsultaAtencion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsultaAtencion_CellContentClick);
            // 
            // ColAtencion
            // 
            this.ColAtencion.HeaderText = "#Atencion";
            this.ColAtencion.Name = "ColAtencion";
            this.ColAtencion.ReadOnly = true;
            this.ColAtencion.Width = 70;
            // 
            // ColTipo
            // 
            this.ColTipo.HeaderText = "Mascota Tipo";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            // 
            // ColImpor
            // 
            this.ColImpor.HeaderText = "Importe";
            this.ColImpor.Name = "ColImpor";
            this.ColImpor.ReadOnly = true;
            // 
            // ColFech
            // 
            this.ColFech.HeaderText = "Fecha";
            this.ColFech.Name = "ColFech";
            this.ColFech.ReadOnly = true;
            // 
            // ColTrat
            // 
            this.ColTrat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTrat.HeaderText = "Tratamiento";
            this.ColTrat.Name = "ColTrat";
            this.ColTrat.ReadOnly = true;
            // 
            // ColVer
            // 
            this.ColVer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColVer.HeaderText = "Ver";
            this.ColVer.Name = "ColVer";
            this.ColVer.ReadOnly = true;
            // 
            // FrmConsultaAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(641, 294);
            this.Controls.Add(this.DgvConsultaAtencion);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultaAtencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmConsultaAtencion";
            this.Load += new System.EventHandler(this.FrmConsultaAtencion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultaAtencion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.Label LblMascota;
        private System.Windows.Forms.TextBox TxtMascota;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DgvConsultaAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImpor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrat;
        private System.Windows.Forms.DataGridViewButtonColumn ColVer;
    }
}