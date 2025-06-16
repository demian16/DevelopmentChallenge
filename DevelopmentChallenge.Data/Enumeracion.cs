using System.ComponentModel;

namespace DevelopmentChallenge.Data
{
    public class Enumeracion
    {
        public enum TipoEnum
        {
            [Description("Cuadrado")] Cuadrado = 1,
            [Description("TrianguloEquilatero")] TrianguloEquilatero = 2,
            [Description("Circulo")] Circulo = 3,
            [Description("Rectangulo")] Rectangulo = 4,
            [Description("TrapecioRectangulo")] TrapecioRectangulo = 5
        }
    }
}
