using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test107
    {
        private readonly Mock<IClass107> aClass;

        public Test107()
        {
            this.aClass = new Mock<IClass107>();
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
