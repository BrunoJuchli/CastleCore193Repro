using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test931
    {
        private readonly Mock<IClass931> aClass;

        public Test931()
        {
            this.aClass = new Mock<IClass931>();
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
