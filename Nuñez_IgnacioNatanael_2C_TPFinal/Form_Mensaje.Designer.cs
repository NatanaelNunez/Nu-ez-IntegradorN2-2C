namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    partial class Form_Mensaje
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
            this.labelMensaj = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMensaj
            // 
            this.labelMensaj.BackColor = System.Drawing.Color.Black;
            this.labelMensaj.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMensaj.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelMensaj.Location = new System.Drawing.Point(12, 9);
            this.labelMensaj.Name = "labelMensaj";
            this.labelMensaj.Size = new System.Drawing.Size(381, 46);
            this.labelMensaj.TabIndex = 0;
            this.labelMensaj.Text = "Guardando..";
            this.labelMensaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMensaj.Click += new System.EventHandler(this.labelMensaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(12, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "Hilo secundario, puede seguir utilizando la app entera";
            // 
            // Form_Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(405, 84);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMensaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Mensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Mensaje";
            this.Load += new System.EventHandler(this.Form_Mensaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMensaje;
        private Label labelMensaj;
        private Label label5;
    }
}