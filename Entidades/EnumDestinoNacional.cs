/// <summary>
/// Atributo personalizado para almacenar la información de kilometraje asociada a un destino.
/// </summary>
public class KilometrajeAttribute : Attribute
{
    public int Kilometros { get; }

    /// <summary>
    /// Constructor de la clase KilometrajeAttribute.
    /// </summary>
    /// <param name="kilometros">Cantidad de kilómetros asociados al destino.</param>
    public KilometrajeAttribute(int kilometros)
    {
        Kilometros = kilometros;
    }
}

/// <summary>
/// Enumeración que representa destinos nacionales con sus respectivos kilómetros asociados.
/// </summary>
public enum DestinosNacionales
{
    [Kilometraje(1148)]  // Santa Rosa
    SantaRosa,
    [Kilometraje(1564)]  // Bariloche
    Bariloche,
    [Kilometraje(892)]   // Corrientes
    Corrientes,
    [Kilometraje(695)]   // Córdoba
    Cordoba,
    [Kilometraje(1602)]  // Jujuy
    Jujuy,
    [Kilometraje(1069)]  // Mendoza
    Mendoza,
    [Kilometraje(1144)]  // Neuquén
    Neuquen,
    [Kilometraje(1031)]  // Posadas
    Posadas,
    [Kilometraje(1185)]  // Iguazú
    Iguazu,
    [Kilometraje(1459)]  // Salta
    Salta,
    [Kilometraje(834)]   // Santiago del Estero
    SantiagoDelEstero,
    [Kilometraje(1609)]  // Trelew
    Trelew,
    [Kilometraje(1121)]  // Tucumán
    Tucuman,
    [Kilometraje(1003)]  // Puerto Madryn
    PuertoMadryn,
    [Kilometraje(2986)]  // Ushuaia
    Ushuaia
}
