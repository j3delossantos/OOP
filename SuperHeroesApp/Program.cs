// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Text;
using SuperHeroesApp.Interfaces;
using SuperHeroesApp.Models;

var printInfo = new PrintInfo();

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

var regeneracion = new SuperPoder();
regeneracion.Id = 3;
regeneracion.Nombre = "regeneracion";
regeneracion.Descripcion = "Capacidad de Recuperarse de cualquier daño";
regeneracion.Nivel = NivelPoder.NivelTres;



var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "   Superman    ";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

printInfo.PrintHero(superman);

SuperHeroRecord superHeroRecord = new(1, "Superman", "Clark Kent");
SuperHeroRecord superHeroRecord2 = new(1, "Superman", "Clark Kent");

//Console.WriteLine(superHeroRecord == superHeroRecord2);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(superFuerza);
poderesSuperman.Add(poderVolar);
superman.SuperPoderes = poderesSuperman;

string resultSuperpoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperpoderes);
string resultSalvarElMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarElMundo);

Console.WriteLine(superman.SalvarPersona());






var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

printInfo.PrintHero(wolverine);

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(superFuerza);
poderesWolverine.Add(regeneracion);
wolverine.SuperPoderes = poderesWolverine;

string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);

string accionAntiHeroe = wolverine.RealizarAccionDeAntiHeroe("Ataca la Policia");
Console.WriteLine(accionAntiHeroe);





enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

public record SuperHeroRecord(int id, string nombre, string identidadSecreta);