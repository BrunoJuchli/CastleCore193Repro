using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test567
    {
        private readonly Mock<IClass567> aClass;

        public Test567()
        {
            this.aClass = new Mock<IClass567>();
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
