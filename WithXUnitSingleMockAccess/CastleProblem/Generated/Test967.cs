using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test967
    {
        private readonly Mock<IClass967> aClass;

        public Test967()
        {
            this.aClass = new Mock<IClass967>();
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
