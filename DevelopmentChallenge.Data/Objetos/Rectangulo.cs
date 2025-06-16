using DevelopmentChallenge.Data.Interface;
using static DevelopmentChallenge.Data.Enumeracion;

namespace DevelopmentChallenge.Data.Entidades
{
    public class Rectangulo : IFormaGeometricaService
    {
        private readonly decimal _valorBase;
        private readonly decimal _altura;

        public Rectangulo(decimal valorBase, decimal altura)
        {
            _valorBase = valorBase;
            _altura = altura;
        }

        public decimal CalcularArea() => _valorBase * _altura;
        public decimal CalcularPerimetro() => 2 * (_valorBase * _altura);
        public string Nombre(IIdioma idioma, int cantidad) => idioma.TraducirForma(TipoEnum.Rectangulo, cantidad);
    }
}
