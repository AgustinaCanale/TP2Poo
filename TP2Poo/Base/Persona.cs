using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Poo.Base
{
    public abstract class Persona
    {
        public Persona(string apellido, string nombre)
        {
            Apellido = apellido;
            Nombre = nombre;
        }

        public string Apellido { get; set; }
        public string Nombre { get; set;}

        

    }
}
