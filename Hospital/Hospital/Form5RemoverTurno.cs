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
    public partial class Form5RemoverTurno : Form
    {
        public Form5RemoverTurno()
        {
            InitializeComponent();
            CBX_Persona.DataSource = Form8AltaPaciente.Pacientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4Administrativo form = new Form4Administrativo();
            form.Show();
            this.Hide();
        }

        private void CBX_Persona_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Paciente p in Form8AltaPaciente.Pacientes)
            {
                if (p.ToString() == CBX_Persona.Text)
                {
                    CBX_Turno.DataSource = p.Turnos;
                    break;
                }
            }
        }

        private void BTN_Rem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(CBX_Persona.Text) && !String.IsNullOrEmpty(CBX_Turno.Text))
                {
                    int index = CBX_Turno.SelectedIndex;
                    foreach (Paciente p in Form8AltaPaciente.Pacientes)
                    {
                        if (p.ToString() == CBX_Persona.Text)
                        {
                            p.Turnos.RemoveAt(index);
                            break;
                        }
                    }
                    
                    RefreshCBX();
                }
                else { throw new Exception(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, datos no validos");
            }
        }

        public void RefreshCBX()
        {
            CBX_Persona.DataSource = null;
            CBX_Persona.DataSource = Form8AltaPaciente.Pacientes;
            CBX_Persona.Text = "";
            CBX_Turno.DataSource = null;
        }
    }
}
