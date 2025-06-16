using static DevelopmentChallenge.Data.Enumeracion;

namespace DevelopmentChallenge.Data.Interface
{
    public interface IIdioma
    {
        string RespuestaLista { get; }
        string TituloReporte { get; }
        string TraducirForma(TipoEnum tipo, int cantidad);
        string Linea(int cantidad, string nombreForma, decimal area, decimal perimetro);
        string Total(int totalFormas, decimal perimetro, decimal area);
    }
}
