using System;
using Teste03;
using Xunit;

namespace XUnitTest1
{
    public class TesteCopiar
    {
        [Fact]
        public void TesteCopiar1()
        {
            int resultado = ListarArquivos.qtd;
            Assert.Equal(2, resultado);

            //}
            //[Theory]
            //[InlineData(valorEsperado1, resultado1]
            //[InlineData(valorEsperado2, resultado2]
            //public void TesteCopiar2(string dado1, string dado2 )
            //{
            //    string resultado = CopiarImagem.Equals()
            //    Assert.Equal(valor_esperado, resultado);
            //}
        }
    }
}
