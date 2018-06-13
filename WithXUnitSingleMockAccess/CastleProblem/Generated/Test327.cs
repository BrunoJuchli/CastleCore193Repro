using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test327
    {
        private readonly Mock<IClass327> aClass;

        public Test327()
        {
            this.aClass = new Mock<IClass327>();
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
