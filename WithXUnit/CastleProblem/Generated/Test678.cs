using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test678
    {
        private readonly Mock<IClass678> aClass;

        public Test678()
        {
            this.aClass = new Mock<IClass678>();
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
