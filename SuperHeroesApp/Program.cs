// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


var poderVolar = new SuperPoder();
poderVolar.Id = 1;
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad de volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos.ToString();

var superFuerza = new SuperPoder();
superFuerza.Id = 2;
superFuerza.Nombre = "Super Fuerza";
superFuerza.Descripcion = "Capacidad de lebantar objetos pesados";
superFuerza.Nivel = NivelPoder.NivelTres.ToString();


var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(superFuerza);
poderesSuperman.Add(poderVolar);
superman.SuperPoderes = poderesSuperman;

class SuperHeroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;
    
}

class SuperPoder
{
    public int Id;
    public string Nombre;
    public string Descripcion;
    public string Nivel;
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}