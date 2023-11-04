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
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.id_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mnInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // mnInicio
            // 
            this.mnInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaToolStripMenuItem});
            this.mnInicio.Location = new System.Drawing.Point(0, 0);
            this.mnInicio.Name = "mnInicio";
            this.mnInicio.Size = new System.Drawing.Size(473, 24);
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
            this.btnNuevaReserva.Size = new System.Drawing.Size(179, 22);
            this.btnNuevaReserva.Text = "Nueva reserva";
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // btnHistorialReserva
            // 
            this.btnHistorialReserva.Name = "btnHistorialReserva";
            this.btnHistorialReserva.Size = new System.Drawing.Size(179, 22);
            this.btnHistorialReserva.Text = "Historial de reservas";
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_reserva,
            this.fecha,
            this.cantidad_disponible,
            this.eliminar});
            this.dgvReservas.Location = new System.Drawing.Point(12, 27);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(444, 150);
            this.dgvReservas.TabIndex = 1;
            this.dgvReservas.DoubleClick += new System.EventHandler(this.dgvReservas_DoubleClick);
            // 
            // id_reserva
            // 
            this.id_reserva.DataPropertyName = "id_reserva";
            this.id_reserva.HeaderText = "ID";
            this.id_reserva.Name = "id_reserva";
            this.id_reserva.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // cantidad_disponible
            // 
            this.cantidad_disponible.DataPropertyName = "cantidad_disponible";
            this.cantidad_disponible.HeaderText = "Cantidad";
            this.cantidad_disponible.Name = "cantidad_disponible";
            this.cantidad_disponible.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Cancelar";
            this.eliminar.Name = "eliminar";
            this.eliminar.Text = "Cancelar";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 191);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.mnInicio);
            this.MainMenuStrip = this.mnInicio;
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.mnInicio.ResumeLayout(false);
            this.mnInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnInicio;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNuevaReserva;
        private System.Windows.Forms.ToolStripMenuItem btnHistorialReserva;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_disponible;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}