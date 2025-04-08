namespace Simulación_de_Bolillero;

public class Bolillero
{

    private List<int> bolillas;
    private IGeneradorAleatorio generador;

    public Bolillero(List<int> bolillas, IGeneradorAleatorio generador)
    {
        this.bolillas = new List<int> (bolillas);
        this.generador = generador;
    }

    private List<int> bolillasUsadas = new();

    public int SacarBolilla()
    {
        if (bolillas.Count == 0)
        {
            throw new InvalidOperationException("No hay más bolillas en el bolillero.");
        }

        int indice = generador.obtenerNumeroAlatorio() % bolillas.Count;
        int bolilla = bolillas[indice];
        bolillas.RemoveAt(indice);
        bolillasUsadas.Add(bolilla);
        return bolilla;
    }

    public void DevolverBolillas()
    {
        bolillas.AddRange(bolillasUsadas);
        bolillasUsadas.Clear();
        Console.WriteLine("Bolillas devueltas al bolillero.");
    }

    public bool Jugar(Jugada jugada)
    {
        List<int> copiaBolillas = new List<int>(bolillas);

        foreach (int numero in jugada.Bolillas)
        {
            if (!copiaBolillas.Remove(numero))
            {
                return false;
            }
        }

        return true;
    }

    public int JugarNVeces(List<int> bolillas, int veces)
    {
        int contadorAciertos = 0;

        for (int i = 0; i < veces; i++)
        {
            if (Jugar(new Jugada(bolillas)))
            {
                contadorAciertos++;
            }
        }

        return contadorAciertos;
    }
}