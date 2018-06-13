using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test860
    {
        private readonly Mock<IClass860> aClass;

        public Test860()
        {
            this.aClass = new Mock<IClass860>();
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
