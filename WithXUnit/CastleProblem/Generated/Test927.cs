using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test927
    {
        private readonly Mock<IClass927> aClass;

        public Test927()
        {
            this.aClass = new Mock<IClass927>();
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
