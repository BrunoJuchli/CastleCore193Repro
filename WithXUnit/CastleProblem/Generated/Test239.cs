using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test239
    {
        private readonly Mock<IClass239> aClass;

        public Test239()
        {
            this.aClass = new Mock<IClass239>();
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
