using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoHospitalFinal11
{
    public partial class Form2Persona : Form
    {
        public Form2Persona()
        {
            InitializeComponent();
            CBX_TipMed.DataSource = Form3TipoMedico.Tiposmedicos;
            CBX_PuestoE.Text = "Administrativo";
            PNL_Medico.Visible = false;
        }

        private static List<Administrativo> administrativos = new List<Administrativo>();
        private static List<Medico> medicos = new List<Medico>();

        internal static List<Administrativo> Administrativos
        {
            get
            {
                return administrativos;
            }

            set
            {
                administrativos = value;
            }
        }

        internal static List<Medico> Medicos
        {
            get
            {
                return medicos;
            }

            set
            {
                medicos = value;
            }
        }

        private void BTN_CrearE_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(TXB_NombreE.Text) && !String.IsNullOrEmpty(TXB_ContraseñaE.Text) && !String.IsNullOrEmpty(TXB_ApellidoE.Text) && !String.IsNullOrEmpty(CBX_PuestoE.Text) && NUD_DNIE.Value > 0)
                {
                    TipoMedico tipoMedico = null;
                    foreach (TipoMedico tm in Form3TipoMedico.Tiposmedicos)
                    {
                        if (tm.TipoMed == CBX_TipMed.Text)
                        {
                            tipoMedico = tm;
                        }
                    }

                    if (CBX_PuestoE.Text == "Administrativo")
                    {
                        Administrativo administrativo = new Administrativo(false, CBX_PuestoE.Text, TXB_ContraseñaE.Text, TXB_NombreE.Text, TXB_ApellidoE.Text, Convert.ToInt32(NUD_DNIE.Value));
                        Administrativos.Add(administrativo);
                        MessageBox.Show("Creado exitosamente");
                    }

                    if (CBX_PuestoE.Text == "Medico")
                    {
                        if (!String.IsNullOrEmpty(CBX_TipMed.Text))
                        {
                            Medico medico = new Medico(tipoMedico, CBX_PuestoE.Text, TXB_ContraseñaE.Text, TXB_NombreE.Text, TXB_ApellidoE.Text, Convert.ToInt32(NUD_DNIE.Value));
                            Medicos.Add(medico);
                            MessageBox.Show("Creado exitosamente");
                        }
                        else
                        {
                            { throw new Exception(); }
                        }
                        
                    }
                } else { throw new Exception(); }
            } catch(Exception ex)
            {
                MessageBox.Show("Error, datos no validos");
            }
        }

        private void CBX_PuestoE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_PuestoE.Text == "Medico")
            {
                PNL_Medico.Visible = true;
            }
            else
            {
                PNL_Medico.Visible = false;
            }
        }

        private void BTN_PNLMed_Click(object sender, EventArgs e)
        {
            Form3TipoMedico form3 = new Form3TipoMedico();
            form3.ShowDialog();
            RefreshCBX();
        }

        public void RefreshCBX()
        {
            CBX_TipMed.DataSource = null;
            CBX_TipMed.DataSource = Form3TipoMedico.Tiposmedicos;
        }

        private void BTN_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
