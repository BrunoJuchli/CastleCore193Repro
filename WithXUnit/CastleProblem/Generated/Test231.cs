using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test231
    {
        private readonly Mock<IClass231> aClass;

        public Test231()
        {
            this.aClass = new Mock<IClass231>();
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
