using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class SuperHeroe
    {
        private string _Nombre;
        public int Id;
        public string Nombre 
        { 
            get
            {  
                return _Nombre; 
            }

            set 
            { 
                _Nombre = value.Trim();
            } 
        }

        public string NombreEIdentidadSecreta
        {  
            get 
            {
                return $"Nombre: {Nombre} \n Identidad Secreta: {IdentidadSecreta}"; 
            } 
        }

        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;


        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;


        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} \n Estatus: Esta usando el super poder {item.Nombre}!!");
            }

            return sb.ToString();
        }

    }
}
