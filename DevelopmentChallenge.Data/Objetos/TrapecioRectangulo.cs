using DevelopmentChallenge.Data.Interface;
using System;
using static DevelopmentChallenge.Data.Enumeracion;

namespace DevelopmentChallenge.Data.Entidades
{
    public class TrapecioRectangulo : IFormaGeometricaService
    {
        private readonly decimal _valorBaseMayor;
        private readonly decimal _valorBaseMenor;
        private readonly decimal _altura;

        public TrapecioRectangulo(decimal altura, decimal valorBaseMayor, decimal valorBaseMenor)
        {
            _altura = altura;
            _valorBaseMayor = valorBaseMayor;
            _valorBaseMenor = valorBaseMenor;
        }

        public decimal CalcularArea() => ((_valorBaseMayor + _valorBaseMenor) * _altura) / 2;

        public decimal CalcularPerimetro()
        {
            var ladoOblicuo = (decimal)Math.Sqrt(Math.Pow((double)(_valorBaseMayor - _valorBaseMenor), 2) + Math.Pow((double)_altura, 2));
            return _valorBaseMayor + _valorBaseMenor + _altura + ladoOblicuo;
        }

        public string Nombre(IIdioma idioma, int cantidad) => idioma.TraducirForma(TipoEnum.Rectangulo, cantidad);
    }
}
