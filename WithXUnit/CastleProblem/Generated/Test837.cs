using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test837
    {
        private readonly Mock<IClass837> aClass;

        public Test837()
        {
            this.aClass = new Mock<IClass837>();
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
