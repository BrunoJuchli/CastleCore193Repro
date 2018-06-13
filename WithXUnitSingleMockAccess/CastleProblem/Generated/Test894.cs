using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test894
    {
        private readonly Mock<IClass894> aClass;

        public Test894()
        {
            this.aClass = new Mock<IClass894>();
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
