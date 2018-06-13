using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test117
    {
        private readonly Mock<IClass117> aClass;

        public Test117()
        {
            this.aClass = new Mock<IClass117>();
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
