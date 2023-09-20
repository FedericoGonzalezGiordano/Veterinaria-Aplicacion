namespace VetApp
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atencionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascotasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mASCOTASATENDIDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mascotasToolStripMenuItem,
            this.atencionesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mascotasToolStripMenuItem
            // 
            this.mascotasToolStripMenuItem.Name = "mascotasToolStripMenuItem";
            this.mascotasToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.mascotasToolStripMenuItem.Text = "Soporte";
            // 
            // atencionesToolStripMenuItem
            // 
            this.atencionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.atencionesToolStripMenuItem.Name = "atencionesToolStripMenuItem";
            this.atencionesToolStripMenuItem.Size = new System.Drawing.Size(109, 21);
            this.atencionesToolStripMenuItem.Text = "Atenciones";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.consultaToolStripMenuItem.Text = "Nueva Atencion";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.modificarToolStripMenuItem.Text = "Consultar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mascotasToolStripMenuItem1,
            this.mASCOTASATENDIDASToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mascotasToolStripMenuItem1
            // 
            this.mascotasToolStripMenuItem1.Name = "mascotasToolStripMenuItem1";
            this.mascotasToolStripMenuItem1.Size = new System.Drawing.Size(238, 22);
            this.mascotasToolStripMenuItem1.Text = "Mascotas";
            this.mascotasToolStripMenuItem1.Click += new System.EventHandler(this.mascotasToolStripMenuItem1_Click);
            // 
            // mASCOTASATENDIDASToolStripMenuItem
            // 
            this.mASCOTASATENDIDASToolStripMenuItem.Name = "mASCOTASATENDIDASToolStripMenuItem";
            this.mASCOTASATENDIDASToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.mASCOTASATENDIDASToolStripMenuItem.Text = "MASCOTAS ATENDIDAS";
            this.mASCOTASATENDIDASToolStripMenuItem.Click += new System.EventHandler(this.mASCOTASATENDIDASToolStripMenuItem_Click);
            // 
            // FrmVeterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImage = global::VetApp.Properties.Resources.undraw_welcome_cats_thqn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(615, 394);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVeterinaria";
            this.Text = "Veterinaria";
            this.Load += new System.EventHandler(this.FrmVeterinaria_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atencionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascotasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mASCOTASATENDIDASToolStripMenuItem;
    }
}

