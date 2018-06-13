using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test784
    {
        private readonly Mock<IClass784> aClass;

        public Test784()
        {
            this.aClass = new Mock<IClass784>();
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
