using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class DonoCalcTest
    {
        private DonoCalc _dono;

        public DonoCalcTest()
        {
            _dono = new DonoCalc();
        }

        [Fact]
        public void DeveConterONomeJacques()
        {
            // Arrange
            string texto = "Jacques";

            // Act 
            string resultado = _dono.NomeDono(texto);

            // Assert
            Assert.Equal("Jacques", resultado);
        }
    }
}