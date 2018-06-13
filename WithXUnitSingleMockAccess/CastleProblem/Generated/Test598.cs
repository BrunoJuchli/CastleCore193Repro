using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test598
    {
        private readonly Mock<IClass598> aClass;

        public Test598()
        {
            this.aClass = new Mock<IClass598>();
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
