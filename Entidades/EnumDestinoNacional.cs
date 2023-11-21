public class KilometrajeAttribute : Attribute
{
    // El atributo de kylometraje es para poder sacar el valor del vuelos segun sos km
    public int Kilometros { get; }

    public KilometrajeAttribute(int kilometros)
    {
        Kilometros = kilometros;
    }
}

public enum DestinosNacionales
{
    [Kilometraje(1148)]  // Santa Rosa
    SantaRosa,
    [Kilometraje(1564)]  // Bariloche
    Bariloche,
    [Kilometraje(892)]   // Corrientes
    Corrientes,
    [Kilometraje(695)]   // Córdoba
    Córdoba,
    [Kilometraje(1602)]  // Jujuy
    Jujuy,
    [Kilometraje(1069)]  // Mendoza
    Mendoza,
    [Kilometraje(1144)]  // Neuquén
    Neuquén,
    [Kilometraje(1031)]  // Posadas
    Posadas,
    [Kilometraje(1185)]  // Iguazú
    Iguazú,
    [Kilometraje(1459)]  // Salta
    Salta,
    [Kilometraje(834)]   // Santiago del Estero
    SantiagoDelEstero,
    [Kilometraje(1609)]  // Trelew
    Trelew,
    [Kilometraje(1121)]  // Tucumán
    Tucumán,
    [Kilometraje(1003)]  // Puerto Madryn
    PuertoMadryn,
    [Kilometraje(2986)]  // Ushuaia
    Ushuaia
}