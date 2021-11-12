using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoHospitalFinal11
{
    class Empleado : Persona
    {
        string puesto;
        string contraseña;

        

        public string Puesto
        {
            get
            {
                return puesto;
            }

            set
            {
                puesto = value;
            }
        }

        public string Contraseña1
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        public Empleado(string puesto, string contraseña, string nombre, string apellido,  int dni) : base (nombre, apellido, dni)
        {
            this.puesto = puesto;
            this.contraseña = contraseña;
        }

        public Empleado() : base()
        {
            this.puesto = "";
            this.contraseña = "";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
