namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    partial class Form_Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnVentasInfo = new System.Windows.Forms.Button();
            this.buttonVender = new System.Windows.Forms.Button();
            this.buttonEstadisticas = new System.Windows.Forms.Button();
            this.buttonMDViajes = new System.Windows.Forms.Button();
            this.buttonMDPasajeros = new System.Windows.Forms.Button();
            this.buttonMDAeronaves = new System.Windows.Forms.Button();
            this.NombreUsuarioActivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVentasInfo
            // 
            this.BtnVentasInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnVentasInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVentasInfo.Location = new System.Drawing.Point(234, 12);
            this.BtnVentasInfo.Name = "BtnVentasInfo";
            this.BtnVentasInfo.Size = new System.Drawing.Size(158, 40);
            this.BtnVentasInfo.TabIndex = 3;
            this.BtnVentasInfo.Text = "Ventas Info";
            this.BtnVentasInfo.UseVisualStyleBackColor = false;
            this.BtnVentasInfo.Click += new System.EventHandler(this.BtnVentasInfo_Click);
            // 
            // buttonVender
            // 
            this.buttonVender.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonVender.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVender.Location = new System.Drawing.Point(422, 12);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(108, 50);
            this.buttonVender.TabIndex = 5;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseVisualStyleBackColor = false;
            this.buttonVender.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEstadisticas
            // 
            this.buttonEstadisticas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEstadisticas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEstadisticas.Location = new System.Drawing.Point(39, 12);
            this.buttonEstadisticas.Name = "buttonEstadisticas";
            this.buttonEstadisticas.Size = new System.Drawing.Size(158, 40);
            this.buttonEstadisticas.TabIndex = 6;
            this.buttonEstadisticas.Text = "Estadisticas";
            this.buttonEstadisticas.UseVisualStyleBackColor = false;
            this.buttonEstadisticas.Visible = false;
            // 
            // buttonMDViajes
            // 
            this.buttonMDViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMDViajes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMDViajes.Enabled = false;
            this.buttonMDViajes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMDViajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMDViajes.Location = new System.Drawing.Point(630, 299);
            this.buttonMDViajes.Name = "buttonMDViajes";
            this.buttonMDViajes.Size = new System.Drawing.Size(142, 40);
            this.buttonMDViajes.TabIndex = 8;
            this.buttonMDViajes.Text = "Viajes";
            this.buttonMDViajes.UseVisualStyleBackColor = false;
            this.buttonMDViajes.Visible = false;
            this.buttonMDViajes.Click += new System.EventHandler(this.buttonMDViajes_Click);
            // 
            // buttonMDPasajeros
            // 
            this.buttonMDPasajeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMDPasajeros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMDPasajeros.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMDPasajeros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMDPasajeros.Location = new System.Drawing.Point(630, 160);
            this.buttonMDPasajeros.Name = "buttonMDPasajeros";
            this.buttonMDPasajeros.Size = new System.Drawing.Size(142, 40);
            this.buttonMDPasajeros.TabIndex = 9;
            this.buttonMDPasajeros.Text = "Pasajeros";
            this.buttonMDPasajeros.UseVisualStyleBackColor = false;
            this.buttonMDPasajeros.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonMDAeronaves
            // 
            this.buttonMDAeronaves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMDAeronaves.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMDAeronaves.Enabled = false;
            this.buttonMDAeronaves.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMDAeronaves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMDAeronaves.Location = new System.Drawing.Point(630, 226);
            this.buttonMDAeronaves.Name = "buttonMDAeronaves";
            this.buttonMDAeronaves.Size = new System.Drawing.Size(142, 40);
            this.buttonMDAeronaves.TabIndex = 9;
            this.buttonMDAeronaves.Text = "Aeronaves";
            this.buttonMDAeronaves.UseVisualStyleBackColor = false;
            this.buttonMDAeronaves.Visible = false;
            this.buttonMDAeronaves.Click += new System.EventHandler(this.buttonMDAeronaves_Click);
            // 
            // NombreUsuarioActivo
            // 
            this.NombreUsuarioActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreUsuarioActivo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NombreUsuarioActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreUsuarioActivo.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NombreUsuarioActivo.ForeColor = System.Drawing.Color.OrangeRed;
            this.NombreUsuarioActivo.Location = new System.Drawing.Point(615, 12);
            this.NombreUsuarioActivo.Name = "NombreUsuarioActivo";
            this.NombreUsuarioActivo.Size = new System.Drawing.Size(157, 50);
            this.NombreUsuarioActivo.TabIndex = 10;
            this.NombreUsuarioActivo.Text = "Natanael";
            this.NombreUsuarioActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NombreUsuarioActivo.Click += new System.EventHandler(this.NombreUsuarioActivo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(615, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modificadores\r\n                                ↓";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreUsuarioActivo);
            this.Controls.Add(this.buttonMDAeronaves);
            this.Controls.Add(this.buttonMDPasajeros);
            this.Controls.Add(this.buttonMDViajes);
            this.Controls.Add(this.buttonEstadisticas);
            this.Controls.Add(this.buttonVender);
            this.Controls.Add(this.BtnVentasInfo);
            this.Name = "Form_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Inicio";
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnVentasInfo;
        private Button buttonVender;
        private Button buttonEstadisticas;
        private Button buttonMDViajes;
        private Button buttonMDPasajeros;
        private Button buttonMDAeronaves;
        private Label NombreUsuarioActivo;
        private Label label1;
    }
}