using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Entidades
{
    public class E_Socio : E_Cliente
    {
        public int idSocio { get; set; }
        public string Estado { get; set; } = "Activo";  // se considera activo al finalizar inscripcion
        public bool CarnetEntregado { get; set; } = false; 
        public DateTime FechaInscripcion { get; set; }

    }

}
