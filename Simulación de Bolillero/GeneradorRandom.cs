namespace Simulación_de_Bolillero;

public class GeneradorRandom : GeneradorAleatorio
{
    private Random random;
    public GeneradorRandom()
    {
        random = new Random();
    }
    public int obtenerNuemeroAlatorio()
    {
        return random.Next();
    }
}