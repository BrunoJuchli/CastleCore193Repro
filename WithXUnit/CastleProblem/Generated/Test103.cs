using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test103
    {
        private readonly Mock<IClass103> aClass;

        public Test103()
        {
            this.aClass = new Mock<IClass103>();
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
