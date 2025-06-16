using DevelopmentChallenge.Data.Interface;
using static DevelopmentChallenge.Data.Enumeracion;

namespace DevelopmentChallenge.Data.Objetos
{
    public class Ingles : IIdioma
    {
        public string RespuestaLista => "<h1>Empty list of shapes!</h1>";
        public string TituloReporte => "<h1>Shapes report</h1>";

        public string TraducirForma(TipoEnum tipo, int cantidad)
        {
            switch (tipo)
            {
                case TipoEnum.Cuadrado:
                    return cantidad == 1 ? "Square" : "Squares";
                case TipoEnum.Circulo:
                    return cantidad == 1 ? "Circle" : "Circles";
                case TipoEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangle" : "Triangles";
                case TipoEnum.Rectangulo:
                    return cantidad == 1 ? "Rectangle" : "Rectangles";
                case TipoEnum.TrapecioRectangulo:
                    return cantidad == 1 ? "Rectangular Trapezoidal" : "Rectangular Trapezoids";
            }

            return string.Empty;
        }

        public string Linea(int cantidad, string nombreForma, decimal area, decimal perimetro) => $"{cantidad} {nombreForma} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";

        public string Total(int totalFormas, decimal perimetro, decimal area) => $"TOTAL:<br/>{totalFormas} shapes Perimeter {perimetro:#.##} Area {area:#.##}";
    }
}
