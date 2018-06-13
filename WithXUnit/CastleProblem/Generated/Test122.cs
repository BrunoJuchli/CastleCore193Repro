using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test122
    {
        private readonly Mock<IClass122> aClass;

        public Test122()
        {
            this.aClass = new Mock<IClass122>();
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
