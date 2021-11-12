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
    public partial class Form8AltaPaciente : Form
    {
        public Form8AltaPaciente()
        {
            InitializeComponent();
            CBX_ObraSocial.DataSource = Form9ObraSocial.ListaObras;
        }

        private static List<Paciente> pacientes = new List<Paciente>();

        internal static List<Paciente> Pacientes
        {
            get
            {
                return pacientes;
            }

            set
            {
                pacientes = value;
            }
        }

        private void Form8AltaPaciente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4Administrativo form4 = new Form4Administrativo();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9ObraSocial form9 = new Form9ObraSocial();
            form9.ShowDialog();
            RefreshCBX2();
        }

        public void RefreshCBX2()
        {
            CBX_ObraSocial.DataSource = null;
            CBX_ObraSocial.DataSource = Form9ObraSocial.ListaObras;
        }

        private void BTN_Crear_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(TXT_Apellido.Text) && !String.IsNullOrEmpty(TXT_Nombre.Text) && !String.IsNullOrEmpty(CBX_ObraSocial.Text) && NUD_DNIP.Value > 0)
                {
                    List<Turno> turnos = new List<Turno>();
                    ObraSocial obra = null;
                    foreach (ObraSocial o in Form9ObraSocial.ListaObras)
                    {
                        if (o.Nombre == CBX_ObraSocial.Text)
                        {
                            obra = new ObraSocial(o.Nombre);
                        }
                    }
                    Paciente paciente = new Paciente(obra, turnos, TXT_Nombre.Text, TXT_Apellido.Text, Convert.ToInt32(NUD_DNIP.Value));
                    pacientes.Add(paciente);
                    MessageBox.Show("Se añadio un paciente");
                }
                else { throw new Exception(); }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, datos no validos");
            }
            
        }

        
    }
}
