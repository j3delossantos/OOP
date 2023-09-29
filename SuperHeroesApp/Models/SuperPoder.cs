using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class SuperPoder
    {
        public int Id;
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;

        public SuperPoder()
        {
            Id = 1;
            Nivel = NivelPoder.NivelUno;
        }


    }
}
