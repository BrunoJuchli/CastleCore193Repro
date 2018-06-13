using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test338
    {
        private readonly Mock<IClass338> aClass;

        public Test338()
        {
            this.aClass = new Mock<IClass338>();
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
