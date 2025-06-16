namespace DevelopmentChallenge.Data.Interface
{
    public interface IFormaGeometricaService
    {
        decimal CalcularArea();
        decimal CalcularPerimetro();
        string Nombre(IIdioma idioma, int cantidad);
    }
}
