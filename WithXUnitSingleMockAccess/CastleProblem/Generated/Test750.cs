using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test750
    {
        private readonly Mock<IClass750> aClass;

        public Test750()
        {
            this.aClass = new Mock<IClass750>();
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
