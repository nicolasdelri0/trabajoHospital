using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoHospitalFinal11
{
    class Administrativo:Empleado
    {
        private bool crearTurno;

        public bool CrearTurno
        {
            get
            {
                return crearTurno;
            }

            set
            {
                crearTurno = value;
            }
        }
        public Administrativo(bool crearTurno, string puesto, string contraseña, string nombre, string apellido, int dni) :base( puesto,contraseña,nombre,apellido,dni)
        {
            this.CrearTurno = CrearTurno;
        }
        public Administrativo()
        {
        this.CrearTurno = false;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        
        public void AgregarTurno(Paciente paciente)
        {

        }

    }
}
