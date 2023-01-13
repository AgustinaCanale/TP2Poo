using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2Poo.Base;


namespace TP2Poo.Elementos
{
    public class Instructor : Persona
    {
        public Instructor(string apellido, string nombre) : base(apellido, nombre)
        {
          
        }

        public List<Materia> Materias { get; set;}


    }

    
}
