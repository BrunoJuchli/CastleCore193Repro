using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test549
    {
        private readonly Mock<IClass549> aClass;

        public Test549()
        {
            this.aClass = new Mock<IClass549>();
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
