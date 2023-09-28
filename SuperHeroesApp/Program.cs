// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Text;

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

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(superFuerza);
poderesSuperman.Add(poderVolar);
superman.SuperPoderes = poderesSuperman;
string resultSuperpoderes = superman.UsarSuperPoderes();

Console.WriteLine(resultSuperpoderes);

class SuperHeroe
{
    public int Id;
    public string Nombre;
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
            sb.AppendLine($"{Nombre} esta usando el super poder {item.Nombre}!!");
        }

        return sb.ToString();
    }

}

class SuperPoder
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




enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}