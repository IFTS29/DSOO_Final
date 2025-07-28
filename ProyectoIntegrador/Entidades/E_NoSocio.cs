using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Entidades
{
    public class E_NoSocio : E_Cliente
    {
        public int idNoSocio { get; set; }
        
        public DateTime FechaInscripcion { get; set; }

    }

}
