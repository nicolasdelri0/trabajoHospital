namespace TrabajoHospitalFinal11
{
    partial class Form3TipoMedico
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
            this.TXB_TipMed = new System.Windows.Forms.TextBox();
            this.BTN_AñadirTipMed = new System.Windows.Forms.Button();
            this.BTN_VolverTipMed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE EL TIPO DE MEDICO";
            // 
            // TXB_TipMed
            // 
            this.TXB_TipMed.BackColor = System.Drawing.Color.White;
            this.TXB_TipMed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_TipMed.Location = new System.Drawing.Point(37, 72);
            this.TXB_TipMed.Name = "TXB_TipMed";
            this.TXB_TipMed.Size = new System.Drawing.Size(261, 22);
            this.TXB_TipMed.TabIndex = 1;
            // 
            // BTN_AñadirTipMed
            // 
            this.BTN_AñadirTipMed.BackColor = System.Drawing.Color.White;
            this.BTN_AñadirTipMed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AñadirTipMed.Location = new System.Drawing.Point(37, 138);
            this.BTN_AñadirTipMed.Name = "BTN_AñadirTipMed";
            this.BTN_AñadirTipMed.Size = new System.Drawing.Size(261, 27);
            this.BTN_AñadirTipMed.TabIndex = 2;
            this.BTN_AñadirTipMed.Text = "Añadir";
            this.BTN_AñadirTipMed.UseVisualStyleBackColor = false;
            this.BTN_AñadirTipMed.Click += new System.EventHandler(this.BTN_AñadirTipMed_Click);
            // 
            // BTN_VolverTipMed
            // 
            this.BTN_VolverTipMed.BackColor = System.Drawing.Color.White;
            this.BTN_VolverTipMed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VolverTipMed.Location = new System.Drawing.Point(37, 171);
            this.BTN_VolverTipMed.Name = "BTN_VolverTipMed";
            this.BTN_VolverTipMed.Size = new System.Drawing.Size(261, 27);
            this.BTN_VolverTipMed.TabIndex = 3;
            this.BTN_VolverTipMed.Text = "Volver";
            this.BTN_VolverTipMed.UseVisualStyleBackColor = false;
            this.BTN_VolverTipMed.Click += new System.EventHandler(this.BTN_VolverTipMed_Click);
            // 
            // Form3TipoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(336, 215);
            this.Controls.Add(this.BTN_VolverTipMed);
            this.Controls.Add(this.BTN_AñadirTipMed);
            this.Controls.Add(this.TXB_TipMed);
            this.Controls.Add(this.label1);
            this.Name = "Form3TipoMedico";
            this.Text = "Tipo de Medico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_TipMed;
        private System.Windows.Forms.Button BTN_AñadirTipMed;
        private System.Windows.Forms.Button BTN_VolverTipMed;
    }
}