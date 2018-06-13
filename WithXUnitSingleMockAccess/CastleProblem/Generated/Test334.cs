using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test334
    {
        private readonly Mock<IClass334> aClass;

        public Test334()
        {
            this.aClass = new Mock<IClass334>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
