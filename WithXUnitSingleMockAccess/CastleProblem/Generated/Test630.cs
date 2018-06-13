using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test630
    {
        private readonly Mock<IClass630> aClass;

        public Test630()
        {
            this.aClass = new Mock<IClass630>();
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
