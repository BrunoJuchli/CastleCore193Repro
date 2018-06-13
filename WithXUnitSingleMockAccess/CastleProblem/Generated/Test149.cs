using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test149
    {
        private readonly Mock<IClass149> aClass;

        public Test149()
        {
            this.aClass = new Mock<IClass149>();
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
