namespace UPC.PichangaApp.WF
{
    partial class frmReservaRegistro
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
            this.lblCancha = new System.Windows.Forms.Label();
            this.cbCancha = new System.Windows.Forms.ComboBox();
            this.lblCantidadJugadores = new System.Windows.Forms.Label();
            this.txtCantidadJugadores = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCancha
            // 
            this.lblCancha.AutoSize = true;
            this.lblCancha.Location = new System.Drawing.Point(17, 14);
            this.lblCancha.Name = "lblCancha";
            this.lblCancha.Size = new System.Drawing.Size(54, 13);
            this.lblCancha.TabIndex = 0;
            this.lblCancha.Text = "# Cancha";
            // 
            // cbCancha
            // 
            this.cbCancha.FormattingEnabled = true;
            this.cbCancha.Location = new System.Drawing.Point(20, 30);
            this.cbCancha.Name = "cbCancha";
            this.cbCancha.Size = new System.Drawing.Size(121, 21);
            this.cbCancha.TabIndex = 1;
            this.cbCancha.SelectedIndexChanged += new System.EventHandler(this.cbCancha_SelectedIndexChanged);
            // 
            // lblCantidadJugadores
            // 
            this.lblCantidadJugadores.AutoSize = true;
            this.lblCantidadJugadores.Location = new System.Drawing.Point(185, 14);
            this.lblCantidadJugadores.Name = "lblCantidadJugadores";
            this.lblCantidadJugadores.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadJugadores.TabIndex = 2;
            this.lblCantidadJugadores.Text = "Cant.Jug";
            // 
            // txtCantidadJugadores
            // 
            this.txtCantidadJugadores.Location = new System.Drawing.Point(185, 30);
            this.txtCantidadJugadores.Name = "txtCantidadJugadores";
            this.txtCantidadJugadores.Size = new System.Drawing.Size(49, 20);
            this.txtCantidadJugadores.TabIndex = 3;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(20, 85);
            this.dtpFecha.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2023, 10, 26, 17, 30, 40, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(17, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(159, 130);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(140, 69);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora";
            // 
            // cbHora
            // 
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Location = new System.Drawing.Point(143, 84);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(77, 21);
            this.cbHora.TabIndex = 8;
            // 
            // frmReservaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 161);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtCantidadJugadores);
            this.Controls.Add(this.lblCantidadJugadores);
            this.Controls.Add(this.cbCancha);
            this.Controls.Add(this.lblCancha);
            this.Name = "frmReservaRegistro";
            this.Text = "Reserva de cancha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCancha;
        private System.Windows.Forms.ComboBox cbCancha;
        private System.Windows.Forms.Label lblCantidadJugadores;
        private System.Windows.Forms.TextBox txtCantidadJugadores;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cbHora;
    }
}