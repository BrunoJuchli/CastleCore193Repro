using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test481
    {
        private readonly Mock<IClass481> aClass;

        public Test481()
        {
            this.aClass = new Mock<IClass481>();
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
