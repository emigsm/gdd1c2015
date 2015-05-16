using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.ABMs.ABM_Cliente
{
    class Cliente
    {
        public Cliente()
        {
        }

        public Int32 Id {get;set;}
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int tipoDoc { get; set; }
        public int nroDoc { get; set; }
        public string mail { get; set; }
        public int pais { get; set; }
        public string domCalle { get; set; }
        public decimal domNumero { get; set; }
        public decimal domPiso { get; set; }
        public string domDepto { get; set; }
        public string localidad { get; set; }
        public string nacionalidad { get; set; }
        public DateTime fechaNac { get; set; }


 
    }
}
