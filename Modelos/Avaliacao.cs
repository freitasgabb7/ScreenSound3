namespace ScreenSound3.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        //condicao aqui
        Nota = nota;
    }
    public int Nota { get; }
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}