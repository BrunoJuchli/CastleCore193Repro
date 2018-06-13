using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test845
    {
        private readonly Mock<IClass845> aClass;

        public Test845()
        {
            this.aClass = new Mock<IClass845>();
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
