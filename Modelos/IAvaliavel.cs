namespace ScreenSound3.Modelos;

interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; }
}