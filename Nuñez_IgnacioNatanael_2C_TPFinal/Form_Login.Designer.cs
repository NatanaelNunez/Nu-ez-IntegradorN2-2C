namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    partial class Form_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAceptar = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.MailtextBox = new System.Windows.Forms.TextBox();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MensajeAvisoText = new System.Windows.Forms.Label();
            this.Vendedor = new System.Windows.Forms.Button();
            this.Supervisor = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // ButtonAceptar
            // 
            this.ButtonAceptar.AutoSize = true;
            this.ButtonAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonAceptar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAceptar.Location = new System.Drawing.Point(246, 295);
            this.ButtonAceptar.Name = "ButtonAceptar";
            this.ButtonAceptar.Size = new System.Drawing.Size(90, 38);
            this.ButtonAceptar.TabIndex = 1;
            this.ButtonAceptar.Text = "Aceptar";
            this.ButtonAceptar.UseVisualStyleBackColor = false;
            this.ButtonAceptar.Click += new System.EventHandler(this.ButtonAceptar_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.Location = new System.Drawing.Point(32, 293);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(100, 40);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancelar";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            // 
            // MailtextBox
            // 
            this.MailtextBox.BackColor = System.Drawing.SystemColors.Info;
            this.MailtextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MailtextBox.Location = new System.Drawing.Point(101, 129);
            this.MailtextBox.Name = "MailtextBox";
            this.MailtextBox.Size = new System.Drawing.Size(180, 29);
            this.MailtextBox.TabIndex = 3;
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ClavetextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClavetextBox.Location = new System.Drawing.Point(101, 214);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.Size = new System.Drawing.Size(180, 29);
            this.ClavetextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(41, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(32, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clave:";
            // 
            // MensajeAvisoText
            // 
            this.MensajeAvisoText.AutoSize = true;
            this.MensajeAvisoText.BackColor = System.Drawing.Color.Transparent;
            this.MensajeAvisoText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MensajeAvisoText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MensajeAvisoText.Location = new System.Drawing.Point(74, 79);
            this.MensajeAvisoText.Name = "MensajeAvisoText";
            this.MensajeAvisoText.Size = new System.Drawing.Size(220, 37);
            this.MensajeAvisoText.TabIndex = 7;
            this.MensajeAvisoText.Text = "Ingrese sus datos";
            this.MensajeAvisoText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MensajeAvisoText.Click += new System.EventHandler(this.MensajeAvisoText_Click);
            // 
            // Vendedor
            // 
            this.Vendedor.AutoSize = true;
            this.Vendedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Vendedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Vendedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vendedor.Location = new System.Drawing.Point(12, 2);
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Size = new System.Drawing.Size(78, 29);
            this.Vendedor.TabIndex = 8;
            this.Vendedor.Text = "Vendedor";
            this.Vendedor.UseVisualStyleBackColor = false;
            this.Vendedor.Click += new System.EventHandler(this.Vendedor_Click);
            // 
            // Supervisor
            // 
            this.Supervisor.AutoSize = true;
            this.Supervisor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Supervisor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Supervisor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Supervisor.Location = new System.Drawing.Point(101, 2);
            this.Supervisor.Name = "Supervisor";
            this.Supervisor.Size = new System.Drawing.Size(83, 29);
            this.Supervisor.TabIndex = 9;
            this.Supervisor.Text = "Supervisor";
            this.Supervisor.UseVisualStyleBackColor = false;
            this.Supervisor.Click += new System.EventHandler(this.Supervisor_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Admin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Admin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Admin.Location = new System.Drawing.Point(202, 2);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(59, 29);
            this.Admin.TabIndex = 10;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(380, 357);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Supervisor);
            this.Controls.Add(this.Vendedor);
            this.Controls.Add(this.MensajeAvisoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.MailtextBox);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAceptar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button ButtonAceptar;
        private Button ButtonCancel;
        private TextBox MailtextBox;
        private TextBox ClavetextBox;
        private Label label2;
        private Label label3;
        private Label MensajeAvisoText;
        private Button Vendedor;
        private Button Supervisor;
        private Button Admin;
    }
}