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
    public partial class Form5AsignarTurno : Form
    {
        public Form5AsignarTurno()
        {
            InitializeComponent();
            CBX_Paciente.DataSource = Form8AltaPaciente.Pacientes;
            CBX_Medico.DataSource = Form2Persona.Medicos;
        }

        private void BTN_Asignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(CBX_Paciente.Text) && !String.IsNullOrEmpty(CBX_Medico.Text) && !String.IsNullOrEmpty(CBX_Medico.Text) && !String.IsNullOrEmpty(TXB_Sintoma.Text))
                {
                    int index = 0;
                    Medico medico = null;
                    Paciente paciente = null;
                    foreach (Medico m in Form2Persona.Medicos)
                    {
                        if (m.ToString() == CBX_Medico.Text)
                        {
                            medico = m;
                            break;
                        }
                    }
                    foreach (Paciente p in Form8AltaPaciente.Pacientes)
                    {
                        if (p.ToString() == CBX_Paciente.Text)
                        {
                            paciente = p;
                            break;
                        }
                        index++;
                    }
                    Turno turno = new Turno(TXB_Sintoma.Text, DTP_Turno.Value, medico, paciente, paciente.Turnos.Count + 1);
                    Form8AltaPaciente.Pacientes[index].Turnos.Add(turno);
                    MessageBox.Show("Asignado exitosamente");
                }
                else { throw new Exception(); }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, datos no validos");
            }
        }

        private void BTN_Voler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4Administrativo form = new Form4Administrativo();
            form.Show();
        }
    }
}
