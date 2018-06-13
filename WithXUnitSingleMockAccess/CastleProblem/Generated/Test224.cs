using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test224
    {
        private readonly Mock<IClass224> aClass;

        public Test224()
        {
            this.aClass = new Mock<IClass224>();
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
