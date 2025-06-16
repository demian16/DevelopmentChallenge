using DevelopmentChallenge.Data.Interface;
using static DevelopmentChallenge.Data.Enumeracion;

namespace DevelopmentChallenge.Data.Objetos
{
    public class Italiano : IIdioma
    {
        public string RespuestaLista => "<h1>Elenco vuoto di forme!</h1>";
        public string TituloReporte => "<h1>Rapporto sulle forme</h1>";

        public string TraducirForma(TipoEnum tipo, int cantidad)
        {
            switch (tipo)
            {
                case TipoEnum.Cuadrado:
                    return cantidad == 1 ? "Quadrato" : "Piazze";
                case TipoEnum.Circulo:
                    return cantidad == 1 ? "Cerchio" : "Cerchi";
                case TipoEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangolo" : "Triangoli";
                case TipoEnum.Rectangulo:
                    return cantidad == 1 ? "Recttangolo" : "Recttangolos";
                case TipoEnum.TrapecioRectangulo:
                    return cantidad == 1 ? "Trapezio Rettangolare" : "Trapezio Rettangolo";
            }

            return string.Empty;
        }

        public string Linea(int cantidad, string nombreForma, decimal area, decimal perimetro) => $"{cantidad} {nombreForma} | Area {area:#.##} | Perimetrali {perimetro:#.##} <br/>";

        public string Total(int totalFormas, decimal perimetro, decimal area) => $"Totale:<br/>{totalFormas} forme perimetrali {perimetro:#.##} Area {area:#.##}";
    }
}
