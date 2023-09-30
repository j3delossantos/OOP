using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Interfaces
{
    internal class PrintInfo
    {
        public void PrintHero(ISuperHeroe superHeroe) 
        {
            Console.WriteLine($"Id: {superHeroe.Id}\n" +
                            $"Nombre: {superHeroe.Nombre}\n" +
                            $"Identidad Secreta: {superHeroe.IdentidadSecreta}");
        }
    }
}
