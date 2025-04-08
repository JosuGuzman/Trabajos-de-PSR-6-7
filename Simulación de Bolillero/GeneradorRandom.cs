namespace Simulación_de_Bolillero;

public class GeneradorRandom : IGeneradorAleatorio
{
    private Random random;
    public GeneradorRandom()
    {
        random = new Random();
    }
    public int obtenerNumeroAlatorio()
    {
        return random.Next();
    }
}