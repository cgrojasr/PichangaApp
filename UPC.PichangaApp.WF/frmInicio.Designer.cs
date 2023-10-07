namespace UPC.PichangaApp.WF
{
    partial class frmInicio
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
            this.mnInicio = new System.Windows.Forms.MenuStrip();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevaReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHistorialReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mnInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnInicio
            // 
            this.mnInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaToolStripMenuItem});
            this.mnInicio.Location = new System.Drawing.Point(0, 0);
            this.mnInicio.Name = "mnInicio";
            this.mnInicio.Size = new System.Drawing.Size(693, 24);
            this.mnInicio.TabIndex = 0;
            this.mnInicio.Text = "menuStrip1";
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevaReserva,
            this.btnHistorialReserva});
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reservaToolStripMenuItem.Text = "Reserva";
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(180, 22);
            this.btnNuevaReserva.Text = "Nueva reserva";
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // btnHistorialReserva
            // 
            this.btnHistorialReserva.Name = "btnHistorialReserva";
            this.btnHistorialReserva.Size = new System.Drawing.Size(180, 22);
            this.btnHistorialReserva.Text = "Historial de reservas";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.mnInicio);
            this.MainMenuStrip = this.mnInicio;
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.mnInicio.ResumeLayout(false);
            this.mnInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnInicio;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNuevaReserva;
        private System.Windows.Forms.ToolStripMenuItem btnHistorialReserva;
    }
}