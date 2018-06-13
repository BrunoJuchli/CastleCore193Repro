using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test554
    {
        private readonly Mock<IClass554> aClass;

        public Test554()
        {
            this.aClass = new Mock<IClass554>();
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
