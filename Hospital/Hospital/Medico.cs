using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoHospitalFinal11
{
    class Medico : Empleado
    {
        private TipoMedico tipoMedico;

        internal TipoMedico TipoMedico
        {
            get
            {
                return tipoMedico;
            }

            set
            {
                tipoMedico = value;
            }
        }

        public Medico(TipoMedico tipoMedico, string puesto, string contraseña, string nombre, string apellido, int dni):base(puesto, contraseña, nombre, apellido,dni)
        {
            this.tipoMedico = tipoMedico;
        }

        public Medico() : base()
        {
            
        }

        public override string ToString()
        {
            return base.Nombre + " " + base.Apellido;
        }
    }
}
