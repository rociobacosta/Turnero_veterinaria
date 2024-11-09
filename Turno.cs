using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnero_veterinaria
{
    public class Turno
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public DateTime  Fecha { get; set; }
        public string Horario { get; set; }
     

        public Turno(string nom, string esp, DateTime fec, string hor)
        {
            Nombre = nom;
            Especie = esp;  
            Fecha = fec;
            Horario = hor;

            
        }
    }
}
