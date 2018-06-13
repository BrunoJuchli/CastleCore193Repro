using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test491
    {
        private readonly Mock<IClass491> aClass;

        public Test491()
        {
            this.aClass = new Mock<IClass491>();
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
