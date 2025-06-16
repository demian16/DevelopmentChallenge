using DevelopmentChallenge.Data.Interface;
using System;
using static DevelopmentChallenge.Data.Enumeracion;

namespace DevelopmentChallenge.Data.Entidades
{
    public class Circulo : IFormaGeometricaService
    {
        private readonly decimal _lado;

        public Circulo(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea() => (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        public decimal CalcularPerimetro() => (decimal)Math.PI * _lado;
        public string Nombre(IIdioma idioma, int cantidad) => idioma.TraducirForma(TipoEnum.Circulo, cantidad);

    }
}
