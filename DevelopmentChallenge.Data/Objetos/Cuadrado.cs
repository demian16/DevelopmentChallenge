using DevelopmentChallenge.Data.Interface;
using static DevelopmentChallenge.Data.Enumeracion;

namespace DevelopmentChallenge.Data.Entidades
{
    public class Cuadrado : IFormaGeometricaService
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea() => _lado * _lado;
        public decimal CalcularPerimetro() => _lado * 4;
        public string Nombre(IIdioma idioma, int cantidad) => idioma.TraducirForma(TipoEnum.Cuadrado, cantidad);
    }
}
