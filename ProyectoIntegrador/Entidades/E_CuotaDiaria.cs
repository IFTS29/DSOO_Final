using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Entidades
{
    public class E_CuotaDiaria
    {
        public int idCuotaDiaria { get; set; }
        public int idNoSocio { get; set; }
        public int idActividad { get; set; }
        public decimal monto { get; set; }
        public string medioPago { get; set; }
        public DateTime fechaPago { get; set; }
        public int cantCuotas { get; set; }

    }
}
