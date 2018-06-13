using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test340
    {
        private readonly Mock<IClass340> aClass;

        public Test340()
        {
            this.aClass = new Mock<IClass340>();
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
