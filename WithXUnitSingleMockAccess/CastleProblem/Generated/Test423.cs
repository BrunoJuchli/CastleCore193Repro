using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test423
    {
        private readonly Mock<IClass423> aClass;

        public Test423()
        {
            this.aClass = new Mock<IClass423>();
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
