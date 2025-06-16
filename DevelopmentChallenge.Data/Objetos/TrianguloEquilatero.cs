using DevelopmentChallenge.Data.Interface;
using System;
using static DevelopmentChallenge.Data.Enumeracion;

namespace DevelopmentChallenge.Data.Entidades
{
    public class TrianguloEquilatero : IFormaGeometricaService
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        public decimal CalcularPerimetro() => _lado * 3;
        public string Nombre(IIdioma idioma, int cantidad) => idioma.TraducirForma(TipoEnum.TrianguloEquilatero, cantidad);
    }
}
