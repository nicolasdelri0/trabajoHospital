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
    public partial class Form4Administrativo : Form
    {
        public static string nombreAdministrativo = "";

        public Form4Administrativo()
        {
            InitializeComponent();
            CBX_Paciente.DataSource = Form8AltaPaciente.Pacientes;
            foreach(Administrativo a in Form2Persona.Administrativos)
            {
                if(a.Nombre == nombreAdministrativo)
                {
                    LBL_Titulo.Text = "Saludos, " + a.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5AsignarTurno form5 = new Form5AsignarTurno();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5RemoverTurno form5 = new Form5RemoverTurno();
            form5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8AltaPaciente form8 = new Form8AltaPaciente();
            form8.Show();

        }

        private void Form4Administrativo_Load(object sender, EventArgs e)
        {

        }

        private void CBX_Paciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Paciente p in Form8AltaPaciente.Pacientes)
            {
                if(p.ToString() == CBX_Paciente.Text)
                {
                    DGV_Turnos.DataSource = p.Turnos;
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
