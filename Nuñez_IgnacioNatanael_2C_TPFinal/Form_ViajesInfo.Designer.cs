namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    partial class Form_ViajesInfo
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
            this.label9 = new System.Windows.Forms.Label();
            this.dtgvViajesVendidos = new System.Windows.Forms.DataGridView();
            this.IDViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipajeMano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipajeDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FechadeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViajeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViajesVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(278, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 25);
            this.label9.TabIndex = 48;
            this.label9.Text = "Lista de Viajes vendidos";
            // 
            // dtgvViajesVendidos
            // 
            this.dtgvViajesVendidos.AllowUserToAddRows = false;
            this.dtgvViajesVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvViajesVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDViaje,
            this.DNIPasajero,
            this.NombreCompleto,
            this.TipoVuelo,
            this.EquipajeMano,
            this.EquipajeDeposito,
            this.PrecioTotal,
            this.FechadeVenta});
            this.dtgvViajesVendidos.Location = new System.Drawing.Point(5, 70);
            this.dtgvViajesVendidos.Name = "dtgvViajesVendidos";
            this.dtgvViajesVendidos.RowTemplate.Height = 25;
            this.dtgvViajesVendidos.Size = new System.Drawing.Size(783, 232);
            this.dtgvViajesVendidos.TabIndex = 49;
            this.dtgvViajesVendidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDViaje
            // 
            this.IDViaje.HeaderText = "ID Viaje";
            this.IDViaje.Name = "IDViaje";
            this.IDViaje.ReadOnly = true;
            this.IDViaje.Width = 50;
            // 
            // DNIPasajero
            // 
            this.DNIPasajero.HeaderText = "DNI Pasajero";
            this.DNIPasajero.Name = "DNIPasajero";
            this.DNIPasajero.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 120;
            // 
            // TipoVuelo
            // 
            this.TipoVuelo.HeaderText = "Tipo de Vuelo";
            this.TipoVuelo.Name = "TipoVuelo";
            this.TipoVuelo.ReadOnly = true;
            // 
            // EquipajeMano
            // 
            this.EquipajeMano.HeaderText = "Equipaje de Mano";
            this.EquipajeMano.Name = "EquipajeMano";
            this.EquipajeMano.ReadOnly = true;
            this.EquipajeMano.Width = 80;
            // 
            // EquipajeDeposito
            // 
            this.EquipajeDeposito.HeaderText = "Equipaje de Deposito";
            this.EquipajeDeposito.Name = "EquipajeDeposito";
            this.EquipajeDeposito.ReadOnly = true;
            this.EquipajeDeposito.Width = 80;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "Precio Total";
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            this.PrecioTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrecioTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FechadeVenta
            // 
            this.FechadeVenta.HeaderText = "Fecha de Venta";
            this.FechadeVenta.Name = "FechadeVenta";
            this.FechadeVenta.ReadOnly = true;
            this.FechadeVenta.Width = 110;
            // 
            // ViajeID
            // 
            this.ViajeID.HeaderText = "Viaje ID";
            this.ViajeID.Name = "ViajeID";
            this.ViajeID.ReadOnly = true;
            // 
            // ButtonAceptar
            // 
            this.ButtonAceptar.AutoSize = true;
            this.ButtonAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonAceptar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAceptar.Location = new System.Drawing.Point(558, 400);
            this.ButtonAceptar.Name = "ButtonAceptar";
            this.ButtonAceptar.Size = new System.Drawing.Size(230, 38);
            this.ButtonAceptar.TabIndex = 50;
            this.ButtonAceptar.Text = "Volver al menu de inicio";
            this.ButtonAceptar.UseVisualStyleBackColor = false;
            // 
            // Form_ViajesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonAceptar);
            this.Controls.Add(this.dtgvViajesVendidos);
            this.Controls.Add(this.label9);
            this.Name = "Form_ViajesInfo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_ViajesInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViajesVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private DataGridView dtgvViajesVendidos;
        private DataGridViewTextBoxColumn ViajeID;
        private DataGridViewTextBoxColumn IDViaje;
        private DataGridViewTextBoxColumn DNIPasajero;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn TipoVuelo;
        private DataGridViewTextBoxColumn EquipajeMano;
        private DataGridViewTextBoxColumn EquipajeDeposito;
        private DataGridViewButtonColumn PrecioTotal;
        private DataGridViewTextBoxColumn FechadeVenta;
        private Button ButtonAceptar;
    }
}