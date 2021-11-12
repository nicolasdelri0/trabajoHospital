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
    public partial class Form9ObraSocial : Form
    {
        public Form9ObraSocial()
        {
            InitializeComponent();
        }

        private static List<ObraSocial> listaObras = new List<ObraSocial>();

        internal static List<ObraSocial> ListaObras
        {
            get
            {
                return listaObras;
            }

            set
            {
                listaObras = value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(TXT_Nombre.Text))
                {
                    MessageBox.Show("Datos Correctos");
                    ObraSocial obraSocial = new ObraSocial(TXT_Nombre.Text);
                    listaObras.Add(obraSocial);
                }
                else
                {
                    throw new Exception();
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }
    }
}
