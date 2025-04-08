namespace Simulación_de_Bolillero;

public class Jugada
{
    private List<int> bolillas;

    public Jugada(List<int> bolillas)
    {
        this.bolillas = new List<int>(bolillas);
    }

    public List<int> Bolillas => new List<int>(bolillas);
}
