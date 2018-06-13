using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test336
    {
        private readonly Mock<IClass336> aClass;

        public Test336()
        {
            this.aClass = new Mock<IClass336>();
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
