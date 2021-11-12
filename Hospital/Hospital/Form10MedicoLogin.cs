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
    public partial class Form10MedicoLogin : Form
    {
        public static string nombreMedico = "";

        public Form10MedicoLogin()
        {
            InitializeComponent();

            foreach (Medico m in Form2Persona.Medicos)
            {
                if (m.Nombre == nombreMedico)
                {
                    LBL_NomApe.Text = m.ToString();
                    LBL_DNI.Text =  Convert.ToString(m.Dni);
                    LBL_TipMed.Text = Convert.ToString(m.TipoMedico);
                }
            }
        }

        

        private void BTN_MostrarTurnos_Click(object sender, EventArgs e)
        {
            List<Turno> turnos = new List<Turno>();
            foreach(Paciente p in Form8AltaPaciente.Pacientes)
            {
                foreach(Turno t in p.Turnos)
                {
                    if(t.Medico.Nombre == nombreMedico)
                    { 
                        turnos.Add(t);
                    }
                }
            }
            DGV_Medico.DataSource = turnos;
        }

        private void BTN_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
