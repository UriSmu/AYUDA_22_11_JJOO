using System;
namespace Ayuda_22_11_JJOO.Models;

public class Deporte
{  
    public string Nombre {get; set;}

    public string Foto {get; set;}

    public int IdDeportes {get; set;}


public Deporte () {}

public Deporte (string nombre, string foto, int id)
{
   Nombre = nombre;
   Foto = foto; 
   IdDeportes = id;
}
}

