namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    partial class Form_EliminarPasajeros
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
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvPasajeros = new System.Windows.Forms.DataGridView();
            this.UsuarioDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.Button();
            this.ButtonAceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFechaIngreso = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar:";
            this.label2.Visible = false;
            // 
            // FiltroBoxInput
            // 
            this.FiltroBoxInput.BackColor = System.Drawing.SystemColors.Info;
            this.FiltroBoxInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiltroBoxInput.Location = new System.Drawing.Point(101, 12);
            this.FiltroBoxInput.Name = "FiltroBoxInput";
            this.FiltroBoxInput.Size = new System.Drawing.Size(180, 29);
            this.FiltroBoxInput.TabIndex = 8;
            this.FiltroBoxInput.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(316, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtrar Pasajero por: DNI";
            this.label1.Visible = false;
            // 
            // dtgvPasajeros
            // 
            this.dtgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioDNI,
            this.Nombre,
            this.Apellido,
            this.FechaIngreso,
            this.Estado});
            this.dtgvPasajeros.Location = new System.Drawing.Point(12, 96);
            this.dtgvPasajeros.Name = "dtgvPasajeros";
            this.dtgvPasajeros.ReadOnly = true;
            this.dtgvPasajeros.RowTemplate.Height = 25;
            this.dtgvPasajeros.Size = new System.Drawing.Size(626, 358);
            this.dtgvPasajeros.TabIndex = 15;
            this.dtgvPasajeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPasajeros_CellContentClick);
            // 
            // UsuarioDNI
            // 
            this.UsuarioDNI.HeaderText = "USUARIO (DNI)";
            this.UsuarioDNI.Name = "UsuarioDNI";
            this.UsuarioDNI.ReadOnly = true;
            this.UsuarioDNI.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "APELLIDO";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 120;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "FECHA INGRESO";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 130;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Eliminar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Eliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Eliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Eliminar.Location = new System.Drawing.Point(150, 550);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(120, 42);
            this.Eliminar.TabIndex = 40;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // ButtonAceptar
            // 
            this.ButtonAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAceptar.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAceptar.Location = new System.Drawing.Point(12, 550);
            this.ButtonAceptar.Name = "ButtonAceptar";
            this.ButtonAceptar.Size = new System.Drawing.Size(120, 42);
            this.ButtonAceptar.TabIndex = 39;
            this.ButtonAceptar.Text = "Aceptar";
            this.ButtonAceptar.UseVisualStyleBackColor = false;
            this.ButtonAceptar.Click += new System.EventHandler(this.ButtonAceptar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(480, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Fecha Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(361, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Estado";
            this.label6.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(316, 561);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 23);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(168, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Pasajero (DNI)";
            // 
            // textBoxFechaIngreso
            // 
            this.textBoxFechaIngreso.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxFechaIngreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFechaIngreso.Location = new System.Drawing.Point(480, 496);
            this.textBoxFechaIngreso.Name = "textBoxFechaIngreso";
            this.textBoxFechaIngreso.ReadOnly = true;
            this.textBoxFechaIngreso.Size = new System.Drawing.Size(150, 27);
            this.textBoxFechaIngreso.TabIndex = 33;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(168, 496);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(150, 27);
            this.textBoxNombre.TabIndex = 32;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDNI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDNI.Location = new System.Drawing.Point(12, 496);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(150, 27);
            this.textBoxDNI.TabIndex = 31;
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddTest.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddTest.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddTest.Location = new System.Drawing.Point(521, 12);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(120, 42);
            this.buttonAddTest.TabIndex = 41;
            this.buttonAddTest.Text = "AddTest";
            this.buttonAddTest.UseVisualStyleBackColor = false;
            this.buttonAddTest.Visible = false;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxApellido.Location = new System.Drawing.Point(324, 496);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.ReadOnly = true;
            this.textBoxApellido.Size = new System.Drawing.Size(150, 27);
            this.textBoxApellido.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(361, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(393, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Seleccionar desde esta columna";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancelar.BackColor = System.Drawing.Color.Brown;
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCancelar.Location = new System.Drawing.Point(500, 546);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 42);
            this.buttonCancelar.TabIndex = 45;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(28, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(535, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Buscar pasajeros para eliminarlos.  (Y volverlos a cargar más tarde)";
            // 
            // Form_EliminarPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.buttonAddTest);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.ButtonAceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFechaIngreso);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.dtgvPasajeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltroBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_EliminarPasajeros";
            this.Text = "Form_EliminarPasajeros";
            this.Load += new System.EventHandler(this.Form_EliminarPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private TextBox FiltroBoxInput;
        private Label label1;
        private DataGridView dtgvPasajeros;
        private Button Eliminar;
        private Button ButtonAceptar;
        private Label label7;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private TextBox textBoxFechaIngreso;
        private TextBox textBoxNombre;
        private TextBox textBoxDNI;
        private Button buttonAddTest;
        private DataGridViewTextBoxColumn UsuarioDNI;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn Estado;
        private TextBox textBoxApellido;
        private Label label3;
        private Label label8;
        private Button buttonCancelar;
        private Label label9;
    }
}