namespace TrabajoHospitalFinal11
{
    partial class Form10MedicoLogin
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
            this.LBL_NomApe = new System.Windows.Forms.Label();
            this.LBL_DNI = new System.Windows.Forms.Label();
            this.LBL_TipMed = new System.Windows.Forms.Label();
            this.BTN_MostrarTurnos = new System.Windows.Forms.Button();
            this.DGV_Medico = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Medico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEDICO";
            // 
            // LBL_NomApe
            // 
            this.LBL_NomApe.AutoSize = true;
            this.LBL_NomApe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NomApe.ForeColor = System.Drawing.Color.White;
            this.LBL_NomApe.Location = new System.Drawing.Point(95, 143);
            this.LBL_NomApe.Name = "LBL_NomApe";
            this.LBL_NomApe.Size = new System.Drawing.Size(45, 17);
            this.LBL_NomApe.TabIndex = 1;
            this.LBL_NomApe.Text = "label2";
            // 
            // LBL_DNI
            // 
            this.LBL_DNI.AutoSize = true;
            this.LBL_DNI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DNI.ForeColor = System.Drawing.Color.White;
            this.LBL_DNI.Location = new System.Drawing.Point(69, 176);
            this.LBL_DNI.Name = "LBL_DNI";
            this.LBL_DNI.Size = new System.Drawing.Size(45, 17);
            this.LBL_DNI.TabIndex = 2;
            this.LBL_DNI.Text = "label3";
            // 
            // LBL_TipMed
            // 
            this.LBL_TipMed.AutoSize = true;
            this.LBL_TipMed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TipMed.ForeColor = System.Drawing.Color.White;
            this.LBL_TipMed.Location = new System.Drawing.Point(141, 211);
            this.LBL_TipMed.Name = "LBL_TipMed";
            this.LBL_TipMed.Size = new System.Drawing.Size(45, 17);
            this.LBL_TipMed.TabIndex = 3;
            this.LBL_TipMed.Text = "label4";
            // 
            // BTN_MostrarTurnos
            // 
            this.BTN_MostrarTurnos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MostrarTurnos.Location = new System.Drawing.Point(229, 112);
            this.BTN_MostrarTurnos.Name = "BTN_MostrarTurnos";
            this.BTN_MostrarTurnos.Size = new System.Drawing.Size(370, 23);
            this.BTN_MostrarTurnos.TabIndex = 4;
            this.BTN_MostrarTurnos.Text = "Mostrar turnos";
            this.BTN_MostrarTurnos.UseVisualStyleBackColor = true;
            this.BTN_MostrarTurnos.Click += new System.EventHandler(this.BTN_MostrarTurnos_Click);
            // 
            // DGV_Medico
            // 
            this.DGV_Medico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Medico.Location = new System.Drawing.Point(229, 141);
            this.DGV_Medico.Name = "DGV_Medico";
            this.DGV_Medico.Size = new System.Drawing.Size(370, 150);
            this.DGV_Medico.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Medico:";
            // 
            // BTN_Volver
            // 
            this.BTN_Volver.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Volver.Location = new System.Drawing.Point(30, 317);
            this.BTN_Volver.Name = "BTN_Volver";
            this.BTN_Volver.Size = new System.Drawing.Size(75, 23);
            this.BTN_Volver.TabIndex = 9;
            this.BTN_Volver.Text = "Volver";
            this.BTN_Volver.UseVisualStyleBackColor = true;
            this.BTN_Volver.Click += new System.EventHandler(this.BTN_Volver_Click);
            // 
            // Form10MedicoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(647, 363);
            this.Controls.Add(this.BTN_Volver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_Medico);
            this.Controls.Add(this.BTN_MostrarTurnos);
            this.Controls.Add(this.LBL_TipMed);
            this.Controls.Add(this.LBL_DNI);
            this.Controls.Add(this.LBL_NomApe);
            this.Controls.Add(this.label1);
            this.Name = "Form10MedicoLogin";
            this.Text = "Medico";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Medico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_NomApe;
        private System.Windows.Forms.Label LBL_DNI;
        private System.Windows.Forms.Label LBL_TipMed;
        private System.Windows.Forms.Button BTN_MostrarTurnos;
        private System.Windows.Forms.DataGridView DGV_Medico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Volver;
    }
}