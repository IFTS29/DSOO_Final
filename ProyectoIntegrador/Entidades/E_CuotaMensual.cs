using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoIntegrador.Entidades
{
    public class E_CuotaMensual
    {
        public int idCuota { get; set; }
        public int idSocio { get; set; }
        public decimal montoCuota { get; set; }
        public string medioPago { get; set; }
        public DateTime? fechaPago { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public int cantCuotas { get; set; }

      
    }
}