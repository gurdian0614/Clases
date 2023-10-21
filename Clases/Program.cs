
Ave aves = new Ave();
aves.nombre = "Tucán";
aves.color = "Negro";
aves.tamano = "Grande";
aves.familia = "Ramphastidae";
aves.sexoBiologico = "Macho";

Console.WriteLine("Nombre: " + aves.nombre);
Console.WriteLine("Color: " + aves.color);
Console.WriteLine("Tamaño: " +  aves.tamano);
Console.WriteLine("Familia: " + aves.familia);
Console.WriteLine("Sexo Biológico: " + aves.sexoBiologico);
Console.WriteLine("Es voladora: " + aves.esVoladora);

public class Ave
{
    public string nombre { get; set; }
    public string color { get; set; }
    public string tamano { get; set; }
    public string familia { get; set; }
    public string sexoBiologico { get; set; }
    public bool esVoladora { get; set; }

    /**
     * Constructor
     */
    public Ave() {
        esVoladora = true;
        color = "Rojo";
    }

}