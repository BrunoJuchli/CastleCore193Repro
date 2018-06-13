using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test220
    {
        private readonly Mock<IClass220> aClass;

        public Test220()
        {
            this.aClass = new Mock<IClass220>();
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
