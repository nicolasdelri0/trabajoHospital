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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_CrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2Persona form2 = new Form2Persona();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(TXB_Apellido.Text) && !String.IsNullOrEmpty(TXT_Contraseña.Text) && !String.IsNullOrEmpty(TXT_Usuario.Text))
                {
                    foreach (Administrativo a in Form2Persona.Administrativos)
                    {
                        if (TXT_Usuario.Text == a.Nombre && TXB_Apellido.Text == a.Apellido && TXT_Contraseña.Text == a.Contraseña1)
                        {
                            Form4Administrativo.nombreAdministrativo = a.Nombre;
                            this.Hide();
                            Form4Administrativo formA = new Form4Administrativo();
                            formA.Show();
                        }
                    }
                    foreach (Medico m in Form2Persona.Medicos)
                    {
                        if (TXT_Usuario.Text == m.Nombre && TXB_Apellido.Text == m.Apellido && TXT_Contraseña.Text == m.Contraseña1)
                        {
                            Form10MedicoLogin.nombreMedico = m.Nombre;
                            this.Hide();
                            Form10MedicoLogin form10 = new Form10MedicoLogin();
                            form10.Show();
                        }
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, ingrese datos validos");
            }
        }
    }
}

