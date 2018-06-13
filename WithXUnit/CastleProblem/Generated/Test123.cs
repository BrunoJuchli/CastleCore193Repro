using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test123
    {
        private readonly Mock<IClass123> aClass;

        public Test123()
        {
            this.aClass = new Mock<IClass123>();
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
