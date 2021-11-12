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
    public partial class Form3TipoMedico : Form
    {
        public Form3TipoMedico()
        {
            InitializeComponent();
        }

        private static List<TipoMedico> tiposmedicos = new List<TipoMedico>();

        internal static List<TipoMedico> Tiposmedicos
        {
            get
            {
                return tiposmedicos;
            }

            set
            {
                tiposmedicos = value;
            }
        }

        private void BTN_AñadirTipMed_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TXB_TipMed.Text))
            {
                TipoMedico tipomedico = new TipoMedico(TXB_TipMed.Text);
                Tiposmedicos.Add(tipomedico);
                TXB_TipMed.Text = "";
                MessageBox.Show("Se añadio un tipo de medico");
            } else
            {
                MessageBox.Show("Ingrese un valor");
            }
        }

        private void BTN_VolverTipMed_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
