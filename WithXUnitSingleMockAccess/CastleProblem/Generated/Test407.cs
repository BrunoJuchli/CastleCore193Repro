using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test407
    {
        private readonly Mock<IClass407> aClass;

        public Test407()
        {
            this.aClass = new Mock<IClass407>();
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
