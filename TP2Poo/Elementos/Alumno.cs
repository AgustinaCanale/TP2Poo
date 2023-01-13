using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2Poo.Base;

namespace TP2Poo.Elementos
{
    public class Alumno:Persona
    {
        public Alumno(string apellido, string nombre, string regular) : base(apellido, nombre)
        {
            Regular = regular;
        }

        public string Regular { get; set; }

    }
}
