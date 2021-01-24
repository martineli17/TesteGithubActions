using Xunit;

namespace Testes
{
    public class Teste1
    {
        [Fact(DisplayName = "01")]
        [Trait("Teste", "01")]
        public void Teste01()
        {
            Assert.True(true);
        }

        [Fact(DisplayName = "02")]
        [Trait("Teste", "02")]
        public void Teste02()
        {
            Assert.True(false);
        }
    }
}
