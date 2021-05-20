using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pruebaOficina;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {

        [TestMethod]
        [DataTestMethod]
        [DataRow("Hola abc")]
        [DataRow("hola abc")]
        public void UnaClase_returnString(string valor)
        {
            Caracteres caracteres = new Caracteres();
            UnaClase unaClase = new UnaClase(caracteres.lst);
            string resultado = unaClase.convertir(valor);

            Assert.AreEqual(resultado, "446666555202 22 222");


        }
    }
}