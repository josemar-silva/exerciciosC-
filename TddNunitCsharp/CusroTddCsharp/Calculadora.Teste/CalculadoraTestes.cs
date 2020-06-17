

using CusroTddCsharp;
using NUnit.Framework;

namespace Calculadora.Teste
{
    public class CalculadoraTestes
    {
        [TestFixture]
        public class CalculadoraSimplesTestes
        {
            [Test]
        public void DeveAdicionarDoisNumeoros()
            {
                var sut = new CalculadoraSimples();
                var resultado = sut.Adicionar(5,8);
                Assert.That(resultado, Is.EqualTo(10));
            }
        }
    }
}
