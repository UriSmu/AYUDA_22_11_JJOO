using System;
namespace Ayuda_22_11_JJOO.Models;

public class Deportista
{

    public string Apellido {get; set;}
    
    public string Nombre {get; set;}

    public DateTime FechaNacimiento {get; set;}

    public string Foto {get; set;}

    public int IdPais {get; set;}
    
    public int IdDeportes {get; set;}

    public int IdDeportistas {get; set;}
    public Deportista () {}

    public Deportista (string apellido, string nombre, DateTime fechanacimiento, string foto, int pais, int deporte, int id)
    {
        Apellido = apellido;
        Nombre = nombre;
        FechaNacimiento = fechanacimiento;
        Foto = foto; 
        IdPais = pais;
        IdDeportes = deporte;
        IdDeportistas = id;
    }
}