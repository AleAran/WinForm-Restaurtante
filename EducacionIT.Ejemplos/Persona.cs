using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplos
{
    public class Persona: IEntidad
    {
        public int DNI
        {
            get;
            set;
        }

        public string Nombres
        {
            get;
            set;
        }

        public int Id
        {
            get;

            set;
        }
    }
}