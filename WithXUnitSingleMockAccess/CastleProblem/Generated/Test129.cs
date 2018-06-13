using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test129
    {
        private readonly Mock<IClass129> aClass;

        public Test129()
        {
            this.aClass = new Mock<IClass129>();
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
