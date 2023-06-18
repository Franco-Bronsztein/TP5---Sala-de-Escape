
public static class escape
{
    private static string[] incognitasSalas = new string[5];
    private static int estadoJuego = 1;
    private static void InicializarJuego()
    {
        incognitasSalas[1] = "17";
        incognitasSalas[2] = "7";
        incognitasSalas[3] = "36";
        incognitasSalas[4] = "8";
        incognitasSalas[0] = "1";
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string clave)
    {
        InicializarJuego();
        bool devolver = false;
        if(Sala == estadoJuego) 
        {
            devolver = true;
        }
        if(clave == incognitasSalas[Sala])
        {
            estadoJuego++;
            return devolver;
        }
        else
        {
            devolver = false;
            return devolver;
        }
    }
}