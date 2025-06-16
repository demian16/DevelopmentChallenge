/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public static string Imprimir(List<IFormaGeometricaService> formas, IIdioma idioma)
        {
            if (!formas.Any()) return idioma.RespuestaLista;

            var sb = new StringBuilder();

            // HEADER
            sb.Append(idioma.TituloReporte);

            var reporte = new Dictionary<string, (int cantidad, decimal area, decimal perimetro)>();

            foreach (var forma in formas)
            {
                var nombreForma = string.Empty;
                var nombreSingular = forma.Nombre(idioma, 1);
                var nombrePlural = forma.Nombre(idioma, 2);

                if (!reporte.ContainsKey(nombreSingular))
                {
                    if (reporte.ContainsKey(nombrePlural))
                    {
                        nombreForma = nombrePlural;
                    }
                    else
                    {
                        nombreForma = nombreSingular;

                        reporte[nombreForma] = (0, 0, 0);
                    }
                }
                else
                {
                        nombreForma = nombreSingular;
                }

                var valorPrevio = reporte[nombreForma];

                var nuevaCantidad = valorPrevio.cantidad + 1;

                if (nuevaCantidad > 1)
                {
                    if (reporte.Any(p=> p.Key == nombreSingular)) reporte.Remove(nombreSingular);

                    if (!reporte.Any(p => p.Key == nombrePlural)) reporte[nombrePlural] = (0, 0, 0);

                    reporte[nombrePlural] = (nuevaCantidad, valorPrevio.area + forma.CalcularArea(), valorPrevio.perimetro + forma.CalcularPerimetro());

                    continue;
                }

                reporte[nombreForma] = (nuevaCantidad, valorPrevio.area + forma.CalcularArea(), valorPrevio.perimetro + forma.CalcularPerimetro());
            }

            var totalFormas = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var kvp in reporte)
            {
                var cantidad = kvp.Value.cantidad;
                var area = kvp.Value.area;
                var perimetro = kvp.Value.perimetro;

                sb.Append(idioma.Linea(cantidad, kvp.Key, area, perimetro));

                totalFormas += cantidad;
                totalArea += area;
                totalPerimetro += perimetro;
            }

            sb.Append(idioma.Total(totalFormas, totalPerimetro, totalArea));

            return sb.ToString();
        }
    }
}
