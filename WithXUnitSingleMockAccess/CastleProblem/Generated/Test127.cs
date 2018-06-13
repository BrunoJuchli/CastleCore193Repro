using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test127
    {
        private readonly Mock<IClass127> aClass;

        public Test127()
        {
            this.aClass = new Mock<IClass127>();
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
