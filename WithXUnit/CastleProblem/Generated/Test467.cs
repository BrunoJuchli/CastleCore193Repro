using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test467
    {
        private readonly Mock<IClass467> aClass;

        public Test467()
        {
            this.aClass = new Mock<IClass467>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
