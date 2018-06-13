using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test403
    {
        private readonly Mock<IClass403> aClass;

        public Test403()
        {
            this.aClass = new Mock<IClass403>();
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
