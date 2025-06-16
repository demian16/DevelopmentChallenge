﻿using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Entidades;
using DevelopmentChallenge.Data.Interface;
using DevelopmentChallenge.Data.Objetos;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometricaService>(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometricaService>(), new Ingles()));
        }


        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometricaService>(), new Italiano()));
        }


        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25",
                FormaGeometrica.Imprimir(
                    new List<IFormaGeometricaService>
                    {
                        new Cuadrado(5)
                    }, new Castellano()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoItaliano()
        {
            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>1 Quadrato | Area 25 | Perimetrali 20 <br/>Totale:<br/>1 forme perimetrali 20 Area 25",
                FormaGeometrica.Imprimir(
                    new List<IFormaGeometricaService>
                    {
                        new Cuadrado(5)
                    }, new Italiano()));
        }


        [TestCase]
        public void TestResumenListaConUnRectanguloCastellano()
        {
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Rectangulo | Area 8 | Perimetro 16 <br/>TOTAL:<br/>1 formas Perimetro 16 Area 8",
                FormaGeometrica.Imprimir(
                    new List<IFormaGeometricaService>
                    {
                        new Rectangulo(2,4 )
                    }, new Castellano()));
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioRectanguloCastellano()
        {
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Rectangulo | Area 6 | Perimetro 10,83 <br/>TOTAL:<br/>1 formas Perimetro 10,83 Area 6",
                FormaGeometrica.Imprimir(
                    new List<IFormaGeometricaService>
                    {
                        new TrapecioRectangulo(2,4,  2 )
                    }, new Castellano()));
        }


        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            Assert.AreEqual(
                "<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35",
                FormaGeometrica.Imprimir(
                    new List<IFormaGeometricaService>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            }, new Ingles()));
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var resultado = FormaGeometrica.Imprimir(new List<IFormaGeometricaService>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            }, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resultado);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                FormaGeometrica.Imprimir(new List<IFormaGeometricaService>
                {
                    new Cuadrado (5),
                    new Circulo(3),
                    new TrianguloEquilatero (4),
                    new Cuadrado (2),
                    new TrianguloEquilatero (9),
                    new Circulo (2.75m),
                    new TrianguloEquilatero (4.2m)
                }, new Castellano()));
        }
    }
}
