using System;
namespace Ayuda_22_11_JJOO.Models;

public class Pais
{
    public string Nombre {get; set;}

    public DateTime FechaFundacion {get; set;}

    public string Bandera {get; set;}

    public int IdPais{get; set;}

public Pais () {}

public Pais (string nombre, DateTime fechafundacion, string bandera, int id)
{
   Nombre = nombre;
   FechaFundacion = fechafundacion;
   Bandera = bandera; 
   IdPais = id;
}

}