using DevelopmentChallenge.Data.Interface;
using static DevelopmentChallenge.Data.Enumeracion;

namespace DevelopmentChallenge.Data.Objetos
{
    public class Castellano : IIdioma
    {
        public string RespuestaLista => "<h1>Lista vacía de formas!</h1>";
        public string TituloReporte => "<h1>Reporte de Formas</h1>";

        public string TraducirForma(TipoEnum tipo, int cantidad)
        {
            switch (tipo)
            {
                case TipoEnum.Cuadrado:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case TipoEnum.Circulo:
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case TipoEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
                case TipoEnum.Rectangulo:
                    return cantidad == 1 ? "Rectangulo" : "Rectangulos";
                case TipoEnum.TrapecioRectangulo:
                    return cantidad == 1 ? "Trapecio Rectangulo" : "Trapecios Rectangulos";
            }

            return string.Empty;
        }

        public string Linea(int cantidad, string nombreForma, decimal area, decimal perimetro) => $"{cantidad} {nombreForma} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

        public string Total(int totalFormas, decimal perimetro, decimal area) => $"TOTAL:<br/>{totalFormas} formas Perimetro {perimetro:#.##} Area {area:#.##}";
    }
}
