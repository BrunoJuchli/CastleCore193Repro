using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test297
    {
        private readonly Mock<IClass297> aClass;

        public Test297()
        {
            this.aClass = new Mock<IClass297>();
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
