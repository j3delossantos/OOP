// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Text;
using SuperHeroesApp.Models;

var poderVolar = new SuperPoder();
poderVolar.Id = 1;
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad de volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Id = 2;
superFuerza.Nombre = "Super Fuerza";
superFuerza.Descripcion = "Capacidad de lebantar objetos pesados";
superFuerza.Nivel = NivelPoder.NivelTres;


var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

var superman2 = new SuperHeroe();

superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.Ciudad = "Metropolis";
superman2.PuedeVolar = true;
Console.WriteLine(superman == superman2);

SuperHeroRecord superHeroRecord = new(1, "Superman", "Clark Kent");
SuperHeroRecord superHeroRecord2 = new(1, "Superman", "Clark Kent");

Console.WriteLine(superHeroRecord == superHeroRecord2);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(superFuerza);
poderesSuperman.Add(poderVolar);
superman.SuperPoderes = poderesSuperman;
string resultSuperpoderes = superman.UsarSuperPoderes();

//Console.WriteLine(resultSuperpoderes);






enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

public record SuperHeroRecord(int id, string nombre, string identidadSecreta);