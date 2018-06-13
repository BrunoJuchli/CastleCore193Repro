using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test766
    {
        private readonly Mock<IClass766> aClass;

        public Test766()
        {
            this.aClass = new Mock<IClass766>();
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
