namespace Calculadora.testes
{
    public class Calculadoratestes
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, Calculadora.Somar(2, 2));
        }
    }
}