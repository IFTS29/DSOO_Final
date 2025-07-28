using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Entidades
{
    public class E_Actividad
    {
        public int idActividad { get; set; }
        public string nombreActividad { get; set; }
        public TimeSpan horaActividad { get; set; }
        public decimal costoActividad { get; set; }

        public override string ToString()
        {
            return nombreActividad;
        }
    }
}
