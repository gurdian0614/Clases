// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
        color = "rojo";
    }

}