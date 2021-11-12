namespace TrabajoHospitalFinal11
{
    partial class Form5RemoverTurno
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBX_Persona = new System.Windows.Forms.ComboBox();
            this.CBX_Turno = new System.Windows.Forms.ComboBox();
            this.BTN_Rem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remover Turno";
            // 
            // CBX_Persona
            // 
            this.CBX_Persona.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_Persona.FormattingEnabled = true;
            this.CBX_Persona.Location = new System.Drawing.Point(26, 94);
            this.CBX_Persona.Name = "CBX_Persona";
            this.CBX_Persona.Size = new System.Drawing.Size(170, 21);
            this.CBX_Persona.TabIndex = 2;
            this.CBX_Persona.SelectedIndexChanged += new System.EventHandler(this.CBX_Persona_SelectedIndexChanged);
            // 
            // CBX_Turno
            // 
            this.CBX_Turno.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_Turno.FormattingEnabled = true;
            this.CBX_Turno.Location = new System.Drawing.Point(26, 154);
            this.CBX_Turno.Name = "CBX_Turno";
            this.CBX_Turno.Size = new System.Drawing.Size(170, 21);
            this.CBX_Turno.TabIndex = 3;
            // 
            // BTN_Rem
            // 
            this.BTN_Rem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Rem.Location = new System.Drawing.Point(26, 221);
            this.BTN_Rem.Name = "BTN_Rem";
            this.BTN_Rem.Size = new System.Drawing.Size(170, 23);
            this.BTN_Rem.TabIndex = 4;
            this.BTN_Rem.Text = "Remover";
            this.BTN_Rem.UseVisualStyleBackColor = true;
            this.BTN_Rem.Click += new System.EventHandler(this.BTN_Rem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha:";
            // 
            // Form5RemoverTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(223, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Rem);
            this.Controls.Add(this.CBX_Turno);
            this.Controls.Add(this.CBX_Persona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form5RemoverTurno";
            this.Text = "Remover Turno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBX_Persona;
        private System.Windows.Forms.ComboBox CBX_Turno;
        private System.Windows.Forms.Button BTN_Rem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}